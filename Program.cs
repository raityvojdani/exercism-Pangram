namespace Pangram;

internal class Program
{
    static void Main(string[] args)
    {
        Pangram pangram=new Pangram();

        // درخواست ورودی از کاربر
        Console.WriteLine("Please enter a sentence to check if it's a pangram:");
        string input = Console.ReadLine();

     
        bool isPangram = pangram.IsPangram(input);


        if (isPangram)
        {
            Console.WriteLine("The sentence is a pangram.");
        }
        else
        {
            Console.WriteLine("The sentence is not a pangram.");
        }

    }


}
