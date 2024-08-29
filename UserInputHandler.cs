using System;

namespace Pangram
{
    public class UserInputHandler
    {
        public string GetUserInput()
        {
            Console.WriteLine("Please enter a sentence:");
            return Console.ReadLine();
        }
    }
}
