using System;

namespace DelegateDemoMastek
{
    //1
    delegate int CalculatorDelegate(int first, int second);
    class Program
    {
        //2
        static int AddNumbers(int number1, int number2)
        {
            return number1 + number2;
        }
        static void Main(string[] args)
        {
            //3 delegate instance - points to a method
            //CalculatorDelegate demo1=new CalculatorDelegate(AddNumbers);

            CalculatorDelegate demo1 = AddNumbers;

            //4 invoke delegate
            int result = demo1(4, 6);

            Console.WriteLine("Addition : " + result );
            //Console.WriteLine("Hello World!");
            //multiplication


            Console.WriteLine("---------------");

            //.net fw 3.5 -2008 lamda expression
            //merge step 2+3
            //(input param)=>expression


            CalculatorDelegate demo2 = (a, b) => a + b;
            result = demo2(2, 4);
            Console.WriteLine("Addition = " + result);
            Console.WriteLine("-------------");

            
            //Sub
            demo2 = (a, b) => a - b;
            result = demo2(6, 4);
            Console.WriteLine("Sub = " + result);
            //Console.WriteLine("-------------");

            //Mul
            demo2 = (a, b) => a * b;
            result = demo2(3, 4);
            Console.WriteLine("Mul = " + result);
            //Console.WriteLine("-------------");

            //div
            demo2 = (a, b) => a / b;
            result = demo2(4, 4);
            Console.WriteLine("Div = " + result);
            //Console.WriteLine("-------------");

        }
        
        
    }
}
