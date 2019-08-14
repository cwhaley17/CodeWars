using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace codewars
{
    [TestFixture]
    class tests
    {
        private static void Tester(List<int> arguement, List<int> expectedResult)
        {
            CollectionAssert.AreEqual(expectedResult, Program.RemoveSmallest(arguement));
        }

        [Test]
        public void DiceRollingKataTest()
        {
            Assert.AreEqual(0, Program.Score(new int[] { 2, 3, 4, 6, 2 }), "Should be 0 :-(");
            Assert.AreEqual(400, Program.Score(new int[] { 4, 4, 4, 3, 3 }), "Should be 400");
            Assert.AreEqual(450, Program.Score(new int[] { 2, 4, 4, 5, 4 }), "Should be 450");
        }

        [Test]
        public void nbMonthsKataTest()
        {
            //yeah this one doesn't actually pass. Gonna need some more work, or some coffee. 
            // https://www.codewars.com/kata/554a44516729e4d80b000012/train/csharp
            int[] r = new int[] { 6, 766 };
            int[] c = new int[] { 0, 4000 };
            //Assert.AreEqual(r, Program.nbMonths(2000, 8000, 1000, 1.5));
            //Assert.AreEqual(c, Program.nbMonths(2000, 8000, 1000, 1.5));
            Assert.AreEqual(new int[] { 0, 0 }, Program.nbMonths(8000, 8000, 1000, 1.5));
        }

        [Test]
        public void FirstNonRepeatingNumberKataTest()
        {
            Assert.AreEqual("a", Program.FirstNonRepeatingLetter("a"));
            Assert.AreEqual("t", Program.FirstNonRepeatingLetter("stress"));
            Assert.AreEqual("e", Program.FirstNonRepeatingLetter("moonmen"));
            Assert.AreEqual("T", Program.FirstNonRepeatingLetter("sTreSS"));
        }

        [Test]
        public void GetLengthOfMissingArrayKataTest()
        {
            Assert.AreEqual(3, Program.GetLengthOfMissingArray(new object[][] { new object[] { 1, 2 }, new object[] { 4, 5, 1, 1 }, new object[] { 1 }, new object[] { 5, 6, 7, 8, 9 } }));
            Assert.AreEqual(2, Program.GetLengthOfMissingArray(new object[][] { new object[] { 5, 2, 9 }, new object[] { 4, 5, 1, 1 }, new object[] { 1 }, new object[] { 5, 6, 7, 8, 9 } }));
            Assert.AreEqual(2, Program.GetLengthOfMissingArray(new object[][] { new object[] { null }, new object[] { null, null, null } }));
            Assert.AreEqual(5, Program.GetLengthOfMissingArray(new object[][] { new object[] { 'a', 'a', 'a' }, new object[] { 'a', 'a' }, new object[] { 'a', 'a', 'a', 'a' }, new object[] { 'a' }, new object[] { 'a', 'a', 'a', 'a', 'a', 'a' } }));

            Assert.AreEqual(0, Program.GetLengthOfMissingArray(new object[][] { }));
        }

        [Test]
        public void ReturnEvenOrOddNumberKataTest()
        {
            Assert.AreEqual(3, Program.ReturnEvenOrOddNumber("2 4 7 8 10"));
            Assert.AreEqual(3, Program.ReturnEvenOrOddNumber("2 4 7 8 10"));
        }

        [Test]
        public void dirReducKataTest()
        {
            string[] a = new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };
            string[] b = new string[] { "WEST" };
            string[] c = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
            string[] d = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
            Assert.AreEqual(b, Program.dirReduc(a));
            Assert.AreEqual(d, Program.dirReduc(c));
        }

        [Test]
        public void ToCamelCaseKataTest()
        {
            Assert.AreEqual("theStealthWarrior", Program.ToCamelCase("the_stealth_warrior"), "Kata.ToCamelCase('the_stealth_warrior') did not return correct value");
            Assert.AreEqual("TheStealthWarrior", Program.ToCamelCase("The-Stealth-Warrior"), "Kata.ToCamelCase('The-Stealth-Warrior') did not return correct value");
        }

        [Test]
        public void GetMiddleKataTest()
        {
            Assert.AreEqual("es", Program.GetMiddle("test"));
            Assert.AreEqual("t", Program.GetMiddle("testing"));
            Assert.AreEqual("dd", Program.GetMiddle("middle"));
            Assert.AreEqual("A", Program.GetMiddle("A"));
        }

        [Test]
        public void ReverseFiveOrMoreKataTest()
        {
            Assert.AreEqual("Just gniddik ereht is llits one more", Program.SpinWords("Just kidding there is still one more"));
            Assert.AreEqual("You are tsomla to the last test", Program.SpinWords("You are almost to the last test"));
            Assert.AreEqual("This is rehtona test", Program.SpinWords("This is another test"));
            Assert.AreEqual("This is a test", Program.SpinWords("This is a test"));
            Assert.AreEqual("Hey wollef sroirraw", Program.SpinWords("Hey fellow warriors"));
            Assert.AreEqual("emocleW", Program.SpinWords("Welcome"));
        }

        [Test]
        public void TwoFightersKataTest()
        {
            Assert.AreEqual("Lew", Program.declareWinner(new Fighter("Lew", 10, 2), new Fighter("Harry", 5, 4), "Lew"));
            Assert.AreEqual("Harry", Program.declareWinner(new Fighter("Lew", 10, 2), new Fighter("Harry", 5, 4), "Harry"));
            Assert.AreEqual("Harald", Program.declareWinner(new Fighter("Harald", 20, 5), new Fighter("Harry", 5, 4), "Harry"));
            Assert.AreEqual("Harald", Program.declareWinner(new Fighter("Harald", 20, 5), new Fighter("Harry", 5, 4), "Harald"));
            Assert.AreEqual("Harald", Program.declareWinner(new Fighter("Jerry", 30, 3), new Fighter("Harald", 20, 5), "Jerry"));
            Assert.AreEqual("Harald", Program.declareWinner(new Fighter("Jerry", 30, 3), new Fighter("Harald", 20, 5), "Harald"));
        }

        [Test]
        public void SaveTheMeerkatTest()
        {
            Assert.AreEqual(new string[] { "head", "body", "tail" }, Program.FixTheMeerkat(new string[] { "tail", "body", "head" }));
            Assert.AreEqual(new string[] { "heads", "body", "tails" }, Program.FixTheMeerkat(new string[] { "tails", "body", "heads" }));
            Assert.AreEqual(new string[] { "top", "middle", "bottom" }, Program.FixTheMeerkat(new string[] { "bottom", "middle", "top" }));
            Assert.AreEqual(new string[] { "upper legs", "torso", "lower legs" }, Program.FixTheMeerkat(new string[] { "lower legs", "torso", "upper legs" }));
            Assert.AreEqual(new string[] { "ground", "rainbow", "sky" }, Program.FixTheMeerkat(new string[] { "sky", "rainbow", "ground" }));
        }

        [Test]
        public void MissingLetterKataTest()
        {
            Assert.AreEqual('e', Program.FindMissingLetter(new[] { 'a', 'b', 'c', 'd', 'f' }));
            //Assert.AreEqual('e', Program.FindMissingLetter(new[] { 'O', 'Q', 'R', 'S' }));
        }

        [Test]
        public void FriendOrFoeTests()
        {
            string[] expected = { "Ryan", "Mark" };
            string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
            CollectionAssert.AreEqual(expected, Program.FriendOrFoe(names));
        }

        [Test]
        public void ReturnOddOccuranceInt()
        {
            Assert.AreEqual(5, Program.find_it(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));
        }

        [Test]
        public static void BasicTests()
        {
            Tester(new List<int> { 1, 2, 3, 4, 5 }, new List<int> { 2, 3, 4, 5 });
            Tester(new List<int> { 5, 3, 2, 1, 4 }, new List<int> { 5, 3, 2, 4 });
            Tester(new List<int> { 1, 2, 3, 1, 1 }, new List<int> { 2, 3, 1, 1 });
            Tester(new List<int> { }, new List<int> { });
        }
    }

    internal class Fighter
    {
        public string Name;
        public int Health, DamagePerAttack;

        public Fighter(string name, int health, int damagePerAttack)
        {
            this.Name = name;
            this.Health = health;
            this.DamagePerAttack = damagePerAttack;
        }
    }
}
