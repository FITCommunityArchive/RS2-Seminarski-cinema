namespace Cinema.Domain.Entities
{
    public class Review : BaseClass
    {
        public string Text { get; set; }
        public decimal Rating { get; set; }
        public virtual User User { get; set; }
        public virtual Movie Movie { get; set; }
    }
}