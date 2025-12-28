using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
     class ProductManager
    {
        //encapsulation - id vb. tek tek parametre yollamak yerine product nesnesi yolladık
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " added.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " updated.");
        }
    }
}
