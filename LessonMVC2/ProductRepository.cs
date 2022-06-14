using LessonMVC2.Models;
using System.Collections.Generic;

namespace LessonMVC2
{
    public class ProductRepository
    {

        private static List<Product> products = new List<Product>()
        {

            new Product("Name1",1d,"decription1"),
            new Product("Name2",2d,"decription2"),
            new Product("Name2",2d,"decription2")

        };

        public List<Product> GetAll()
        {
            return products;
        }

    }
}
