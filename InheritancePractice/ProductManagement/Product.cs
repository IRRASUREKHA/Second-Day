using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement
{
    class Product
    {
        int productId;
        string model;
        string brand;
        int price;
        internal void SetProductData(int productId, string model, string brand, int price)
        {
            this.productId = productId;
            this.model = model;
            this.brand = brand;
            this.price = price;

        }
        protected void Display()
        {
            Console.WriteLine($"ID : {productId} Brand : {brand} Model : {model} Price : {price}");
        }

    }
}
