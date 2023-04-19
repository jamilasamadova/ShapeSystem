using System;

namespace ShapeSystem3;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1-Rectangle");
        Console.WriteLine("2-Triangle");
        Console.WriteLine("3-Square");
        Console.WriteLine("Fiqurun nömrəsini daxil edin:");

        int ShapeNumber = int.Parse(Console.ReadLine());


        
        Console.WriteLine("1 - Perimetrini hesabla");
        Console.WriteLine("2 - Sahəsini hesabla");
        Console.WriteLine("Emeliyyat nomresini daxil edin:");

        int OperationIndex = int.Parse(Console.ReadLine());


        
        switch (ShapeNumber)

            {

            case 1:
                {
                    Console.WriteLine("Plase enter figure height: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Plase enter figure width: ");
                    int b = int.Parse(Console.ReadLine());
                    Rectangle rectangle1 = new Rectangle(a, b);

                    if (OperationIndex == 1)
                    {
                        Console.WriteLine("Perimeter of figure: " + rectangle1.GetPerimeter());
                    }
                    else if (OperationIndex == 2)
                    {
                        Console.WriteLine("Area of shape: " + rectangle1.GetArea());
                    }
                    

                    else {


                    Console.WriteLine("Operation don't find");

                    }
                    break;
                   }

                        
            case 2:
                {

                    Console.WriteLine("Plase enter shape side: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Plase enter shape side: ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Plase enter shape side: ");
                    int c = int.Parse(Console.ReadLine());
                    Triangle triangle1 = new Triangle(a, b,c);

                    if (OperationIndex == 1)
                    {
                        Console.WriteLine("Perimeter of figure: " + triangle1.GetPerimeter());
                    }
                    else if (OperationIndex == 2)
                    {
                        Console.WriteLine("Area of shape: " + triangle1.GetArea());
                    }
                    else
                    {


                        Console.WriteLine("Operation don't find");

                    }
                    break;

                   

                }

                 case 3:
                {

                    Console.WriteLine("Plase enter shape side: ");
                    int a = int.Parse(Console.ReadLine());

                    Square square1 = new Square(a);

                    if (OperationIndex == 1)
                    {
                        Console.WriteLine("Perimeter of figure: " + square1.GetPerimeter());
                    }
                    else if (OperationIndex == 2)
                    {
                        Console.WriteLine("Area of shape: " + square1.GetArea());
                    }
                    else
                    {


                        Console.WriteLine("Operation don't find");

                    }
                    break;


                 
                }

        }

    }
}

