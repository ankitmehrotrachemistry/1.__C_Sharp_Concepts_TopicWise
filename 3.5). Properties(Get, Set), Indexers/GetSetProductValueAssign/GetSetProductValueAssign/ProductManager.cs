using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetProductValueAssign
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Product1 ID is " +product.Id);
            Console.WriteLine("Category1 ID is " +product.CategoryId);
            Console.WriteLine(product.ProductName + " added");
            Console.WriteLine("Unit Price 1 is " + product.UnitPrice);

            Console.WriteLine("----------------------------------");
        }
        public void Update(Product product)
        {
            Console.WriteLine("Product2 ID is " +product.Id);
            Console.WriteLine("Category2 ID is " +product.CategoryId);
            Console.WriteLine(product.ProductName + " updated");
            Console.WriteLine("Unit Price 2 is " + product.UnitPrice);

            Console.WriteLine("----------------------------------");
        }
    }
}
