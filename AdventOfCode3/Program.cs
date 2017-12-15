using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode3
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputData = 325489;
            //int inputData = 25;
            Console.WriteLine("Input data = {0}", inputData);
            // Determine "square" on which puzzle input is

            int squareNumber = 0;
            int rightBottomCorner = 1;

            while (rightBottomCorner < inputData)
            {
                squareNumber++;
                rightBottomCorner = ((2 * squareNumber) + 1) * ((2 * squareNumber) + 1);
                
            }
            Console.WriteLine("Square number = {0}", squareNumber);
            Console.WriteLine("Right bottom corner values is: {0}", rightBottomCorner);
            int spiralDistance = rightBottomCorner - inputData;
            Console.WriteLine("Distance on spiral from corner to input number: {0}", spiralDistance);
            Console.ReadLine();

            // Getting back to input data from the corner
            Console.WriteLine("Spiral Distance / square number = {0}", spiralDistance / squareNumber);
            Console.WriteLine("Spiral Distance mod square number = {0}", spiralDistance % squareNumber);

            int halfSteps = 0;
            if (spiralDistance/squareNumber % 2 == 0)
            {
                halfSteps = squareNumber - (spiralDistance % squareNumber);
            }
            else
            {
                halfSteps = spiralDistance % squareNumber;
            }
            Console.WriteLine("Half steps = {0}", halfSteps);
            Console.WriteLine("Total steps = {0}", halfSteps + squareNumber);

            Console.ReadLine();
        }
    }
}
