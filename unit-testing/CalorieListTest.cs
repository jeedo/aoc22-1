using aoc22_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_testing
{
    internal class CalorieListTest
    {
        private CalorieList _calorieList = new CalorieList();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestParse()
        {
            string input = "1\r2\r\r3\r";
            _calorieList.parseList(input);
            Assert.That(_calorieList.GetElves().Count, Is.EqualTo(2));
        }

        [Test]
        public void TestLargestElf()
        {
            string input = "1\r2\r\r8\r";
            _calorieList.parseList(input);
            Assert.That(_calorieList.GetLargestElf(), Is.EqualTo(8));
        }
    }
}
