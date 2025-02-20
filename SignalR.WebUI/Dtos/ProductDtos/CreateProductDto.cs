﻿namespace SignalR.WebUI.Dtos.ProductDtos
{
    public class CreateProductDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }
        public int CategoryId { get; set; }

    }
}
