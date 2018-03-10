using System;
using System.Linq;

namespace exerciseWeek1Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start the program with Clear();
            Console.Clear();
            
            //Task7 - Write a console application that takes three numbers from the user and displays the largest number on the screen.
           int num1, num2, num3;
           Console.Write("Please enter in the first number: ");
           var isNum1 = int.TryParse(Console.ReadLine(), out num1);

           Console.Write("Please enter in a second number: ");
           var isNum2 = int.TryParse(Console.ReadLine(), out num2);

           Console.Write("Please enter in the third number: ");
           var isNum3 = int.TryParse(Console.ReadLine(), out num3);
           
           if (isNum1 && isNum2 && isNum3){
               var arr = new int[] {num1, num2, num3}; 

               int maxValue = arr.Max();
               int maxIndex = arr.ToList().IndexOf(maxValue);

                Console.WriteLine(maxValue);
                Console.WriteLine(maxIndex);


           }
            
            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();

            
        }
    }
}
