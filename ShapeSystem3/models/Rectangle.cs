using System;
namespace ShapeSystem3
{
	public class Rectangle:Shape
	{
		public int a { get; set; }
		public int b { get; set; }
		


		public Rectangle (int a, int b)
		{

		 this.a=a;
         this.b=b;
		

		}

        public override double GetPerimeter()
        {
            return 2*(a+b);
        }
        public override double GetArea()
        {
            return a*b ;
        }
    }
}

