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
            class Test
            {
                [Test]
                public void SumTheStringsTest()
                {
                    Assert.AreEqual("9", SumTheStringsTask.StringsSum("4", "5"));
                    Assert.AreEqual("39", SumTheStringsTask.StringsSum("34", "5"));
                    Assert.AreEqual("9", SumTheStringsTask.StringsSum("", "9"));
                    Assert.AreEqual("9", SumTheStringsTask.StringsSum("9", ""));
                    Assert.AreEqual("0", SumTheStringsTask.StringsSum("", ""));
                }


                [Test]
                public void FindThePositionTest()
                {
                    Assert.AreEqual("Position of alphabet: 1", FindThePositionTask.Position('a'));
                    Assert.AreEqual("Position of alphabet: 26", FindThePositionTask.Position('z'));
                    Assert.AreEqual("Position of alphabet: 5", FindThePositionTask.Position('e'));
                }

                [Test]
                public void SetAlarmTest()
                {
                    Assert.AreEqual(false, SetAlarmTask.SetAlarm(true, true));
                    Assert.AreEqual(false, SetAlarmTask.SetAlarm(false, true));
                    Assert.AreEqual(true, SetAlarmTask.SetAlarm(true, false));
                    Assert.AreEqual(false, SetAlarmTask.SetAlarm(false, false));
                }

                [Test]
                public void IsHeGonnaSurviveTest() 
                { 
                    Assert.AreEqual(false, IsHeGonnaSurviveTask.Hero(0,1));
                    Assert.AreEqual(true, IsHeGonnaSurviveTask.Hero(100,40));
                    Assert.AreEqual(false, IsHeGonnaSurviveTask.Hero(5,10));
                    Assert.AreEqual(true, IsHeGonnaSurviveTask.Hero(10,5));
                }

                [Test]
                public void LarioAndMuigiTest()
                {
                    Assert.AreEqual(new List<int> { 2 }, LarioAndMuigiTask.PipeFix(new List<int> { 2 }));
                    Assert.AreEqual(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, LarioAndMuigiTask.PipeFix(new List<int> { 1, 2, 3, 5, 6, 8, 9 }));
                    Assert.AreEqual(new List<int> { -1, 0, 1, 2, 3, 4 }, LarioAndMuigiTask.PipeFix(new List<int> { -1, 4 }));
                    Assert.AreEqual(new List<int> { 6, 7, 8, 9 }, LarioAndMuigiTask.PipeFix(new List<int> { 6, 9 }));
                    Assert.AreEqual(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, LarioAndMuigiTask.PipeFix(new List<int> { 1, 2, 3, 12 }));
                }

                [Test]
                public void DrinkAboutTest()
                {
                    Assert.AreEqual("drink whisky", DrinkAboutTask.PeopleWithAgeDrink(22));
                    Assert.AreEqual("drink toddy", DrinkAboutTask.PeopleWithAgeDrink(12));
                    Assert.AreEqual("drink coke", DrinkAboutTask.PeopleWithAgeDrink(15));
                    Assert.AreEqual("drink beer", DrinkAboutTask.PeopleWithAgeDrink(20));
                    Assert.AreEqual("drink whisky", DrinkAboutTask.PeopleWithAgeDrink(28));

                }
                [Test]
                public static void CountByXTest()
                {
                    Assert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, CountByXTask.CountBy(1, 5));
                    Assert.AreEqual(new int[] { 2, 4, 6, 8, 10 }, CountByXTask.CountBy(2, 5));
                }


                [Test]
                public void ExclusiveXorLogicalOperatorTest()
                {
                    Assert.AreEqual(false, ExclusiveXorLogicalOperatorTask.Xor(false, false));
                    Assert.AreEqual(true, ExclusiveXorLogicalOperatorTask.Xor(true, false));
                    Assert.AreEqual(true, ExclusiveXorLogicalOperatorTask.Xor(false, true));
                    Assert.AreEqual(false, ExclusiveXorLogicalOperatorTask.Xor(true, true));

                }

                [Test]
                public void TwiceAsOldTest()
                {
                    Assert.AreEqual(30, TwiceAsOldTask.TwiceAsOld(30, 0));
                    Assert.AreEqual(16, TwiceAsOldTask.TwiceAsOld(30, 7));
                    Assert.AreEqual(15, TwiceAsOldTask.TwiceAsOld(45, 30));
                }

                [Test]
                public void ExpressionsMatterTest()
                {
                    Assert.AreEqual(18, ExpressionsMatterTask.ExpressionsMatter(6, 2, 1));
                    Assert.AreEqual(100, ExpressionsMatterTask.ExpressionsMatter(5, 4, 5));
                }


                [Test]
                public void DebugSayHelloTest()
                {
                    Assert.AreEqual("Hello, Mr. Spock", DebugSayHelloTask.SayHello("Mr. Spock"));
                    Assert.AreEqual("Hello, Captain Kirk", DebugSayHelloTask.SayHello("Captain Kirk"));
                    Assert.AreEqual("Hello, Liutenant Uhura", DebugSayHelloTask.SayHello("Liutenant Uhura"));

                }

                [Test]
                public void SuperDuperEasyTest()
                {
                    Assert.AreEqual("Error", SuperDuperEasyTask.Problem("hello"));
                    Assert.AreEqual("56", SuperDuperEasyTask.Problem("1"));
                    Assert.AreEqual("256", SuperDuperEasyTask.Problem("5"));
                    Assert.AreEqual("6", SuperDuperEasyTask.Problem("0"));
                }

                [Test]
                public void ParseIntToCharTest()
                {
                    Assert.AreEqual(3, ParseIntToCharTask.GetAge("3 years old"));
                    Assert.AreEqual(4, ParseIntToCharTask.GetAge("4 years old"));
                    Assert.AreEqual(9, ParseIntToCharTask.GetAge("9 years old"));
                }

                [Test]
                public void WelcomeMethodTest()
                {
                    Assert.AreEqual("Welcome", WelcomeMethodTask.Greet("english"));
                    Assert.AreEqual("Welkom", WelcomeMethodTask.Greet("dutch"));
                    Assert.AreEqual("Welcome", WelcomeMethodTask.Greet("IP_ADDRESS_INVALID"));
                    Assert.AreEqual("Welcome", WelcomeMethodTask.Greet(""));
                    Assert.AreEqual("Welcome", WelcomeMethodTask.Greet("2"));
                }

                [Test]
                public void EnoughSpaceTest()
                {
                    Assert.AreEqual(0, EnoughSpaceTask.Enough(10, 5, 5));
                    Assert.AreEqual(10, EnoughSpaceTask.Enough(100, 60, 50));
                    Assert.AreEqual(0, EnoughSpaceTask.Enough(20, 5, 5));
                }

                [Test]
                public void ReversedSequenceTest()
                {
                    Assert.That(ReversedSequenceTask.ReverseSeq(5), Is.EqualTo(new int[] { 5, 4, 3, 2, 1 }));
                }

                [Test]
                public void SumWithoutHighestAndLowestNumberTest()
                {
                    Assert.AreEqual(16, SumWithoutHighestAndLowestNumberTask.Sum(new[] { 6, 2, 1, 8, 10 }));
                }

                [Test]
                public void MessiGoalsFunctionTest()
                {
                    Assert.AreEqual(9, MessiGoalsFunctionTask.GetGoals(1, 4, 4));
                    Assert.AreEqual(11, MessiGoalsFunctionTask.GetGoals(1, 6, 4));
                    Assert.AreEqual(15, MessiGoalsFunctionTask.GetGoals(10, 4, 1));
                    Assert.AreEqual(0, MessiGoalsFunctionTask.GetGoals(0, 0, 0));
                }

                [Test]
                public void SquareSumTaskTest()
                {
                    Assert.AreEqual(9, SquareSumTask.SquareSum(new int[] { 1, 2, 2 }));
                    Assert.AreEqual(5, SquareSumTask.SquareSum(new int[] { 1, 2 }));
                    Assert.AreEqual(50, SquareSumTask.SquareSum(new int[] { 5, 3, 4 }));
                    Assert.AreEqual(0, SquareSumTask.SquareSum(new int[] { }));
                }

                [Test]
                public void FinalGradeTest()
                {
                    Assert.AreEqual(100, FinalGradeTask.FinalGrade(100, 12));
                    Assert.AreEqual(90, FinalGradeTask.FinalGrade(85, 5));
                }

                [Test]
                public void TheFeastOfManyBeastsTest()
                {
                    Assert.AreEqual(true, TheFeastOfManyBeastsTask.Feast("great blue heron", "garlic naan"));
                    Assert.AreEqual(true, TheFeastOfManyBeastsTask.Feast("chickadee", "chocolate cake"));
                    Assert.AreEqual(false, TheFeastOfManyBeastsTask.Feast("brown bear", "bear claw"));
                }

                [Test]
                public void LostWithoutAMapTest()
                {
                    Assert.AreEqual(new[] { 2, 4, 6 }, LostWithoutAMapTask.Maps(new[] { 1, 2, 3 }));
                    Assert.AreEqual(new[] { 8, 2, 2, 2, 8 }, LostWithoutAMapTask.Maps(new[] { 4, 1, 1, 1, 4 }));
                    Assert.AreEqual(new[] { 4, 4, 4, 4, 4, 4 }, LostWithoutAMapTask.Maps(new[] { 2, 2, 2, 2, 2, 2 }));
                }

                [Test]
                public void InvertValuesTest()
                {
                    Assert.AreEqual(new int[] { -1, -2, -3, -4, -5 }, InvertValuesTask.InvertValues(new int[] { 1, 2, 3, 4, 5 }));
                    Assert.AreEqual(new int[] { -1, 2, -3, 4, -5 }, InvertValuesTask.InvertValues(new int[] { 1, -2, 3, -4, 5 }));
                    Assert.AreEqual(new int[] { }, InvertValuesTask.InvertValues(new int[] { }));
                    Assert.AreEqual(new int[] { 0 }, InvertValuesTask.InvertValues(new int[] { 0 }));
                }

                [Test]
                public void StrCountAllStarCodeChallengeTest()
                {
                    Assert.AreEqual(1, StrCountAllStarCodeChallengeTask.StrCount("Hello", 'o'));
                    Assert.AreEqual(2, StrCountAllStarCodeChallengeTask.StrCount("Hello", 'l'));
                    Assert.AreEqual(0, StrCountAllStarCodeChallengeTask.StrCount("Hello", 'p'));
                    Assert.AreEqual(0, StrCountAllStarCodeChallengeTask.StrCount("", 'z'));
                }

                [Test]
                public void MakeUpperCaseTest()
                {
                    Assert.AreEqual("HELLO", MakeUpperCaseTask.MakeUpperCase("hello"));
                }

                [Test]
                public void CalculateBMITest()
                {
                    Assert.AreEqual("Normal", CalculateBMITask.Bmi(80, 1.80));
                }

                [Test]
                public void IsUpperCaseTest()
                {
                    Assert.AreEqual(false, IsUpperCaseTask.IsUpperCase("c"));
                    Assert.AreEqual(true, IsUpperCaseTask.IsUpperCase("C"));
                    Assert.AreEqual(false, IsUpperCaseTask.IsUpperCase("hello I AM DONALD"));
                    Assert.AreEqual(true, IsUpperCaseTask.IsUpperCase("HELLO I AM DONALD"));
                    Assert.AreEqual(false, IsUpperCaseTask.IsUpperCase("ACSKLDFJSgSKLDFJSKLDFJ"));
                    Assert.AreEqual(true, IsUpperCaseTask.IsUpperCase("ACSKLDFJSGSKLDFJSKLDFJ"));
                }

                [Test]
                public void HowMuchILoveYouTest()
                {
                    Assert.AreEqual("I love you", HowMuchILoveYouTask.HowMuchILoveYou(7));
                    Assert.AreEqual("a lot", HowMuchILoveYouTask.HowMuchILoveYou(3));
                    Assert.AreEqual("not at all", HowMuchILoveYouTask.HowMuchILoveYou(6));
                }

                [Test]
                public void TrafficLightTest()
                {
                    Assert.AreEqual("yellow", TrafficLightTask.UpdateLight("green"));
                    Assert.AreEqual("red", TrafficLightTask.UpdateLight("yellow"));
                    Assert.AreEqual("green", TrafficLightTask.UpdateLight("red"));
                }

                [Test]
                public void FindNeedleTest()
                {
                    Assert.AreEqual("found the needle at position 3", FindNeedleTask.FindNeedle(new object[] { '3', "123124234", null, "needle", "world", "hay", 2, '3', true, false }));
                    Assert.AreEqual("found the needle at position 5", FindNeedleTask.FindNeedle(new object[] { "283497238987234", "a dog", "a cat", "some random junk", "a piece of hay", "needle", "something somebody lost a while ago" }));
                    Assert.AreEqual("found the needle at position 30", FindNeedleTask.FindNeedle(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 8, 7, 5, 4, 3, 4, 5, 6, 67, 5, 5, 3, 3, 4, 2, 34, 234, 23, 4, 234, 324, 324, "needle", 1, 2, 3, 4, 5, 5, 6, 5, 4, 32, 3, 45, 54 }));
                }

                [Test]
                public void FakeBinaryTest()
                {
                    Assert.AreEqual("01011110001100111", FakeBinaryTask.FakeBin("45385593107843568"));
                    Assert.AreEqual("101000111101101", FakeBinaryTask.FakeBin("509321967506747"));
                    Assert.AreEqual("011011110000101010000011011", FakeBinaryTask.FakeBin("366058562030849490134388085"));
                }

                [Test]
                public void CountOfPositivesSumOfNegativesTest()
                {
                    Assert.AreEqual(new int[] { 10, -65 }, CountOfPositivesSumOfNegativesTask.CountPositivesSumNegatives(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 }));
                    Assert.AreEqual(new int[] { 8, -50 }, CountOfPositivesSumOfNegativesTask.CountPositivesSumNegatives(new[] { 0, 2, 3, 0, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14 }));
                    Assert.AreEqual(new int[] { }, CountOfPositivesSumOfNegativesTask.CountPositivesSumNegatives(null));
                }

                [Test]
                public void FindTheSmallestIntegerTest()
                {
                    Assert.AreEqual(11, FindTheSmallestIntegerTask.FindSmallestInt(new int[] { 78, 56, 232, 12, 11, 43 }));
                    Assert.AreEqual(-33, FindTheSmallestIntegerTask.FindSmallestInt(new int[] { 78, 56, -2, 12, 8, -33 }));

                }

                [Test]
                public void RemoveStringSpacesTest()
                {
                    Assert.AreEqual("8j8mBliB8gimjB8B8jlB", RemoveStringSpacesTask.NoSpace("8 j 8   mBliB8g  imjB8B8  jl  B"));
                    Assert.AreEqual("88Bifk8hB8BB8BBBB888chl8BhBfd", RemoveStringSpacesTask.NoSpace("8 8 Bi fk8h B 8 BB8B B B  B888 c hl8 BhB fd"));
                    Assert.AreEqual("8aaaaaddddr", RemoveStringSpacesTask.NoSpace("8aaaaa dddd r     "));
                }

                [Test]
                public void GradeBookTest()
                {
                    Assert.AreEqual('A', GradeBookTask.GetGrade(95, 90, 93));
                    Assert.AreEqual('B', GradeBookTask.GetGrade(70, 70, 100));
                    Assert.AreEqual('C', GradeBookTask.GetGrade(70, 71, 72));
                    Assert.AreEqual('D', GradeBookTask.GetGrade(65, 66, 60));
                    Assert.AreEqual('F', GradeBookTask.GetGrade(32, 15, 21));

                }

                [Test]
                public void YouCantCodeUnderPressureTest()
                {
                    Assert.AreEqual(200, YouCantCodeUnderPressureTask.DoubleInteger(100));
                    Assert.AreEqual(4, YouCantCodeUnderPressureTask.DoubleInteger(2));
                    Assert.AreEqual(8, YouCantCodeUnderPressureTask.DoubleInteger(4));
                    Assert.AreEqual(-20, YouCantCodeUnderPressureTask.DoubleInteger(-10));

                }

                [Test]
                public void VolumeOfACuboidTest()
                {
                    Assert.AreEqual(60, VolumeOfACuboidTask.GetVolumeOfCuboid(2, 5, 6), 0.00001, "Length: 2, Width: 5, Height: 6");
                    Assert.AreEqual(94.5, VolumeOfACuboidTask.GetVolumeOfCuboid(6.3, 3, 5), 0.00001, "Length: 6.3, Width: 3, Height: 5");
                }

                [Test]
                public void CalculateAverageTest()
                {
                    Assert.AreEqual(200.0 / 13.0, CalculateAverageTask.FindAverage(new double[] { 17, 16, 16, 16, 16, 15, 17, 17, 15, 5, 17, 17, 16 }));
                    Assert.AreEqual(0, CalculateAverageTask.FindAverage(new double[] { }));
                }

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
}