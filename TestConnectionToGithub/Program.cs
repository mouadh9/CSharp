using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConnectionToGithub
{
    //enum Direction { North, South, East, West }
    class Program
    {
        static void Main(string[] args)
        {
            //List<Direction> directions = new List<Direction>();
            List<string> directions = new List<string>();

            char input;

            do
            {
                Console.WriteLine("Enter the next direction (n/s/e/w or 0)");
                input = Console.ReadKey().KeyChar;
                Console.ReadLine();

                switch (input)
                {
                    case 'n':
                        directions.Add("North");
                        break;
                    case 's':
                        directions.Add("South");
                        break;
                    case 'e':
                        directions.Add("East");
                        break;
                    case 'w':
                        directions.Add("West");
                        break;
                    case '0':
                        break;
                    default:
                        Console.WriteLine("Error Input");
                        break;
                }
            } while (input != '0');
            Console.Write($"\nYou Entred {directions.Count} Element");

            foreach (var direction in directions)
            {
                Console.WriteLine($"{DirectionToSymbol(direction)}");
            }
            Console.ReadKey();
        }
        static string DirectionToSymbol(string direction)
        {
            switch (direction)
            {
                case "North":
                    return "fou9";
                case "South":
                    return "louta";
                case "East":
                    return "<";
                case "West":
                    return ">";
                default:
                    return "";


            }
        }
    }
}
