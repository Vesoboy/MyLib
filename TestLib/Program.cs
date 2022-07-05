using System;
using MyClass;
namespace TestLib
{
    class Program
    {
        static void Main(string[] args)
        {
            var test1 = new MyLib();
            Console.WriteLine(test1.SquareRadius(5.5));
            Console.WriteLine(test1.SquareTriangle(4,8,9));
            Console.WriteLine(test1.CheckForSquareness(3, 4, 5));
        }
    }
}


