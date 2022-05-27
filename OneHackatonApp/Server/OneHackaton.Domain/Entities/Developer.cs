namespace OneHackaton.Domain.Entities
{
    public class Developer : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Team Team { get; set; }
    }
}