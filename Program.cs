using System;


namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Adam";
            char lastInitial = 'C';
            int age = 35;
            bool isMarried = false;
            float height = 1.8f;
            decimal savingsAccount = 2357.78m;

            Console.Write($"I have a friend, his name is {firstName} {lastInitial}.\n" +
                          $"He is {age} years old and is ");

            if (isMarried) Console.Write("married.\n"); else Console.Write("not married.\n");

            Console.WriteLine($"{firstName} is {height}m tall, " +
                              $"and he has ${savingsAccount} in his savings account");
            Console.ReadKey();
        }
    }
}