using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace w8t4oop1
{
    class Ring
    {
        //Declare variables
        private double radiusInner;
        private double radiusOuter;
        private double innerCircleArea;
        private double outerCircleArea;
        private double ringArea;


        //calculate the area of a circle
        public Ring (double radiusInnerIn, double radiusOuterIn)
        {
            radiusInner = radiusInnerIn;
            radiusOuter = radiusOuterIn;         
        }

        public double InnerCircleArea
        {
            get
            {
                return (Math.PI * (radiusInner * radiusInner));
            }
            
            set
            {
                innerCircleArea = value;
            }
    
        }

        public double OuterCircleArea
        {
            get
            {
                return (Math.PI * (radiusOuter * radiusOuter));
            }
            
            set
            {
                outerCircleArea = value;
            }    
        }

        public double RingArea
        {
            get
            {
                //return (OuterCircleArea - InnerCircleArea);
                return Math.Round((OuterCircleArea - InnerCircleArea), 2); 
            }

            set
            {
                ringArea = value;
            }
        }
    }
}
