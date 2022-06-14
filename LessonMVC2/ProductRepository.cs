using LessonMVC2.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public Product TryGetById(int id)
        {

            return products.FirstOrDefault(producte => producte.Id == id);
            //foreach(var product in products)
            //{
            //    if (product.Id == id)
            //    {
            //        return product;
            //    }
            //}
            //return null;
        }
    }
}
