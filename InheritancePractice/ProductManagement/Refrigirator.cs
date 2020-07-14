using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement
{
    class Refrigirator : Product
    {
        internal int capacity;
        internal string color;
        internal string door;
        internal void SetProductData(int productId, string model, string brand, int price, int capacity, string color, string door)
        {
            base.SetProductData(productId, model, brand, price);
            this.capacity= capacity;
            this.color = color;
            this.door = door;
        }
        internal void Display()
        {
            base.Display();
            Console.WriteLine($"Capacity : {capacity} Color : {color} Door : {door} ");
        }
    }
}
