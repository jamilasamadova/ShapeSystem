using System;
namespace ShapeSystem3
{
	public class Square:Shape
	{
		public int a { get; set; }



        public Square (int a)
		{
			this.a=a;

        }

        public override double GetPerimeter()
        {
            return 4*a;
        }
        public override double GetArea()
        {
            return a * a;
        }
    }
}

