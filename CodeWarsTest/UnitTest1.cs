using CodeWars8kyu;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using static CodeWars8kyu.ConvertAStringToAnArrayTask;

namespace CodeWarsTest
{
    public class Tests
    {

        [TestFixture]
        public class KataTest
        {
            [Test]
            public void IsItEvenTest()
            {
                Assert.AreEqual(true, IsItEvenTask.IsEven(0));
                Assert.AreEqual(false, IsItEvenTask.IsEven(0.5));
                Assert.AreEqual(false, IsItEvenTask.IsEven(1));
                Assert.AreEqual(true, IsItEvenTask.IsEven(2));
                Assert.AreEqual(true, IsItEvenTask.IsEven(-4));
            }

            [Test]
            public void SwitchItUpTest()
            {
                Assert.AreEqual("One", SwitchItUpTask.SwitchItUp(1));
                Assert.AreEqual("Three", SwitchItUpTask.SwitchItUp(3));
                Assert.AreEqual("Five", SwitchItUpTask.SwitchItUp(5));
            }

            [Test]
            public void MaximuAndMinimumValuesTest()
            {
                Assert.AreEqual(-110, new MaximuAndMinimumValuesTask().Min(new[] { -52, 56, 30, 29, -54, 0, -110 }));
                Assert.AreEqual(0, new MaximuAndMinimumValuesTask().Min(new[] { 42, 54, 65, 87, 0 }));
                Assert.AreEqual(566, new MaximuAndMinimumValuesTask().Max(new[] { 4, 6, 2, 1, 9, 63, -134, 566 }));
                Assert.AreEqual(5, new MaximuAndMinimumValuesTask().Max(new[] { 5 }));
            }

            [Test]
            public void TotalPointsTask() 
            {
                Assert.AreEqual(12, TotalPointsTest.TotalPoints(new[] { "1:0", "2:0", "3:0", "4:4", "2:2", "3:3", "1:4", "2:3", "2:4", "3:4" }));
                Assert.AreEqual(15, TotalPointsTest.TotalPoints(new[] { "1:0", "2:0", "3:0", "4:0", "2:1", "1:3", "1:4", "2:3", "2:4", "3:4" }));
                Assert.AreEqual(0, TotalPointsTest.TotalPoints(new[] { "0:1", "0:2", "0:3", "0:4", "1:2", "1:3", "1:4", "2:3", "2:4", "3:4" }));
                Assert.AreEqual(10, TotalPointsTest.TotalPoints(new[] { "1:1", "2:2", "3:3", "4:4", "2:2", "3:3", "4:4", "3:3", "4:4", "4:4" }));
            }

            [Test]
            public void ConvertAStringToAnArrayTest()
            {
                Assert.AreEqual(new string[] { "Robin", "Singh" }, ConvertAStringToAnArrayTask.StringToArray("Robin Singh"));
                Assert.AreEqual(new string[] { "I", "love", "arrays", "they", "are", "my", "favorite" }, ConvertAStringToAnArrayTask.StringToArray("I love arrays they are my favorite"));
            }

            [Test]
            public void DoubleCharTest()
            {
                Assert.AreEqual("aabbccdd", DoubleCharTask.DoubleChar("abcd"));
                Assert.AreEqual("AAddiiddaass", DoubleCharTask.DoubleChar("Adidas"));
                Assert.AreEqual("11333377", DoubleCharTask.DoubleChar("1337"));
                Assert.AreEqual("iilllluummiinnaattii", DoubleCharTask.DoubleChar("illuminati"));
            }


                [Test]
            public void YouOnlyNeedOneTest()
            {
                Assert.AreEqual(true, YouOnlyNeedOneTask.Check(new object[] { 66, 101 }, 66));
                Assert.AreEqual(true, YouOnlyNeedOneTask.Check(new object[] { 80, 117, 115, 104, 45, 85, 112, 115 }, 45));
                Assert.AreEqual(true, YouOnlyNeedOneTask.Check(new object[] { 't', 'e', 's', 't' }, 'e'));
                Assert.AreEqual(false, YouOnlyNeedOneTask.Check(new object[] { "what", "a", "great", "kata" }, "kat"));
            }

            [Test]
            public static void GrasshopperSummationTest()
            {
                Assert.AreEqual(1, GrasshopperSummationTask.Summation(1));
                Assert.AreEqual(36, GrasshopperSummationTask.Summation(8));
                Assert.AreEqual(253, GrasshopperSummationTask.Summation(22));
                Assert.AreEqual(5050, GrasshopperSummationTask.Summation(100));
                Assert.AreEqual(22791, GrasshopperSummationTask.Summation(213));
            }

            [Test]
            public void ZeroFuelTest()
            {
                Assert.AreEqual(true, ZeroFuelTask.ZeroFuel(50, 25, 2));
                Assert.AreEqual(false, ZeroFuelTask.ZeroFuel(100, 50, 1));
            }
            [Test]
            public void CountSheepsTest()
            {
                var sheeps = new bool[] { true, false, true };

                Assert.AreEqual(2, CountSheepsTask.CountSheeps(sheeps));
            }

            [Test]
            public void GrowTest()
            {
                Assert.AreEqual(6, GrowTask.Grow(new[] { 1, 2, 3 }));
                Assert.AreEqual(16, GrowTask.Grow(new[] { 4, 1, 1, 1, 4 }));
                Assert.AreEqual(64, GrowTask.Grow(new[] { 2, 2, 2, 2, 2, 2 }));
            }

            [Test]
            public void AbbrevNameTest()
            {
                Assert.AreEqual("S.H", AbbrevNameTask.AbbrevName("Sam Harris"));
                Assert.AreEqual("P.F", AbbrevNameTask.AbbrevName("Patrick Feenan"));
                Assert.AreEqual("E.C", AbbrevNameTask.AbbrevName("Evan Cole"));
                Assert.AreEqual("P.F", AbbrevNameTask.AbbrevName("P Favuzzi"));
                Assert.AreEqual("D.M", AbbrevNameTask.AbbrevName("David Mendieta"));
            }

            [Test]
            public void BetterThanAverageTest()
            {
                Assert.AreEqual(true, BetterThanAverageTask.BetterThanAverage(new int[] { 2, 3 }, 5));
                Assert.AreEqual(true, BetterThanAverageTask.BetterThanAverage(new int[] { 100, 40, 34, 57, 29, 72, 57, 88 }, 75));
                Assert.AreEqual(true, BetterThanAverageTask.BetterThanAverage(new int[] { 12, 23, 34, 45, 56, 67, 78, 89, 90 }, 69));
            }

            [Test]
            public void ClockTest()
            {
                Assert.AreEqual(61000, ClockTask.Past(0, 1, 1));
            }

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