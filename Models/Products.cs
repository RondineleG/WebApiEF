using System;

namespace DevApi.Models
{
    public class Products
    {
        public Products()
        {
            
        }
        public int Id { get; set; }

        public string Title { get; set; }

        public string  Description { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string Image { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public int CategoyId {get;set;}

        public Category Category { get; set; }
    }
}