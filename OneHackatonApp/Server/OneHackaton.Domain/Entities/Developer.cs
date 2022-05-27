namespace OneHackaton.Domain.Entities
{
    public class Developer : User
    {
        public virtual Team Team { get; set; }
    }
}