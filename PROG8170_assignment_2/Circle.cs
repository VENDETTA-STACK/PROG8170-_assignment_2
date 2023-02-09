using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8170_assignment_2
{
    public class Circle
    {
        private int circle_radius;

        public Circle()
        {
            circle_radius = 1;
        }

        public int GetRadius()
        {
            Console.WriteLine("Circle Radius: {0} \n", circle_radius);
            return circle_radius;
        }

        public void SetRadius(int radius)
        {

            if (radius > 0)
            {
                circle_radius = radius;
                Console.WriteLine("Circle radius set to: {0} \n", circle_radius);
            }
            else
            {
                Console.WriteLine("Radius can not be negative value");
            }
        }

        public double GetCircumference()
        {
            Console.WriteLine("Circle circumference: {0} \n", 2 * 3.14 * circle_radius);
            return (2 * 3.14 * circle_radius);
        }

        public double GetArea()
        {
            double area = Math.Round(3.14 * circle_radius * circle_radius, 2);
            Console.WriteLine("Circle area: {0} \n", area);
            return area;
        }

    }
}
