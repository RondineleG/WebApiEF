using System.Collections.Generic;

namespace DevApi.Models
{
    public class Category
    {
        public Category()
        {           

        }
        public int Id { get; set; }

        public string Title { get; set; }

        public IEnumerable<Products> Products { get; set; }

    }


}