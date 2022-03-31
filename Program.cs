using System;

namespace ImplicitHM
{
    class Program
    {
        static void Main(string[] args)
        {
           
           Celcius celcius = new Celcius(100);
           Kelvin kelvin = celcius;
            Console.WriteLine(kelvin.Degree);


        }
    }
}
