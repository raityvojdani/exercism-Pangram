namespace Pangram;

internal class Program
{
    static void Main(string[] args)
    {
        UserInputHandler userInputHandler = new UserInputHandler();
        PangramCheckerService pangramCheckerService = new PangramCheckerService();

        string input = userInputHandler.GetUserInput();
        bool isPangram = pangramCheckerService.CheckPangram(input, new PangramChecker());

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
