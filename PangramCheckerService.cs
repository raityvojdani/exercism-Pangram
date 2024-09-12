namespace Pangram
{
    public class PangramCheckerService
    {
        public bool CheckPangram(string sentence, IPangramChecker pangramChecker)
        {
            return pangramChecker.IsPangram(sentence);
        }
    }
}
