using System.Security.Claims;
using OneHackaton.Domain.UserMetadata;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using OneHackaton.Infrastructure.Middlewares.Commands;
using OneHackaton.Domain.UsersAggregate;

namespace OneHackaton.Infrastructure.Middlewares;

public class GetUserContextMiddleware
{
    private readonly RequestDelegate _next;
    private readonly IMediator _mediator;
    private readonly string _connectionString;

    public GetUserContextMiddleware(RequestDelegate next, string connectionString, IMediator mediator)
    {
        _next = next;
        _connectionString = connectionString;
        _mediator = mediator;
    }

    public async Task Invoke(HttpContext context, IUsersServiceQueries usersServiceQueries)
    {
        var userEmail = context.User.Claims.FirstOrDefault(c => c.Type == IUserMetadata.Email)?.Value;

        //Cache userId for 20 seconds
        var id = context.User.FindFirst(c => c.Type == ClaimTypes.NameIdentifier);

        //Requests without token.
        if (id == null)
        {
            await _next(context);
            return;
        }

        var memoryCache = context.RequestServices.GetRequiredService<IMemoryCache>();
        var userId = memoryCache.GetOrCreate($"USER_{id}", entry =>
        {
            entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(20);
            return entry.Value;
        });

        if (userId != null)
        {
            context.User.AddIdentity(new ClaimsIdentity(new List<Claim>
            {
                new(IUserMetadata.UserId, userId.ToString())
            }));
        }
        else
        {
            var user = await usersServiceQueries.GetApplicationUserByEmail(userEmail);
            if (user != null)
            {
                memoryCache.Set($"USER_{id}", user.Id);
            }
            else
            {
                var command = new CreateNewUserCommand(userEmail, "nickname");
                await _mediator.Send(command);
                var createdUser = await usersServiceQueries.GetApplicationUserByEmail(userEmail);
                memoryCache.Set($"USER_{id}", createdUser.Id);
            }
        }

        await _next(context);
    }
}