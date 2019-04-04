using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monte_Carlo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int arrayLength = Convert.ToInt32(Console.ReadLine());

            Coordinate[] coordinates = new Coordinate[arrayLength];
            int[] myarray = new int[2];

            Random random = new Random();

            int counter = 0;

            for (int i = 0; i < arrayLength; i++)
            {
                coordinates[i] = new Coordinate(random);
                if (coordinates[i].Hypotenuse() <= 1)
                {
                    counter++;
                }
            }

            double avg = (counter / (double)coordinates.Length) * 4;

            Console.WriteLine($"Total # of points = {counter}");

            Console.WriteLine($"Generated PI = {avg}, real PI = {Math.PI}, difference = {Math.Abs(Math.PI - avg)}");

            Console.ReadKey();
        }
    }
}
