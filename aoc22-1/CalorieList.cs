using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aoc22_1
{
    public class CalorieList
    {
        private List<Elf> _elves = new List<Elf>();
        
        //Parse elf list into a list of elves
        public void parseList(string input)
        {
            //loop through each line and split on blank lines
            string[] split = input.Split(
                new string[] { "\r\n", "\n", "\r" },
                StringSplitOptions.None);
            string ElfString = "";
            foreach (string s in split)
            {
                if (s != "")
                {
                    ElfString += s + "\r\n";
                }
                else
                {
                    _elves.Add(new Elf(ElfString));
                    ElfString = "";
                }
            }
            if (ElfString != "")
            {
                _elves.Add(new Elf(ElfString));
            }

        }

        public List<Elf> GetElves()
        {
            return _elves;
        }

        public int GetLargestElf()
        {
            return _elves.Max(e => e.GetTotalCalories());
        }
    }
}
