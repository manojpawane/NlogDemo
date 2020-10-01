using System;

namespace NLogDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First number for addition");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second number for addition");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            AddNumbers addNumbers = new AddNumbers();
            //int sum = addNumbers.Add(firstNumber, secondNumber);
            Console.WriteLine("Addition of "+ firstNumber +" and "+secondNumber+ " is "+ 
                addNumbers.Add(firstNumber, secondNumber));
            Console.ReadKey();
        }
    }
}
