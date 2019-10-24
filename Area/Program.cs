using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius: ");
            var r = Convert.ToDouble(Console.ReadLine());          
            double pi = 3.14;
            var area = pi*r*r;

            Console.WriteLine($"The area of a circle with radius {r} is: {area}");
            
            while (r < 0)
            {
                Console.WriteLine("The input must be more than 0. TRY AGAIN!!!");

            }
            Console.ReadLine();



        }
    }
}
