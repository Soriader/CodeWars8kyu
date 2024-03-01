using CodeWars8kyu;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;

namespace CodeWarsTest
{
    public class Tests
    {

        [TestFixture]
        public class KataTest
        {

            [Test]
            public void SumMixTest()
            {
                Assert.AreEqual(22, Kata.SumMix(new object[] { 9, 3, "7", "3" }));
                Assert.AreEqual(42, Kata.SumMix(new object[] { "5", "0", 9, 3, 2, 1, "9", 6, 7 }));
                Assert.AreEqual(41, Kata.SumMix(new object[] { "3", 6, 6, 0, "5", 8, 5, "6", 2, "0" }));
            }

            [Test]
            public void RepeatStrTest()
            {
                Assert.AreEqual("***", Kata.RepeatStr(3, "*"));
                Assert.AreEqual("#####", Kata.RepeatStr(5, "#"));
                Assert.AreEqual("ha ha ", Kata.RepeatStr(2, "ha "));
            }

            [Test]
            public void GreetTest()
            {
                Assert.That(Kata.Greet("Ryan"), Is.EqualTo("Hello, Ryan how are you doing today?"));
            }

            [Test]
            public void PositiveSumTest()
            {
                Assert.AreEqual(15, Kata.PositiveSum(new int[] { 1, 2, 3, 4, 5 }));
                Assert.AreEqual(13, Kata.PositiveSum(new int[] { 1, -2, 3, 4, 5 }));
                Assert.AreEqual(9, Kata.PositiveSum(new int[] { -1, 2, 3, 4, -5 }));
            }
      
            [Test]
            public void DnaToRnaTest()
            {
                Assert.AreEqual("UUUU", Kata.DnaToRna("TTTT"));
            }

            [Test]
            public void ReversedStringsTest()
            {
                Assert.AreEqual("dlrow", Kata.ReversedStrings("world"));
            }

            [Test]
            public void humanYearsCatYearsDogYearsTest()
            {
                Assert.AreEqual(new int[] { 1, 15, 15 }, Kata.HumanYearsCatYearsDogYears(1));
                Assert.AreEqual(new int[] { 2, 24, 24 }, Kata.HumanYearsCatYearsDogYears(2));
                Assert.AreEqual(new int[] { 10, 56, 64 }, Kata.HumanYearsCatYearsDogYears(10));
            }

            [Test]
            public void OtherAngleTest()
            {
                Assert.That(Kata.OtherAngle(30, 60), Is.EqualTo(90));
                Assert.That(Kata.OtherAngle(60, 60), Is.EqualTo(60));
                Assert.That(Kata.OtherAngle(43, 78), Is.EqualTo(59));
                Assert.That(Kata.OtherAngle(10, 20), Is.EqualTo(150));
            }

            [Test]
            public void CorrectTest()
            {
                Assert.AreEqual("LONDON", Kata.Correct("L0ND0N"));
                Assert.AreEqual("DUBLIN", Kata.Correct("DUBL1N"));
                Assert.AreEqual("SINGAPORE", Kata.Correct("51NGAP0RE"));
                Assert.AreEqual("BUDAPEST", Kata.Correct("BUDAPE5T"));
                Assert.AreEqual("PARIS", Kata.Correct("PAR15"));
            }

            [Test]
            public void BoolToWordTest()
            {
                Assert.AreEqual("Yes", Kata.BoolToWord(true));
                Console.WriteLine("Expected Yes");
                Assert.AreEqual("Yes", Kata.BoolToWord(true));
                Console.WriteLine("Expected Yes");
                Assert.AreEqual("No", Kata.BoolToWord(false));
                Console.WriteLine("Expected No");
            }

            [Test]
            public void RemoveEveryOtherTest()
            {
                Assert.AreEqual(new object[] { "Hello", "Hello Again" }, Kata.RemoveEveryOther(new object[] { "Hello", "Goodbye", "Hello Again" }));
                Assert.AreEqual(new object[] { new object[] { 1, 2 } }, Kata.RemoveEveryOther(new object[] { new object[] { 1, 2 } }));
                Assert.AreEqual(new object[] { 1, 3, 5, 7, 9 }, Kata.RemoveEveryOther(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
                Assert.AreEqual(new object[] { new object[] { "Goodbye" } }, Kata.RemoveEveryOther(new object[] { new object[] { "Goodbye" }, new Dictionary<string, string>() { { "Great", "Job" } } }));
                Assert.AreEqual(new object[] { }, Kata.RemoveEveryOther(new object[] { }));
            }

            [Test]
            public void Remove_charTest()
            {
                StringAssert.AreEqualIgnoringCase("loquen", Kata.Remove_char("eloquent"));
                StringAssert.AreEqualIgnoringCase("ountr", Kata.Remove_char("country"));
                StringAssert.AreEqualIgnoringCase("erso", Kata.Remove_char("person"));
                StringAssert.AreEqualIgnoringCase("lac", Kata.Remove_char("place"));
                StringAssert.AreEqualIgnoringCase("", Kata.Remove_char("ok"));
            }

            [Test]
            public void AreaOrPerimeterTest()
            {
                Assert.AreEqual(Kata.AreaOrPerimeter(4, 4), 16);
                Assert.AreEqual(Kata.AreaOrPerimeter(6, 10), 32);
            }

            [Test]
            public void SmashTest()
            {
                Assert.AreEqual("hello", Kata.Smash(new string[] { "hello" }));
                Assert.AreEqual("hello world", Kata.Smash(new string[] { "hello", "world" }));
                Assert.AreEqual("hello amazing world", Kata.Smash(new string[] { "hello", "amazing", "world" }));
                Assert.AreEqual("this is a really long sentence", Kata.Smash(new string[] { "this", "is", "a", "really", "long", "sentence" }));
                Assert.AreEqual("", Kata.Smash(new string[] { "" }));
            }

            [Test]
            public void HelloWorldTest()
            {
                Assert.AreEqual("hello world!", Kata.HelloWord());
            }

            [Test]
            public void MultiplyTest()
            {
                Assert.That(2 == Kata.Multiply(2, 1));
                Assert.That(8 == Kata.Multiply(2, 4));
            }

            [Test]
            public void MakeNegativeTest()
            {
                Assert.That(-42 == Kata.MakeNegative(42));
            }

        }

    }
}