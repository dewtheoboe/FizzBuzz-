using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz2._0
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("What number would you like your game of FizzBuzz to start on?");
                int startNum = int.Parse(Console.ReadLine());

                Console.WriteLine("What number would you like your game to end on?");
                int endNum = int.Parse(Console.ReadLine());

                while (startNum >= endNum)
                {
                    Console.WriteLine("The game cannot begin on a number that is higher than the number it ends on. Please resubmit.");
                    Console.WriteLine("What number would you like your game of FizzBuzz to start on?");
                    startNum = int.Parse(Console.ReadLine());

                    Console.WriteLine("What number would you like your game to end on?");
                    endNum = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("The correct FizzBuzz answers are:");

                while (startNum <= endNum)
                {
                    if (startNum % 15 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                        startNum++;
                    }
                    else if (startNum % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                        startNum++;
                    }
                    else if (startNum % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                        startNum++;
                    }
                    else
                    {
                        Console.WriteLine(startNum);
                        startNum++;
                    }
                }

                Console.WriteLine("Did they get it right?");
                Console.ReadLine();

            }


        }
    }



