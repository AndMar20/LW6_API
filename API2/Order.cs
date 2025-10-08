namespace API2
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
