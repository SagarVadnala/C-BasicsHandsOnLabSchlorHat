using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnLabSchlorHat
{
    public class StatementsAndLoops
    {
        public void CheckCharIsAlphaOrNot()
        {
            Console.WriteLine("Enter char: ");
            char ch = Convert.ToChar(Console.ReadLine());
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine($"{ch} is an Alphabet");
            }
            else
            {
                Console.WriteLine($"{ch} is not an Alphabet");
            }
        }

        public void CheckNumIsEvenOrOdd()
        {
            Console.WriteLine("Enter Num: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is Even Number");
            }
            else
            {
                Console.WriteLine($"{num} is Odd Number");

            }
        }

        //cHECK IF NUM IS POSITIVE OR NOT : sol USE  if NUM <0 THEN NEGATIVE ELSE POSITIVE

        //Partens

        public void RighttrianglePattern()
        {
            int n = 5;
            for(int i = 0; i<=n;i++)
            {
                for (int j = 0; j <= i; j++) // right triangle
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
                

        }
        public void LeftTrianglePattern()
        {
            int n = 5;
            int j;
            for (int i = 0; i <= n; i++)
            {
                for ( j=2*(n-i);j>=0;j--)
                {
                    Console.Write(" ");
                }
                for ( j = 0; j <= i; j++) 
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


        }
    }
}
