using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheUltimateDataStructureAndAlgorithm
{
    public class CharFinder
    {
        public char GetFirstNonRepetitiveChar(string input)
        {
            var dic = new Dictionary<char, int>();
            foreach (char c in input)
            {
                int count = dic.ContainsKey(c) ? dic[c] : 0;
                dic[c] = count + 1;
            }

            foreach (char c in input)
            {
               if(dic[c] == 1) return c;
            }
            return Char.MinValue;
        }

        public char GetFirstRepetitiveChar(string input)
        {
            var set = new HashSet<char>();
            foreach (char c in input)
            {
                if(set.Contains(c)) return c;
                set.Add(c);
            }    
            return Char.MinValue;
        }
    }
}
