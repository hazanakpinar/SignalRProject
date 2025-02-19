namespace SignalR.Entities.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }

        //rm np
        public List<Product> Products { get; set; }

    }
}
