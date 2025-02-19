namespace SignalR.Entities.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public  string Image { get; set; }
        public bool Status { get; set; }

        //rm np
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
