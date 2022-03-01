using System;


namespace LineComparisonProblem
{
    public  class Cartesiansystem
    {
      public static void Calculatinglength()
        {

            Console.WriteLine("Enter the value of x1 :");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of y1 :");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of x2:");
            double x2= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of y2:");
            double y2= Convert.ToDouble(Console.ReadLine());

            double a = Math.Pow((x2 - x1), 2);
            double b = Math.Pow((y2 - y1), 2);
            double result = Math.Sqrt(a + b);


            Console.WriteLine("The length of Line is :" + result);

        }
    }
}
