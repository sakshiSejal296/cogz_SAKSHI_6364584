using System;

namespace SingletonPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the first instance of Logger
            Logger logger1 = Logger.GetInstance();
            logger1.Log("This is the first log message.");

            // Get the second instance of Logger
            Logger logger2 = Logger.GetInstance();
            logger2.Log("This is the second log message.");

            // Check if both instances are the same
            if (logger1 == logger2)
            {
                Console.WriteLine("Both logger1 and logger2 refer to the same instance.");
            }
            else
            {
                Console.WriteLine("Different logger instances detected.");
            }

            Console.ReadLine(); // Keeps the console open
        }
    }
}
