using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace w8t4oop1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Peter Day, 277181, 24/02/16, Version 1.0
            /*Application to request two numeric values, for the inside radius and outside radius of a ring object, and calculate the area othe ring.*/

            //Variables for user input 
            double ringInnerIn = 0;
            double ringOuterIn = 0;
            
            //Request for Inner radius value
            Console.WriteLine("Enter the radius of the inside of the ring");
            ringInnerIn = Convert.ToDouble(Console.ReadLine());

            //Request for Outer radius value
            Console.WriteLine("Enter the radius of the outside of the ring");
            ringOuterIn = Convert.ToDouble(Console.ReadLine());

            //Instantiate ring object
            Ring ring1 = new Ring(ringInnerIn, ringOuterIn);

            //Call method in class and display results
            Console.WriteLine("the area of the inner circle is: {0}", ring1.InnerCircleArea);
            Console.WriteLine("the area of the outer circle is {0}", ring1.OuterCircleArea);
            Console.WriteLine("the area of the ring is {0}", ring1.RingArea);

            //Additional comments to test Github process
            
        }
    }
}
