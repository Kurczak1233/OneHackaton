namespace OneHackaton.Domain
{
    public class Developer : User
    {
        public virtual Team Team { get; set; }
    }
}