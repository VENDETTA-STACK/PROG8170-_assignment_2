using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8170_assignment_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                bool isValid = false;
                /*int radius;*/
                Circle circleObj = new Circle();

                /*while (!isValid)
                {
                    Console.Write("Please enter the circle radius: ");

                    radius = Convert.ToInt32(Console.ReadLine());

                    if (radius < 0 || radius == 0)
                    {
                        Console.Write("Please enter valid radius");
                    }
                    else
                    {
                        isValid = true;
                        circleObj.SetRadius(radius);
                    }
                }*/

                Console.WriteLine("\t ========================= \t \n");

                Console.WriteLine("1. Get Circle Radius");
                Console.WriteLine("2. Change Circle Radius");
                Console.WriteLine("3. Get Circle Circumference");
                Console.WriteLine("4. Get Circle Area");
                Console.WriteLine("5. Exit \r\n");

                Console.WriteLine("\t ========================= \t \n");

                bool isLoop = false;

                while (!isLoop)
                {
                    Console.Write("Please enter your choice: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            circleObj.GetRadius();
                            break;
                        case "2":
                            Console.Write("Please enter the circle radius: ");

                            int newRadius = Convert.ToInt32(Console.ReadLine());

                            circleObj.SetRadius(newRadius);

                            break;
                        case "3":
                            circleObj.GetCircumference();
                            break;
                        case "4":
                            circleObj.GetArea();
                            break;
                        case "5":
                            System.Environment.Exit(1);
                            break;
                        default:
                            Console.WriteLine("Please enter valid input choice");
                            break;
                    }
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
