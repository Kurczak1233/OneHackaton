namespace OneHackaton.Domain.Entities
{
    public class Developer : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Team Team { get; set; }
    }
}