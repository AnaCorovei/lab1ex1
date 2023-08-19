using System;

namespace lab1ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ex1 
            Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui
            paralelipiped dreptunghic, va afisa volumul lui */

            int length;
            int width;
            int height;
          
            Console.WriteLine("Enter length: ");
            length = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Introduceti width: ");
            width = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti height: ");
            height = int.Parse(Console.ReadLine());

            int volum = length * width * height;

            Console.WriteLine("The Rectangular parallelepiped volum is: " + volum);
        }
    }
}
