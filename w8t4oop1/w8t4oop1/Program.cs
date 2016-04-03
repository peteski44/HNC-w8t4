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
            double ringInnerIn = 0;
            double ringOuterIn = 0;
            
            Console.WriteLine("Enter the radius of the inside of the ring");
            ringInnerIn = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the radius of the outside of the ring");
            ringOuterIn = Convert.ToDouble(Console.ReadLine());


            Ring ring1 = new Ring(ringInnerIn, ringOuterIn);

            Console.WriteLine("the area of the inner circle is: {0}", ring1.InnerCircleArea);
            Console.WriteLine("the area of the outer circle is {0}", ring1.OuterCircleArea);
            Console.WriteLine("the area of the ring is {0}", ring1.RingArea);
            
        }
    }
}
