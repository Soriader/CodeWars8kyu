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
            public static void RentalCarTest()
            {
                Assert.AreEqual(RentalCarTask.RentalCarCost(1), 40);
                Assert.AreEqual(RentalCarTask.RentalCarCost(3), 100);
                Assert.AreEqual(RentalCarTask.RentalCarCost(7), 230);
            }

            [Test]
            public void RockPaperScissorsTest()
            {
                Assert.AreEqual("Player 1 won!", RockPaperScissorsTask.Rps("rock", "scissors"));
                Assert.AreEqual("Player 1 won!", RockPaperScissorsTask.Rps("scissors", "paper"));
                Assert.AreEqual("Player 1 won!", RockPaperScissorsTask.Rps("paper", "rock"));
                Assert.AreEqual("Player 2 won!", RockPaperScissorsTask.Rps("scissors", "rock"));
                Assert.AreEqual("Player 2 won!", RockPaperScissorsTask.Rps("paper", "scissors"));
                Assert.AreEqual("Player 2 won!", RockPaperScissorsTask.Rps("rock", "paper")); 
                Assert.AreEqual("Draw!", RockPaperScissorsTask.Rps("rock", "rock"));
                Assert.AreEqual("Draw!", RockPaperScissorsTask.Rps("scissors", "scissors"));
                Assert.AreEqual("Draw!", RockPaperScissorsTask.Rps("paper", "paper"));
            }

            [Test]
            public void PaperWorkTest()
            {
                Assert.AreEqual(25, PaperWorkTask.PaperWork(5, 5));
                Assert.AreEqual(0, PaperWorkTask.PaperWork(5, -5));
                Assert.AreEqual(0, PaperWorkTask.PaperWork(-5, -5));
                Assert.AreEqual(0, PaperWorkTask.PaperWork(-5, 5));
                Assert.AreEqual(0, PaperWorkTask.PaperWork(5, 0));
            }

            [Test]
            public void SumArrayTest()
            {
                Assert.AreEqual(9.2, SumArrayTask.SumArray(new double[] { 1, 5.2, 4, 0, -1 }));

                //https://www.codewars.com/kata/53dc54212259ed3d4f00071c/train/csharp
            }

            [Test]
            public void SimpleMultiplicationTest()
            {
                Assert.AreEqual(9, SimpleMultiplicationTask.SimpleMultiplication(1), "Should return given argument times nine");
                Assert.AreEqual(16, SimpleMultiplicationTask.SimpleMultiplication(2), "Should return given argument times eight");
                Assert.AreEqual(64, SimpleMultiplicationTask.SimpleMultiplication(8), "Should return given argument times eight");
                Assert.AreEqual(32, SimpleMultiplicationTask.SimpleMultiplication(4), "Should return given argument times eight");
                Assert.AreEqual(45, SimpleMultiplicationTask.SimpleMultiplication(5), "Should return given argument times nine");
            }

            [Test]
            public void SumMixTest()
            {
                Assert.AreEqual(22, SumMixTask.SumMix(new object[] { 9, 3, "7", "3" }));
                Assert.AreEqual(42, SumMixTask.SumMix(new object[] { "5", "0", 9, 3, 2, 1, "9", 6, 7 }));
                Assert.AreEqual(41, SumMixTask.SumMix(new object[] { "3", 6, 6, 0, "5", 8, 5, "6", 2, "0" }));
            }

            [Test]
            public void RepeatStrTest()
            {
                Assert.AreEqual("***", RepeatStrTask.RepeatStr(3, "*"));
                Assert.AreEqual("#####", RepeatStrTask.RepeatStr(5, "#"));
                Assert.AreEqual("ha ha ", RepeatStrTask.RepeatStr(2, "ha "));
            }

            [Test]
            public void GreetTest()
            {
                Assert.That(GreetTask.Greet("Ryan"), Is.EqualTo("Hello, Ryan how are you doing today?"));
            }

            [Test]
            public void PositiveSumTest()
            {
                Assert.AreEqual(15, PositiveSumTask.PositiveSum(new int[] { 1, 2, 3, 4, 5 }));
                Assert.AreEqual(13, PositiveSumTask.PositiveSum(new int[] { 1, -2, 3, 4, 5 }));
                Assert.AreEqual(9, PositiveSumTask.PositiveSum(new int[] { -1, 2, 3, 4, -5 }));
            }
      
            [Test]
            public void DnaToRnaTest()
            {
                Assert.AreEqual("UUUU", DnaToRnaTask.DnaToRna("TTTT"));
            }

            [Test]
            public void ReversedStringsTest()
            {
                Assert.AreEqual("dlrow", ReversedStringsTask.ReversedStrings("world"));
            }

            [Test]
            public void humanYearsCatYearsDogYearsTest()
            {
                Assert.AreEqual(new int[] { 1, 15, 15 }, HumanYearsCatYearsDogYearsTask.HumanYearsCatYearsDogYears(1));
                Assert.AreEqual(new int[] { 2, 24, 24 }, HumanYearsCatYearsDogYearsTask.HumanYearsCatYearsDogYears(2));
                Assert.AreEqual(new int[] { 10, 56, 64 }, HumanYearsCatYearsDogYearsTask.HumanYearsCatYearsDogYears(10));
            }

            [Test]
            public void OtherAngleTest()
            {
                Assert.That(OtherAngleTask.OtherAngle(30, 60), Is.EqualTo(90));
                Assert.That(OtherAngleTask.OtherAngle(60, 60), Is.EqualTo(60));
                Assert.That(OtherAngleTask.OtherAngle(43, 78), Is.EqualTo(59));
                Assert.That(OtherAngleTask.OtherAngle(10, 20), Is.EqualTo(150));
            }

            [Test]
            public void CorrectTest()
            {
                Assert.AreEqual("LONDON", CorrectTask.Correct("L0ND0N"));
                Assert.AreEqual("DUBLIN", CorrectTask.Correct("DUBL1N"));
                Assert.AreEqual("SINGAPORE", CorrectTask.Correct("51NGAP0RE"));
                Assert.AreEqual("BUDAPEST", CorrectTask.Correct("BUDAPE5T"));
                Assert.AreEqual("PARIS", CorrectTask.Correct("PAR15"));
            }

            [Test]
            public void BoolToWordTest()
            {
                Assert.AreEqual("Yes", BoolToWordTask.BoolToWord(true));
                Console.WriteLine("Expected Yes");
                Assert.AreEqual("Yes", BoolToWordTask.BoolToWord(true));
                Console.WriteLine("Expected Yes");
                Assert.AreEqual("No", BoolToWordTask.BoolToWord(false));
                Console.WriteLine("Expected No");
            }

            [Test]
            public void RemoveEveryOtherTest()
            {
                Assert.AreEqual(new object[] { "Hello", "Hello Again" }, RemoveEveryOtherTask.RemoveEveryOther(new object[] { "Hello", "Goodbye", "Hello Again" }));
                Assert.AreEqual(new object[] { new object[] { 1, 2 } }, RemoveEveryOtherTask.RemoveEveryOther(new object[] { new object[] { 1, 2 } }));
                Assert.AreEqual(new object[] { 1, 3, 5, 7, 9 }, RemoveEveryOtherTask.RemoveEveryOther(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
                Assert.AreEqual(new object[] { new object[] { "Goodbye" } }, RemoveEveryOtherTask.RemoveEveryOther(new object[] { new object[] { "Goodbye" }, new Dictionary<string, string>() { { "Great", "Job" } } }));
                Assert.AreEqual(new object[] { }, RemoveEveryOtherTask.RemoveEveryOther(new object[] { }));
            }

            [Test]
            public void RemoveCharTest()
            {
                StringAssert.AreEqualIgnoringCase("loquen", RemoveCharTask.RemoveChar("eloquent"));
                StringAssert.AreEqualIgnoringCase("ountr", RemoveCharTask.RemoveChar("country"));
                StringAssert.AreEqualIgnoringCase("erso", RemoveCharTask.RemoveChar("person"));
                StringAssert.AreEqualIgnoringCase("lac", RemoveCharTask.RemoveChar("place"));
                StringAssert.AreEqualIgnoringCase("", RemoveCharTask.RemoveChar("ok"));
            }

            [Test]
            public void AreaOrPerimeterTest()
            {
                Assert.AreEqual(AreaOrPerimeterTask.AreaOrPerimeter(4, 4), 16);
                Assert.AreEqual(AreaOrPerimeterTask.AreaOrPerimeter(6, 10), 32);
            }

            [Test]
            public void SmashTest()
            {
                Assert.AreEqual("hello", SmashTask.Smash(new string[] { "hello" }));
                Assert.AreEqual("hello world", SmashTask.Smash(new string[] { "hello", "world" }));
                Assert.AreEqual("hello amazing world", SmashTask.Smash(new string[] { "hello", "amazing", "world" }));
                Assert.AreEqual("this is a really long sentence", SmashTask.Smash(new string[] { "this", "is", "a", "really", "long", "sentence" }));
                Assert.AreEqual("", SmashTask.Smash(new string[] { "" }));
            }

            [Test]
            public void HelloWorldTest()
            {
                Assert.AreEqual("hello world!", HelloWordTask.HelloWord());
            }

            [Test]
            public void MultiplyTest()
            {
                Assert.That(2 == MultiplyTask.Multiply(2, 1));
                Assert.That(8 == MultiplyTask.Multiply(2, 4));
            }

            [Test]
            public void MakeNegativeTest()
            {
                Assert.That(-42 == MakeNegativeTask.MakeNegative(42));
            }

        }

    }
}