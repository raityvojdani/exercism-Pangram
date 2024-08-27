using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangram;
public class Pangram
{
   public bool IsPangram(string sentence)
    {
        bool[] alphabet = new bool[26];
        string str = sentence.ToLower();


        foreach (char letter in str)
        {

            if (letter >= 'a' && letter <= 'z')
            {
                int index = letter - 'a'; // محاسبه ایندکس بر اساس حرف
                alphabet[index] = true;
            }
        }

        foreach (bool seen in alphabet)
        {
            if (!seen)
            {
                return false;
            }
        }

        return true;

    }
}
