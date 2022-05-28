using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Domain.DbScheme
{
    public static class DbSchemas
    {
        public const string Dbo = "dbo";
    }

    public static class Dbo
    {
        private static readonly string _schema = DbSchemas.Dbo;
        public static string Users { get; } = $"[{_schema}].[{nameof(Users)}]";
        public static string Posts { get; } = $"[{_schema}].[{nameof(Posts)}]";

    }
}
