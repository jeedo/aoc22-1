using aoc22_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_testing
{
    public class Elf_IsValid
    {
        private Elf _elf = new Elf();
        
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestParse()
        {
            string input = "1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n7\r\n8\r\n9\r\n10\r\n11\r\n12\r\n13\r\n14\r\n15\r\n16\r\n17\r\n18\r\n19\r\n20";
            _elf.parseList(input);
            Assert.That(_elf.GetTotalCalories(), Is.EqualTo(210));
        }
    }
}
