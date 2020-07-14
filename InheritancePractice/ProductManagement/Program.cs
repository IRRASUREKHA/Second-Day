using System;
using System.Reflection.Emit;

namespace ProductManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Refrigirator fridge;
            fridge = new Refrigirator();
            fridge.SetProductData(1234, "S3l", "Sony", 34000, 4, "Red", "Double door");
            fridge.Display();
        }
    }
}
