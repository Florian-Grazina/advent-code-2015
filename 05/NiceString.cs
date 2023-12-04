using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    internal class NiceString
    {
        public int NumberOfNiceStrings { get; private set; }


        public void CheckString(string str)
        {
            if (!CheckPairs(str))
                return;
            if (!CheckRepeat(str))
                return;

            Console.WriteLine(str + " is nice");
            NumberOfNiceStrings++;
        }

        
        private bool CheckPairs(string str)
        {
            for (int i = 0; i < str.Length - 1; i++)
            {
                string pairToCheck = $"{str[i]}{str[i+1]}";

                for(int j = i + 2; j < str.Length - 1; j++)
                {
                    string pair = $"{str[j]}{str[j+1]}";
                    if (pairToCheck == pair)
                        return true ;
                }
            }
            return false;
        }

        private bool CheckRepeat(string str)
        {
            for (int i = 0; i < str.Length - 2; i++)
            {
                if (str[i] == str[i + 2])
                    return true;
            }
            return false;
        }
    }
}
