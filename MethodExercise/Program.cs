using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercise
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string userColor = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string userAnimal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            string userBand = Console.ReadLine();

            Console.WriteLine($"{userName} woke up this morning and was greeted by their {userAnimal}.");
            Console.WriteLine($"{userName}s {userAnimal} was very hungry. {userName} put on their favorite {userColor} shirt and went downstairs.");
            Console.WriteLine($"After their animal was fed, {userName} got into their car and put on some {userBand}!");

            Console.WriteLine("Give me numbers to add. start with the first number!");
            int num1 =int.Parse (Console.ReadLine());

            Console.WriteLine("Give me a second number!");
            int num2 = int.Parse (Console.ReadLine());

            int sum = Addition(num1, num2);
            Console.WriteLine($"The sum is {sum}."); //addition





            Console.WriteLine("Give me two numbers to subtract. Give me the first number.");
            int numb1=int.Parse (Console.ReadLine());

            Console.WriteLine("Give me the second number!");
            int numb2 = int.Parse (Console.ReadLine());

            int subAnswer = Subtract(numb1, numb2);
            Console.WriteLine($"The subtraction answer is {subAnswer}!"); //subtraction

            Console.WriteLine("Give me the a number to multiply.");
            int mul1 = int.Parse (Console.ReadLine());

            Console.WriteLine("Give me one more number to multiply.");
            int mul2 = int.Parse (Console.ReadLine());

            int mulAnswer = multiply(mul1, mul2);
            Console.WriteLine($"The multiplication answer is, {mulAnswer}."); //multiplication

            Console.WriteLine("Give me a number to divide.");
            int div1 = int.Parse (Console.ReadLine());

            Console.WriteLine("Give me one more number to divide/");
            int div2 = int.Parse (Console.ReadLine());

            int divAnswer = divide(div1, div2);
            Console.WriteLine($"Your division answer is, {divAnswer}!"); //division

            Console.WriteLine("Give me a number for a modulus math problem.");
            int mod1 = int.Parse (Console.ReadLine());

            Console.WriteLine("Give me one more number.");
            int mod2 = int.Parse (Console.ReadLine());

            int modAnswer = modulus(mod1, mod2);
            Console.WriteLine($"Your answer is, {modAnswer}!"); //modulus
        }
        public static int Addition(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtract(int numb1, int numb2)
        {
            return (numb1 - numb2);
        }

        public static int multiply(int mul1, int mul2)
        {
            return mul1 * mul2;
        }

        public static int divide(int div1, int div2)
        {
            return div1 / div2;
        }

        public static int modulus(int mod1, int mod2)
        {
            return mod1 % mod2;
        }
    }
}
