using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetProductValueAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();

            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Table";
            product1.UnitPrice = 500.50;
            product1.UnitsInStock = 2;


            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 5,
                UnitsInStock = 5,
                ProductName = "Pencil",
                UnitPrice = 35.50
            };

            ProductManager productManager =
                 new ProductManager();

            productManager.Add(product1);
            productManager.Update(product2);
        }
    }
}
