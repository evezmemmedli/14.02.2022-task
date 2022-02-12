using System;

namespace _14._02._2022_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Task1();
            Task2();
        }

        public static void Task1()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            dividedBy7(number);
        }
        public static void Task2()
        {
            Console.WriteLine("1-ci ededi daxil edin");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2-ci ededi daxil edin");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Operatoru elave edin (+, -, *, /)");
            string Operator = Convert.ToString(Console.ReadLine());
            switch (Operator)
            {
                case "+":
                    plus(number1, number2);
                    break;
                case "-":
                    minus(number1, number2);
                    break;
                case "*":
                    multiplication(number1, number2);
                    break;
                case "/":
                    divide(number1, number2);
                    break;

                default:
                    Console.WriteLine("Daxil edilen proses proqrama uygun deyil");
                    break;
            }
        }
        public static void plus(int num1, int num2)
        {
            Console.WriteLine(num1 + num2 );
        }
        public static void minus(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }
        public static void multiplication(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
        }
        public static void divide(int num1, int num2)
        {
            Console.WriteLine(num1 / num2);
        }
        public static void dividedBy7(int number)
        {
            if (number % 7 == 0)
            {
                Console.WriteLine("divided by 7");
            }
            else
            {
                while (number % 7 != 0)
                {
                    number--;
                }
                Console.WriteLine(number);
            }
        }

    }
}
