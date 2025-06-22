using System;

namespace SingletonPatternExample
{
    public class Logger
    {
        private static Logger instance;
        private static readonly object lockObj = new object(); // lock object

        private Logger()
        {
            Console.WriteLine("Logger initialized...");
        }

        public static Logger GetInstance()
        {
            // Double-check locking
            if (instance == null)
            {
                lock (lockObj)
                {
                    if (instance == null)
                    {
                        instance = new Logger();
                    }
                }
            }
            return instance;
        }

        public void Log(string message)
        {
            Console.WriteLine("Log: " + message);
        }
    }
}
