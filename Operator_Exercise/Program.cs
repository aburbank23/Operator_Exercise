using System;

namespace Operator_Exercise
{
    class Program
    {

        public static double AreaofCircle(double radius)
        {
            double pi = Math.PI;
            double radiusNum = Math.Pow(radius, 2);

            double area = pi * radiusNum;
            return area;
            
        }




        static void Main(string[] args)
        {

            //CREATING A DIVISION PROBLEM WITH A REMAINDE - BEGIN ----------

            var c = 10;
            var d = 6;

            var divisionWholeNum = c / d;
            var remainderNum = c % d;

            Console.WriteLine($"{c} / {d} gives you {divisionWholeNum} with a remainder of {remainderNum}");

            //END----------------------------------------------------------




            Console.WriteLine(AreaofCircle(2));







            //----------------------OLD EXAMPLE------------------------------


            /*
            var a = 17;
            var b = 4;

            var quotient = a / b;

            var remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            */


            //----------------------OLD EXAMPLE------------------------------



            //var x = AreaOfCircle(2);
            //Console.WriteLine(x);

            //Console.WriteLine(AreaOfCircle(2.2));

            /*
            var r = 20;
            var pi = Math.PI;

            var areaOfCircle = pi * (r * r);

            Console.WriteLine($"The area of this circle is {areaOfCircle}");

    
            }

            public static double AreaOfCircle(double radius)
            {
                return Math.PI * Math.Pow(radius, 2);
            }
            */



            //----------------------OLD EXAMPLE------------------------------




        }
    }
}
