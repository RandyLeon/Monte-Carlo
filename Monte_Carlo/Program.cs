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
            //Retrieve an int from the console. Ask for the int
            Console.WriteLine("Enter a number:");
            int arrayLength = Convert.ToInt32(Console.ReadLine());

            Coordinate[] coordinates = new Coordinate[arrayLength];
            int[] myarray = new int[2];

            Random random = new Random();

            //iterate over the array, incrementing a counter for each coordinate which overlaps the unit circle
            int counter = 0;

            for (int i = 0; i < arrayLength; i++)
            {
                coordinates[i] = new Coordinate(random);
                if (coordinates[i].Hypotenuse() <= 1)
                {
                    counter++;
                }
            }

            //using the length parameter of the array, divide the number of coordinates overlaping by the number of array elements. multiply this value by 4
            double avg = (counter / (double)coordinates.Length) * 4;

            //Print the value from step 4 along wit the absolute value of the diff between your estimate of pi and Math.Pi
            Console.WriteLine($"Total # of points = {counter}");

            //absolute value of the diff between your estimate of pi and math.pi
            Console.WriteLine($"Generated PI = {avg}, real PI = {Math.PI}, difference = {Math.Abs(Math.PI - avg)}");

            Console.ReadKey();
        }
    }
}
