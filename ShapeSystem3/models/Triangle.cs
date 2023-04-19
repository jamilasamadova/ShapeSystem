using System;
namespace ShapeSystem3
{
	public class Triangle : Shape
	{
		public int a { get; set; }
		public int b { get; set; }
		public int c { get; set; }



		public Triangle(int a, int b, int c)
		{
			this.a = a;
			this.b = b;
			this.c = c;

		}


		public override double GetPerimeter()
		{

			return (a + b + c);



		}
		public override double GetArea()
		{

			return 2 * (a + b);



		}

	}
}
