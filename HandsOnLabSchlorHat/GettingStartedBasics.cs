using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnLabSchlorHat
{
    public class GettingStartedBasics
    {
        public void AreaOfSqr()
        {
            Console.WriteLine("enter side of sqr: ");
            int side= Convert.ToInt32(Console.ReadLine());
            int area = side * side;
            Console.WriteLine($"Area of square is: {area}");
        }


        public void SwapWithSecondVar()
        {
            int a = 5;
            int b = 10;
            int temp;
            Console.WriteLine($"values of a:{a} & b: {b}");
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"values of a:{a} & b: {b}");

        }
        public void SwapWithOutSecondVar()
        {
            int a = 5;
            int b = 10;
            
            Console.WriteLine($"values of a:{a} & b: {b}");
            a = a + b;  // 5+10 = 15
            b= a - b;     // b= 15-10 = 5
            a = a - b;    // a= 15-5 = 10

            Console.WriteLine($"values of a:{a} & b: {b}");

        }

        public void SumOfAllNum()
        {
            Console.WriteLine("enter Number: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            
            while(Number !=0)
            {
                sum = sum + Number % 10;
                Number = Number / 10;

            }
            Console.WriteLine($"SUM is {sum}");
        }
    }

   
}
