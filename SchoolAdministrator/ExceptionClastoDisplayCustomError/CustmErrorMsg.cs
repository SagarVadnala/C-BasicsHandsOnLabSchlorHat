using System;
using System.Collections.Generic;
using System.Text;


namespace oops.ExceptionClastoDisplayCustomError
{
    public class CustmErrorMsg
    {
        public void ArthmaticExeption()
        {

            Console.WriteLine("Please Enter First Number"); 
            int NumberOne = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Please Enter Second Number"); 
            int NumberSecond = Convert.ToInt32(Console.ReadLine()); 
            
            Exep(NumberOne, NumberSecond);
        }
        public static void Exep(int NumberOne, int NumberSecond) 
        {
            try {
                int Divide = NumberOne / NumberSecond;
                Console.WriteLine("The result is: " + Divide); 
            }
            catch(ArithmeticException exception) 
            { 
                Console.WriteLine(" ");
                Console.WriteLine("Output of GetHashCode() method: ");
                Console.WriteLine(exception.GetHashCode());
                Console.WriteLine(" ");
                Console.WriteLine("Output of GetBaseException method: ");
                Console.WriteLine(exception.GetBaseException().Message);

                //Output of GetHashCode() method:
                //System.Func`1[System.Int32]

                //Output of GetBaseException method:
                //System.Func`1[System.Exception]
            } 
        }
    }
}
