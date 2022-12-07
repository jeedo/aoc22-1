namespace aoc22_1
{
    public class Elf
    {
        private List<int> _calories = new List<int>();

        public Elf()
        {
        }
        public Elf(string input)
        {
            //Parse input into a list of calories
            parseList(input);
        }

        public void parseList(string input)
        {
            //Parse input into a list of calories
            string[] split = input.Split(
                new string[] { "\r\n", "\n", "\r" },
                StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in split)
            {
                _calories.Add(int.Parse(s));
            }
        }
        public int GetTotalCalories()
        {
            int total = 0;
            foreach (int i in _calories)
            {
                total += i;
            }
            return total;
        }

    }
}