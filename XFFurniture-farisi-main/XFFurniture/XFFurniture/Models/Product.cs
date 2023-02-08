using System;
using System.Collections.Generic;

namespace XFFurniture.Models
{
    public class Product
    {
        public Product()
        {
            this.colors = new List<Color>();
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }
        public string description { get; set; }
        public double rating { get; set; }
        public int review { get; set; }
        public double oldPrice { get; set; }
        public double newPrice { get; set; }
        public bool favorite { get; set; }
        public double discount { get; set; }
        public string image { get; set; }
        public List<Color> colors { get; set; }
        public string createdBy { get; set; }
        public string overview { get; set; }
        public static List<Product> Contoh()
        {
            List<Product> hsl = new List<Product>();
            var p1 = new Product()
            {
                Id = "8",
                description = "Lorem ipsum dolar sit amet",
                rating = 1,
                review = 100,
                oldPrice = 2000,
                newPrice = 2500,
                favorite = true,
                discount = 20,
                image = "https://m.media-amazon.com/images/I/81TNI0z9FML._AC_SX679_.jpg",
                colors = new List<Color>()
            {
                new Color() { color = "#9AADB0" },
                new Color() { color = "#54889A", selected = true },
                new Color() { color = "#3B3B3B" }
            },
                createdBy = "ipsum",
                overview = "dolar sit amet"
            };
            hsl.Add(p1);

            return hsl;
        }
    }

    public class Color
    {
        public string color { get; set; }
        public bool selected { get; set; }
    }

    
}
