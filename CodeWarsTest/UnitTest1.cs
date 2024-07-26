using CodeWars8kyu;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Drawing;
using System.Numerics;
using System.Runtime.InteropServices.JavaScript;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
				public void EnumerableMagicTrueTest()
				{
					Assert.AreEqual(true, EnumerableMagicTrueTask.Any(new int[] { 1, 2, 3, 4 }, v => v > 3));
					Assert.AreEqual(false, EnumerableMagicTrueTask.Any(new int[] { 1, 2, 3, 4 }, v => v > 4));
				}

				[Test]
				public static void FixedTest()
				{
					Assert.AreEqual(true, WilsonPrimesTask.AmIWilson(5));
					Assert.AreEqual(false, WilsonPrimesTask.AmIWilson(9));
					Assert.AreEqual(false, WilsonPrimesTask.AmIWilson(6));

				}


				[TestFixture]
                public class DuckDuckGooseTests
                {
                    [TestCase(1, "a")]
                    [TestCase(3, "c")]
                    [TestCase(10, "z")]
                    [TestCase(20, "z")]
                    [TestCase(30, "z")]
                    [TestCase(18, "g")]
                    [TestCase(28, "g")]
                    [TestCase(12, "b")]
                    [TestCase(2, "b")]
                    [TestCase(7, "f")]
                    public void DuckDuckGooseTest(int goose, string expectedName)
                    {
                        var exampleNames = new string[] { "a", "b", "c", "d", "c", "e", "f", "g", "h", "z" };
                        var players = exampleNames.Select(name => new DuckDuckGooseTask(name)).ToArray();
                        string result = DuckDuckGooseTask.DuckDuckGoose(players, goose);
                        Assert.AreEqual(expectedName, result);
                    }
                }

					[Test]
				public static void OnlineRPGTest()
				{
					Assert.AreEqual(OnlineRPGTask.PlayerRankUp(64), false);
					Assert.AreEqual(OnlineRPGTask.PlayerRankUp(101), "Well done! You have advanced to the qualifying stage. Win 2 out of your next 3 games to rank up.");
				}

				[Test]
                public void SampleTest()
                {
                    Assert.AreEqual("0,1,2,3,45\n10,11,12,13,14\n20,21,22,23,24\n30,31,32,33,34",
                        CSVRepresentationTask.ToCsvText(new[]
                        {
                new[] {0, 1, 2, 3, 45},
                new[] {10, 11, 12, 13, 14},
                new[] {20, 21, 22, 23, 24},
                new[] {30, 31, 32, 33, 34}
                        })
                    );
                }

                    [Test]
                public void GeometryBasicsTest()
                {
                    DoTest(new Point(3, 3), new Point(3, 3), 0);
                    DoTest(new Point(1, 6), new Point(4, 2), 5);

                    void DoTest(Point a, Point b, double expected)
                    {
                        double actual = GeometryBasicsTask.DistanceBetweenPoints(a, b);
                        Assert.AreEqual(expected, actual, 1e-6, "Incorrect answer for:\n  a=Point({0}, {1})\n  b=Point({2}, {3})\n", a.X, a.Y, b.X, b.Y);
                    }
                }

                [Test]
                public void EnumerableMagicTest()
                {
                    Assert.AreEqual(true, EnumerableMagicTask.All(new int[] { 1, 2, 3, 4, 5 }, v => v < 9));
                    Assert.AreEqual(false, EnumerableMagicTask.All(new int[] { 1, 2, 3, 4, 5 }, v => v > 9));
                }
                [Test]
                public void test1()
                {
                    ClassicHelloWorldTask.MainTask(new string[] { "Greetings from Javatlacati" });
                    Assert.AreEqual(1, 1);
                }

                [Test]
                public void NameOnBillboardTest()
                {
                    Assert.AreEqual(600, NameOnBillboardTask.Billboard("Jeong-Ho Aristotelis"));
                    Assert.AreEqual(40, NameOnBillboardTask.Billboard("CODEWARS", 5));
                }

                [Test]
                public void FinishGuessTheNumberGameTest()
                {
                    FinishGuessTheNumberGameTask guesser = new FinishGuessTheNumberGameTask(10, 2);
                    guesser.Guess(10);
                    guesser.Guess(10);
                    guesser.Guess(10);
                    guesser.Guess(10);
                    Assert.IsTrue(guesser.Guess(10));
                }

                [Test]
                public static void GraderTest()
                {
                    Assert.AreEqual('C', GraderTask.Grader(0.7));
                    Assert.AreEqual('A', GraderTask.Grader(0.9));
                    Assert.AreEqual('D', GraderTask.Grader(0.6));
                    Assert.AreEqual('F', GraderTask.Grader(0.2));
                }

                [Test]
                public void ConvertToBinaryTest()
                {
                    Assert.AreEqual(1, ConvertToBinaryTask.ToBinary(1));
                    Assert.AreEqual(11, ConvertToBinaryTask.ToBinary(3));
                    Assert.AreEqual(101, ConvertToBinaryTask.ToBinary(5));

                }

                [Test]
                public void CascadingSubsetsTest()
                {
                    Assert.AreEqual(new[] { new[] { 3 }, new[] { 5 }, new[] { 8 }, new[] { 13 } }, CascadingSubsetsTask.EachCons(new int[] { 3, 5, 8, 13 }, 1));
                    Assert.AreEqual(new[] { new[] { 3, 5, 8, 13 } }, CascadingSubsetsTask.EachCons(new int[] { 3, 5, 8, 13 }, 4));
                    Assert.AreEqual(new[] { new[] { 3, 5, 8 }, new[] { 5, 8, 13 } }, CascadingSubsetsTask.EachCons(new int[] { 3, 5, 8, 13 }, 3));


                }

                [Test]
                public void FindTheSlopeTest()
                {
                    int[] test1 = { 19, 3, 20, 3 };
                    int[] test2 = { 7, 2, 7, 4 };
                    int[] test3 = { 10, 50, 30, 150 };
                    int[] test4 = { 15, 45, 12, 60 };
                    int[] test5 = { 10, 20, 20, 80 };
                    int[] test6 = { -10, 6, -10, 3 };
                    FindTheSlopeTask s = new FindTheSlopeTask();
                    Assert.AreEqual("0", s.Slope(test1));
                    Assert.AreEqual("undefined", s.Slope(test2));
                    Assert.AreEqual("5", s.Slope(test3));
                    Assert.AreEqual("-5", s.Slope(test4));
                    Assert.AreEqual("6", s.Slope(test5));
                    Assert.AreEqual("undefined", s.Slope(test6));
                }

                [Test]
                public void SharkPontoonTest()
                {
                    Assert.AreEqual("Alive!", SharkPontoonTask.Shark(29, 118, 1, 4, false));
                    Assert.AreEqual("Alive!", SharkPontoonTask.Shark(12, 50, 4, 8, true));
                    Assert.AreEqual("Alive!", SharkPontoonTask.Shark(12, 50, 4, 8, false));
                    Assert.AreEqual("Alive!", SharkPontoonTask.Shark(7, 55, 4, 16, true));
                    Assert.AreEqual("Shark Bait!", SharkPontoonTask.Shark(24, 0, 4, 8, true));
                    Assert.AreEqual("Shark Bait!", SharkPontoonTask.Shark(40, 35, 3, 20, true));
                    Assert.AreEqual("Alive!", SharkPontoonTask.Shark(7, 8, 3, 4, true));
                    Assert.AreEqual("Shark Bait!", SharkPontoonTask.Shark(7, 8, 3, 4, false));
                }

                [Test]
                public void EvilOrOdiousTest()
                {
                    Assert.AreEqual("It's Odious!", EvilOrOdiousTask.Evil(1));
                    Assert.AreEqual("It's Odious!", EvilOrOdiousTask.Evil(2));
                    Assert.AreEqual("It's Evil!", EvilOrOdiousTask.Evil(3));
                }

                [Test]
                public static void PlayingWithCubesTest()
                {
                    PlayingWithCubesTask c = new PlayingWithCubesTask();
                    Assert.AreEqual(0, c.GetSide(), "when not set before, Side should be 0");
                    c.SetSide(5);
                    Assert.AreEqual(5, c.GetSide(), "Should return 5");
                }

                [Test]
                public static void LocalizeTheBarycenterTest()
                {
                    Assert.AreEqual(new double[] { 8.6667, 6.6667 }, LocalizeTheBarycenterTask.BarTriang(
                        new double[] { 4, 6 }, new double[] { 12, 4 }, new double[] { 10, 10 }));
                    Assert.AreEqual(new double[] { 7.3333, 4.6667 }, LocalizeTheBarycenterTask.BarTriang(
                                new double[] { 4, 2 }, new double[] { 12, 2 }, new double[] { 6, 10 }));
                }

                [Test]
                public void RemoveDuplicatesTest()
                {
                    Assert.AreEqual(new int[] { 1 }, RemoveDuplicatesTask.Distinct(new int[] { 1 }));
                    Assert.AreEqual(new int[] { 1, 2 }, RemoveDuplicatesTask.Distinct(new int[] { 1, 2 }));
                    Assert.AreEqual(new int[] { 1, 2 }, RemoveDuplicatesTask.Distinct(new int[] { 1, 1, 2 }));
                }

                [Test]
                public void NBAFullTest()
                {
                    Assert.AreEqual(28.8, NBAFullTask.NbaExtrap(12, 20));
                    Assert.AreEqual(48.0, NBAFullTask.NbaExtrap(10, 10));
                    Assert.AreEqual(14.1, NBAFullTask.NbaExtrap(5, 17));
                    Assert.AreEqual(0, NBAFullTask.NbaExtrap(0, 0));
                    Assert.AreEqual(42.6, NBAFullTask.NbaExtrap(30.8, 34.7));
                    Assert.AreEqual(32.5, NBAFullTask.NbaExtrap(22.9, 33.8));
                }

                [Test]
                public void AgeRangeCompatibilityEquationTest()
                {
                    Assert.AreEqual("15-20", AgeRangeCompatibilityEquationTask.DatingRange(17));
                    Assert.AreEqual("27-66", AgeRangeCompatibilityEquationTask.DatingRange(40));
                    Assert.AreEqual("14-16", AgeRangeCompatibilityEquationTask.DatingRange(15));
                    Assert.AreEqual("24-56", AgeRangeCompatibilityEquationTask.DatingRange(35));
                    Assert.AreEqual("9-11", AgeRangeCompatibilityEquationTask.DatingRange(10));
                }

                [Test]
                public void PickASetOfFirstElementsTest()
                {
                    var arr = new object[] { 'a', 'b', 'c', 'd', 'e' };
                    Assert.AreEqual(new object[] { 'a' }, PickASetOfFirstElementsTask.TakeFirstElements(arr));
                    Assert.AreEqual(new object[] { 'a', 'b' }, PickASetOfFirstElementsTask.TakeFirstElements(arr, 2));
                }


                [Test]
                public void QuadrantsTest()
                {
                    Assert.AreEqual(1, QuadrantsTask.Quadrant(1, 2));
                    Assert.AreEqual(2, QuadrantsTask.Quadrant(-10, 100));
                    Assert.AreEqual(3, QuadrantsTask.Quadrant(-1, -9));
                    Assert.AreEqual(3, QuadrantsTask.Quadrant(-60, -12));
                    Assert.AreEqual(4, QuadrantsTask.Quadrant(19, -56));

                }

                [Test]
                public void DidSheSayHalloTest()
                {
                    Assert.IsTrue(DidSheSayHalloTask.Validate_hello("hello"));
                    Assert.IsTrue(DidSheSayHalloTask.Validate_hello("ciao bella!"));
                    Assert.IsTrue(DidSheSayHalloTask.Validate_hello("salut"));
                    Assert.IsTrue(DidSheSayHalloTask.Validate_hello("hallo, salut"));
                    Assert.IsTrue(DidSheSayHalloTask.Validate_hello("hombre! Hola!"));
                    Assert.IsTrue(DidSheSayHalloTask.Validate_hello("Hallo, wie geht\'s dir?"));
                    Assert.IsTrue(DidSheSayHalloTask.Validate_hello("AHOJ!"));
                    Assert.IsTrue(DidSheSayHalloTask.Validate_hello("czesc"));
                    Assert.IsTrue(DidSheSayHalloTask.Validate_hello("Ahoj"));
                    Assert.IsFalse(DidSheSayHalloTask.Validate_hello("meh"));
                }

                [Test]
                public void ReturnTwoHighestValuesInListTest()
                {
                    Assert.AreEqual(Array.Empty<int>(), ReturnTwoHighestValuesInListTask.TwoHighest(Array.Empty<int>()));
                    Assert.AreEqual(new[] { 15 }, ReturnTwoHighestValuesInListTask.TwoHighest(new[] { 15 }));
                    Assert.AreEqual(new[] { 20, 17 }, ReturnTwoHighestValuesInListTask.TwoHighest(new[] { 15, 20, 20, 17 }));
                    Assert.AreEqual(new[] { 10, 9 }, ReturnTwoHighestValuesInListTask.TwoHighest(new[] { 4, 10, 10, 9 }));
                    Assert.AreEqual(new[] { 1 }, ReturnTwoHighestValuesInListTask.TwoHighest(new[] { 1, 1, 1 }));
                    Assert.AreEqual(new[] { 5, 4 }, ReturnTwoHighestValuesInListTask.TwoHighest(new[] { 4, 1, 2, 3, 5 }));
                    Assert.AreEqual(new[] { 3, 2 }, ReturnTwoHighestValuesInListTask.TwoHighest(new[] { 1, 1, 2, 2, 3, 3 }));
                    Assert.AreEqual(new[] { 9, 6 }, ReturnTwoHighestValuesInListTask.TwoHighest(new[] { 0, 3, 0, 6, 0, 9 }));
                    Assert.AreEqual(new[] { 0 }, ReturnTwoHighestValuesInListTask.TwoHighest(new[] { 0, 0, 0 }));
                    Assert.AreEqual(new[] { 9, 0 }, ReturnTwoHighestValuesInListTask.TwoHighest(new[] { 0, 9, 0 }));
                }

                [Test]
                public void ValidateCodeWithSimpleRegexTest()
                {
                    Assert.AreEqual(true, ValidateCodeWithSimpleRegexTask.ValidateCode("123"));
                    Assert.AreEqual(true, ValidateCodeWithSimpleRegexTask.ValidateCode("248"));
                    Assert.AreEqual(false, ValidateCodeWithSimpleRegexTask.ValidateCode("8"));
                    Assert.AreEqual(false, ValidateCodeWithSimpleRegexTask.ValidateCode("9453"));
                    Assert.AreEqual(false, ValidateCodeWithSimpleRegexTask.ValidateCode(""));
                    Assert.AreEqual(false, ValidateCodeWithSimpleRegexTask.ValidateCode("0"));
                }

                [Test]
                public void CheckSameCaseTest()
                {
                    Assert.AreEqual(1, CheckSameCaseTask.SameCase('a', 'u'));
                    Assert.AreEqual(1, CheckSameCaseTask.SameCase('A', 'U'));
                    Assert.AreEqual(1, CheckSameCaseTask.SameCase('Q', 'P'));
                    Assert.AreEqual(1, CheckSameCaseTask.SameCase('w', 'y'));
                    Assert.AreEqual(1, CheckSameCaseTask.SameCase('c', 'm'));
                    Assert.AreEqual(1, CheckSameCaseTask.SameCase('N', 'W'));
                    Assert.AreEqual(0, CheckSameCaseTask.SameCase('a', 'U'));
                    Assert.AreEqual(0, CheckSameCaseTask.SameCase('A', 'u'));
                    Assert.AreEqual(0, CheckSameCaseTask.SameCase('Q', 'p'));
                    Assert.AreEqual(0, CheckSameCaseTask.SameCase('w', 'Y'));
                    Assert.AreEqual(0, CheckSameCaseTask.SameCase('c', 'M'));
                    Assert.AreEqual(0, CheckSameCaseTask.SameCase('N', 'w')); 
                    Assert.AreEqual(-1, CheckSameCaseTask.SameCase('a', '*'));
                    Assert.AreEqual(-1, CheckSameCaseTask.SameCase('A', '%'));
                    Assert.AreEqual(-1, CheckSameCaseTask.SameCase('Q', '1'));
                    Assert.AreEqual(-1, CheckSameCaseTask.SameCase('w', '-'));
                    Assert.AreEqual(-1, CheckSameCaseTask.SameCase('c', '8'));
                    Assert.AreEqual(-1, CheckSameCaseTask.SameCase('N', ':'));
                }

                [Test]
                public void LogicalCalculatorTest()
                {
                    Assert.AreEqual(false, LogicalCalculatorTask.LogicalCalc(new bool[] { true, true, true, false }, "AND"));
                    Assert.AreEqual(true, LogicalCalculatorTask.LogicalCalc(new bool[] { true, true, true, false }, "OR"));
                    Assert.AreEqual(true, LogicalCalculatorTask.LogicalCalc(new bool[] { true, true, true, false }, "XOR"));
                    Assert.AreEqual(false, LogicalCalculatorTask.LogicalCalc(new bool[] { true, true, false, false }, "AND"));
                    Assert.AreEqual(true, LogicalCalculatorTask.LogicalCalc(new bool[] { true, true, false, false }, "OR"));
                    Assert.AreEqual(false, LogicalCalculatorTask.LogicalCalc(new bool[] { true, true, false, false }, "XOR"));
                    Assert.AreEqual(false, LogicalCalculatorTask.LogicalCalc(new bool[] { true, false, false, false }, "AND"));
                    Assert.AreEqual(true, LogicalCalculatorTask.LogicalCalc(new bool[] { true, false, false, false }, "OR"));
                    Assert.AreEqual(true, LogicalCalculatorTask.LogicalCalc(new bool[] { true, false, false, false }, "XOR"));
                    Assert.AreEqual(true, LogicalCalculatorTask.LogicalCalc(new bool[] { true, true }, "AND"));
                    Assert.AreEqual(true, LogicalCalculatorTask.LogicalCalc(new bool[] { true, true }, "OR"));
                    Assert.AreEqual(false, LogicalCalculatorTask.LogicalCalc(new bool[] { true, true }, "XOR"));
                    Assert.AreEqual(false, LogicalCalculatorTask.LogicalCalc(new bool[] { false, false }, "AND"));
                    Assert.AreEqual(false, LogicalCalculatorTask.LogicalCalc(new bool[] { false, false }, "OR"));
                    Assert.AreEqual(false, LogicalCalculatorTask.LogicalCalc(new bool[] { false, false }, "XOR"));
                    Assert.AreEqual(false, LogicalCalculatorTask.LogicalCalc(new bool[] { false }, "AND"));
                    Assert.AreEqual(false, LogicalCalculatorTask.LogicalCalc(new bool[] { false }, "OR"));
                    Assert.AreEqual(false, LogicalCalculatorTask.LogicalCalc(new bool[] { false }, "XOR"));
                    Assert.AreEqual(true, LogicalCalculatorTask.LogicalCalc(new bool[] { true }, "AND"));
                    Assert.AreEqual(true, LogicalCalculatorTask.LogicalCalc(new bool[] { true }, "OR"));
                    Assert.AreEqual(true, LogicalCalculatorTask.LogicalCalc(new bool[] { true }, "XOR"));
                }

                [Test]
                public void ClassyClassesTask()
                {
                    Person john = new Person("john", 34);
                    Assert.AreEqual("johns age is 34", Person.Create("john", 34));
                }

                [Test]
                public void AreArrowFunctionsOddTest()
                {
                    Assert.AreEqual(new List<int> { 1, 3, 5 }, AreArrowFunctionsOddTask.Odds(new List<int> { 1, 2, 3, 4, 5, 6 }));
                   
                }

                [Test]
                public void BinToDecimalTest()
                {
                    Assert.AreEqual(0, BinToDecimalTask.BinToDec("0"));
                    Assert.AreEqual(1, BinToDecimalTask.BinToDec("1"));
                    Assert.AreEqual(2, BinToDecimalTask.BinToDec("10"));
                    Assert.AreEqual(3, BinToDecimalTask.BinToDec("11"));
                    Assert.AreEqual(6, BinToDecimalTask.BinToDec("110"));
                }

                [Test]
                public void IsYourPeriodLateTest()
                {
                    Assert.AreEqual(false, IsYourPeriodLateTask.PeriodIsLate(new DateTime(2016, 06, 13), new DateTime(2016, 07, 16), 35));
                    Assert.AreEqual(true, IsYourPeriodLateTask.PeriodIsLate(new DateTime(2016, 06, 13), new DateTime(2016, 07, 16), 28));
                    Assert.AreEqual(false, IsYourPeriodLateTask.PeriodIsLate(new DateTime(2016, 06, 13), new DateTime(2016, 07, 16), 35));
                    Assert.AreEqual(false, IsYourPeriodLateTask.PeriodIsLate(new DateTime(2016, 06, 13), new DateTime(2016, 06, 29), 28));
                    Assert.AreEqual(false, IsYourPeriodLateTask.PeriodIsLate(new DateTime(2016, 07, 12), new DateTime(2016, 08, 09), 28));
                    Assert.AreEqual(true, IsYourPeriodLateTask.PeriodIsLate(new DateTime(2016, 07, 12), new DateTime(2016, 08, 10), 28));
                    Assert.AreEqual(true, IsYourPeriodLateTask.PeriodIsLate(new DateTime(2016, 07, 01), new DateTime(2016, 08, 01), 28));
                    Assert.AreEqual(false, IsYourPeriodLateTask.PeriodIsLate(new DateTime(2016, 06, 01), new DateTime(2016, 06, 30), 30));
                    Assert.AreEqual(false, IsYourPeriodLateTask.PeriodIsLate(new DateTime(2016, 01, 01), new DateTime(2016, 01, 31), 30));
                    Assert.AreEqual(true, IsYourPeriodLateTask.PeriodIsLate(new DateTime(2016, 01, 01), new DateTime(2016, 02, 01), 30));
                    Assert.AreEqual(false, IsYourPeriodLateTask.PeriodIsLate(new DateTime(2020, 06, 01), new DateTime(2020, 07, 01), 40));
                    Assert.AreEqual(false, IsYourPeriodLateTask.PeriodIsLate(new DateTime(2020, 06, 01), new DateTime(2020, 06, 30), 30));
                    Assert.AreEqual(true, IsYourPeriodLateTask.PeriodIsLate(new DateTime(2020, 06, 12), new DateTime(2020, 07, 12), 28));
                    Assert.AreEqual(false, IsYourPeriodLateTask.PeriodIsLate(new DateTime(2000, 01, 01), new DateTime(2000, 01, 01), 28));
                    Assert.AreEqual(true, IsYourPeriodLateTask.PeriodIsLate(new DateTime(2022, 01, 01), new DateTime(2022, 02, 01), 30));
                    Assert.AreEqual(false, IsYourPeriodLateTask.PeriodIsLate(new DateTime(2022, 01, 01), new DateTime(2022, 02, 01), 40));
                }

                [Test]
                public void FuelCalculatorTotalCostTest()
                {
                    Assert.AreEqual(5.65, FuelCalculatorTotalCostTask.FuelPrice(5, 1.23));
                    Assert.AreEqual(18.40, FuelCalculatorTotalCostTask.FuelPrice(8, 2.5));
                    Assert.AreEqual(27.50, FuelCalculatorTotalCostTask.FuelPrice(5, 5.6));
                }

                [Test]
                public void ASCIITotalSumTest()
                {
                    Assert.AreEqual(97, ASCIITotalSumTask.UniTotal("a"));
                    Assert.AreEqual(101, ASCIITotalSumTask.UniTotal("e"));
                    Assert.AreEqual(1873, ASCIITotalSumTask.UniTotal("Mary Had A Little Lamb"));
                }

                [Test]
                public void ForUFCFansConorVsPierreTest()
                {
                    Assert.AreEqual("I am not impressed by your performance.", ForUFCFansConorVsPierreTask.Quote("george saint pierre"));
                    Assert.AreEqual("I'd like to take this chance to apologize.. To absolutely NOBODY!", ForUFCFansConorVsPierreTask.Quote("conor mcgregor"));
                    Assert.AreEqual("I am not impressed by your performance.", ForUFCFansConorVsPierreTask.Quote("George Saint Pierre"));
                    Assert.AreEqual("I'd like to take this chance to apologize.. To absolutely NOBODY!", ForUFCFansConorVsPierreTask.Quote("Conor McGregor"));
                }

                [Test]
                public void FormattingDecimalPlacesTest()
                {
                    Assert.AreEqual(173735326.38, FormattingDecimalPlacesTask.TwoDecimalPlaces(173735326.3783732637948948));
                }

                [Test]
                public void MergeTwoSortedArraysIntoOneTest()
                {
                    Assert.AreEqual(new[] { 1, 2, 3, 4, 5, 6, 7, 8 },
                                    MergeTwoSortedArraysIntoOneTask.MergeArrays(new[] { 1, 2, 3, 4 }, new[] { 5, 6, 7, 8 }));

                    Assert.AreEqual(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                                    MergeTwoSortedArraysIntoOneTask.MergeArrays(new[] { 1, 3, 5, 7, 9 }, new[] { 10, 8, 6, 4, 2 }));

                    Assert.AreEqual(new[] { 1, 2, 3, 4, 5, 7, 9, 10, 11, 12 },
                                    MergeTwoSortedArraysIntoOneTask.MergeArrays(new[] { 1, 3, 5, 7, 9, 11, 12 }, new[] { 1, 2, 3, 4, 5, 10, 12 }));

                    Assert.AreEqual(new int[] { }, MergeTwoSortedArraysIntoOneTask.MergeArrays(new int[] { }, new int[] { }));

                    Assert.AreEqual(new[] { 1, 2, 3 }, MergeTwoSortedArraysIntoOneTask.MergeArrays(new[] { 1, 2, 3 }, new int[] { }));

                    Assert.AreEqual(new int[] { 1, 2, 3, 4, 5 },
                                    MergeTwoSortedArraysIntoOneTask.MergeArrays(new int[] { }, new int[] { 1, 2, 3, 4, 5 }));

                    Assert.AreEqual(new int[] { -3, -2, -1, 0, 1, 2, 3, 4 },
                                    MergeTwoSortedArraysIntoOneTask.MergeArrays(new[] { -3, -2, -1, 0 }, new int[] { 1, 2, 3, 4 }));
                }

                [Test]
                public void CompareWithinMarginTest()
                {
                    Assert.AreEqual(-1, CompareWithinMarginTask.CloseCompare(4, 5));
                    Assert.AreEqual(0, CompareWithinMarginTask.CloseCompare(5, 5));
                    Assert.AreEqual(1, CompareWithinMarginTask.CloseCompare(6, 5));
                    Assert.AreEqual(-1, CompareWithinMarginTask.CloseCompare(-6, -5));

                    Assert.AreEqual(0, CompareWithinMarginTask.CloseCompare(2, 5, 3));
                    Assert.AreEqual(1, CompareWithinMarginTask.CloseCompare(8.1, 5, 3));
                    Assert.AreEqual(-1, CompareWithinMarginTask.CloseCompare(1.99, 5, 3));
                }

                [Test]
                public void HowManyStairsWillSuzukiClimbTest()
                {
                    int[] sunday = {6737, 7244, 5776, 9826, 7057, 9247, 5842, 5484, 6543, 5153, 6832, 8274,
                              7148, 6152, 5940, 8040, 9174, 7555, 7682, 5252, 8793, 8837, 7320, 8478, 6063,
                              5751, 9716, 5085, 7315, 7859, 6628, 5425, 6331, 7097, 6249, 8381, 5936, 8496,
                              6934, 8347, 7036, 6421, 6510, 5821, 8602, 5312, 7836, 8032, 9871, 5990, 6309, 7825};

                    int[] monday = {9175, 7883, 7596, 8635, 9274, 9675, 5603, 6863, 6442, 9500, 7468, 9719,
                              6648, 8180, 7944, 5190, 6209, 7175, 5984, 9737, 5548, 6803, 9254, 5932, 7360, 9221,
                              5702, 5252, 7041, 7287, 5185, 9139, 7187, 8855, 9310, 9105, 9769, 9679, 7842,
                              7466, 7321, 6785, 8770, 8108, 7985, 5186, 9021, 9098, 6099, 5828, 7217, 9387};

                    int[] tuesday = {8646, 6945, 6364, 9563, 5627, 5068, 9157, 9439, 5681, 8674, 6379, 8292,
                              7552, 5370, 7579, 9851, 8520, 5881, 7138, 7890, 6016, 5630, 5985, 9758, 8415, 7313,
                              7761, 9853, 7937, 9268, 7888, 6589, 9366, 9867, 5093, 6684, 8793, 8116, 8493,
                              5265, 5815, 7191, 9515, 7825, 9508, 6878, 7180, 8756, 5717, 7555, 9447, 7703};

                    int[] wednesday = {6353, 9605, 5464, 9752, 9915, 7446, 9419, 6520, 7438, 6512, 7102,
                              5047, 6601, 8303, 9118, 5093, 8463, 7116, 7378, 9738, 9998, 7125, 6445, 6031, 8710,
                              5182, 9142, 9415, 9710, 7342, 9425, 7927, 9030, 7742, 8394, 9652, 5783, 7698,
                              9492, 6973, 6531, 7698, 8994, 8058, 6406, 5738, 7500, 8357, 7378, 9598, 5405, 9493};

                    int[] thursday = {6149, 6439, 9899, 5897, 8589, 7627, 6348, 9625, 9490, 5502, 5723, 8197,
                              9866, 6609, 6308, 7163, 9726, 7222, 7549, 6203, 5876, 8836, 6442, 6752, 8695, 8402,
                              9638, 9925, 5508, 8636, 5226, 9941, 8936, 5047, 6445, 8063, 6083, 7383, 7548, 5066,
                              7107, 6911, 9302, 5202, 7487, 5593, 8620, 8858, 5360, 6638, 8012, 8701};

                    int[] friday = {5000, 5642, 9143, 7731, 8477, 8000, 7411, 8813, 8288, 5637, 6244, 6589, 6362,
                              6200, 6781, 8371, 7082, 5348, 8842, 9513, 5896, 6628, 8164, 8473, 5663, 9501,
                              9177, 8384, 8229, 8781, 9160, 6955, 9407, 7443, 8934, 8072, 8942, 6859, 5617,
                              5078, 8910, 6732, 9848, 8951, 9407, 6699, 9842, 7455, 8720, 5725, 6960, 5127};

                    int[] saturday = {5448, 8041, 6573, 8104, 6208, 5912, 7927, 8909, 7000, 5059, 6412, 6354, 8943,
                              5460, 9979, 5379, 8501, 6831, 7022, 7575, 5828, 5354, 5115, 9625, 7795, 7003,
                              5524, 9870, 6591, 8616, 5163, 6656, 8150, 8826, 6875, 5242, 9585, 9649, 9838,
                              7150, 6567, 8524, 7613, 7809, 5562, 7799, 7179, 5184, 7960, 9455, 5633, 9085};

                    int[][] stairs = { sunday, monday, tuesday, wednesday, thursday, friday, saturday };
                    long expected = 54636040;
                    Assert.AreEqual(expected, HowManyStairsWillSuzukiClimbTask.StairsIn20(stairs));
                }

                [Test]
                public void TerminalGameTask()
                {
                    Hero myHero = new Hero();
                    Assert.AreEqual("Hero", myHero.Name);

                    Hero myHero2 = new Hero();
                    Assert.That(myHero2.Health is float);
                }


                [Test]
                public static void ExampleTwistTest()
                {
                    Assert.AreEqual(ExampleTwistTask.Websites.Length, 1000);
                    Assert.AreEqual(ExampleTwistTask.Websites.GetType().GetElementType(), typeof(System.String));
                    Assert.That(Array.TrueForAll(ExampleTwistTask.Websites, (v) => v == "codewars"));
                }

                [Test]
                public void GetASCIITest()
                {
                    Assert.That(GetASCIITask.GetASCII('A'), Is.EqualTo(65));
                    Assert.That(GetASCIITask.GetASCII(' '), Is.EqualTo(32));
                    Assert.That(GetASCIITask.GetASCII('!'), Is.EqualTo(33));
                }
                [Test]
                public void NumberDrillsBlueAndRedMarblesTest()
                {
                    Assert.AreEqual(0.6d, NumberDrillsBlueAndRedMarblesTask.GuessBlue(5, 5, 2, 3), 1e-10);
                    Assert.AreEqual(0.2d, NumberDrillsBlueAndRedMarblesTask.GuessBlue(5, 7, 4, 3), 1e-10);
                    Assert.AreEqual(0.4d, NumberDrillsBlueAndRedMarblesTask.GuessBlue(12, 18, 4, 6), 1e-10);
                }

                [Test]
                public void PrintingArrayElementsWithCommaDelimitersTest()
                {

                    Assert.AreEqual("2,4,5,2", PrintingArrayElementsWithCommaDelimitersTask.PrintArray(new object[] { 2, 4, 5, 2 }));
                    Assert.AreEqual("38,57,69,63,43,24,32", PrintingArrayElementsWithCommaDelimitersTask.PrintArray(new object[] { 38, 57, 69, 63, 43, 24, 32 }));
                    Assert.AreEqual("2", PrintingArrayElementsWithCommaDelimitersTask.PrintArray(new object[] { 2 }));
                }

                [Test]
                public void ObjectOrientedPiracyTest()
                {
                    Assert.AreEqual(false, new ObjectOrientedPiracyTask(15, 10).IsWorthIt());
                    Assert.AreEqual(false, new ObjectOrientedPiracyTask(15, 20).IsWorthIt());
                    Assert.AreEqual(true, new ObjectOrientedPiracyTask(100, 20).IsWorthIt());
                    Assert.AreEqual(false, new ObjectOrientedPiracyTask(35, 20).IsWorthIt());
                }

                [Test]
                public void ParseFloatTest()
                {
                    Assert.AreEqual(1.0d, ParseFloatTask.ParseF("1"));
                }

                [Test]
                public void MultiplyTheNumberFiveTest()
                {
                    Assert.AreEqual(250, MultiplyTheNumberFiveTask.Multiply(10));
                    Assert.AreEqual(25, MultiplyTheNumberFiveTask.Multiply(5));
                    Assert.AreEqual(25000, MultiplyTheNumberFiveTask.Multiply(200));
                    Assert.AreEqual(0, MultiplyTheNumberFiveTask.Multiply(0));
                    Assert.AreEqual(-10, MultiplyTheNumberFiveTask.Multiply(-2));
                }

                [Test]
                public void OppositeNumberTest()
                {
                    Assert.AreEqual(-1, OppositeNumberTask.Opposite(1));
                    Assert.AreEqual(5, OppositeNumberTask.Opposite(-5));
                }


                [Test]
                public void ReplaceAllVowelToExclamationMarkTest()
                {
                    Assert.AreEqual("H!!", ReplaceAllVowelToExclamationMarkTask.Replace("Hi!"));
                    Assert.AreEqual("!H!! H!!", ReplaceAllVowelToExclamationMarkTask.Replace("!Hi! Hi!"));
                    Assert.AreEqual("!!!!!", ReplaceAllVowelToExclamationMarkTask.Replace("aeiou"));
                    Assert.AreEqual("!BCD!", ReplaceAllVowelToExclamationMarkTask.Replace("ABCDE"));
                }

                [Test]
                public void UEFAEUROTest()
                {
                    Assert.AreEqual("At match Germany - Ukraine, Germany won!", UEFAEUROTask.UefaEuro2016(new[] { "Germany", "Ukraine" }, new[] { 2, 0 }));
                    Assert.AreEqual("At match Belgium - Italy, Italy won!", UEFAEUROTask.UefaEuro2016(new[] { "Belgium", "Italy" }, new[] { 0, 2 }));
                    Assert.AreEqual("At match Portugal - Iceland, teams played draw.", UEFAEUROTask.UefaEuro2016(new[] { "Portugal", "Iceland" }, new[] { 1, 1 }));
                }

                [Test, Sequential]
                public void IsDigitOrNoTest()
                {
                    Assert.AreEqual(true, IsDigitOrNoTask.IsDigit("3"));
                    Assert.AreEqual(true, IsDigitOrNoTask.IsDigit("-3.23"));
                    Assert.AreEqual(false, IsDigitOrNoTask.IsDigit("3 5"));
                    Assert.AreEqual(false, IsDigitOrNoTask.IsDigit("zero"));
                }

                [Test]
                public void SleighAuthenticationTest()
                {
                    Assert.That(SleighAuthenticationTask.Authenticate("Santa Claus", "Ho Ho Ho!"));
                    Assert.That(!SleighAuthenticationTask.Authenticate("Santa", "Ho Ho Ho!"));
                    Assert.That(!SleighAuthenticationTask.Authenticate("Santa Claus", "Ho Ho!"));
                    Assert.That(!SleighAuthenticationTask.Authenticate("jhoffner", "CodeWars"));
                }


                [Test]
                public void GrasshopperCombineStringsTest()
                {
                    Assert.AreEqual("James Stevens", GrasshopperCombineStringsTask.CombineNames("James", "Stevens"));
                }

                [Test]
                public void TemplateStringsTest()
                {
                    Assert.AreEqual("Animals are Good", TemplateStringsTask.TempleStrings("Animals", "Good"));
                }

                [Test]
                public void FindTheRemainderTest()
                {
                    Assert.AreEqual(2, FindTheRemainderTask.Remainder(17, 5));
                    Assert.Throws<DivideByZeroException>(() => FindTheRemainderTask.Remainder(0, 1));
                    Assert.Throws<DivideByZeroException>(() => FindTheRemainderTask.Remainder(0, 0));
                }

                [Test]
                public static void NoZerosForHerosTest()
                {
                    Assert.AreEqual(145, NoZerosForHerosTask.NoBoringZeros(1450));
                    Assert.AreEqual(96, NoZerosForHerosTask.NoBoringZeros(960000));
                    Assert.AreEqual(105, NoZerosForHerosTask.NoBoringZeros(1050));
                    Assert.AreEqual(-105, NoZerosForHerosTask.NoBoringZeros(-1050));
                    Assert.AreEqual(-255, NoZerosForHerosTask.NoBoringZeros(-2550000));

                }

                [Test]
                public void FindNearestSquareNumberTest()
                {
                    Assert.That(FindNearestSquareNumberTask.NearestSq(2), Is.EqualTo(1));
                    Assert.That(FindNearestSquareNumberTask.NearestSq(10), Is.EqualTo(9));
                    Assert.That(FindNearestSquareNumberTask.NearestSq(111), Is.EqualTo(121));
                    Assert.That(FindNearestSquareNumberTask.NearestSq(9999), Is.EqualTo(10000));
                }

                [Test]
                public void LeonardDicaprioAndOscarsTest()
                {
                    Assert.AreEqual("Leo finally won the oscar! Leo is happy", LeonardDicaprioAndOscarsTask.Leo(88));
                    Assert.AreEqual("Leo got one already!", LeonardDicaprioAndOscarsTask.Leo(90));
                    Assert.AreEqual("Not even for Wolf of wallstreet?!", LeonardDicaprioAndOscarsTask.Leo(86));
                    Assert.AreEqual("When will you give Leo an Oscar?", LeonardDicaprioAndOscarsTask.Leo(78));

                }

                [Test]
                public void GetNumberFromStringTest()
                {
                    Assert.AreEqual(1, GetNumberFromStringTask.GetNumberFromString("1"));
                    Assert.AreEqual(123, GetNumberFromStringTask.GetNumberFromString("123"));
                    Assert.AreEqual(7, GetNumberFromStringTask.GetNumberFromString("this is number: 7"));
                }

                [Test]
                public void RegexpBasicsIsItADigitTest()
                {
                    Assert.AreEqual(false, RegexpBasicsIsItADigitTask.Digit(""));
                    Assert.AreEqual(true, RegexpBasicsIsItADigitTask.Digit("7"));
                    Assert.AreEqual(false, RegexpBasicsIsItADigitTask.Digit(" "));
                    Assert.AreEqual(false, RegexpBasicsIsItADigitTask.Digit("a"));
                    Assert.AreEqual(false, RegexpBasicsIsItADigitTask.Digit("a5"));
                    Assert.AreEqual(false, RegexpBasicsIsItADigitTask.Digit("14"));
                }

                [Test]
                public void TipCalculatorTest()
                {
                    Assert.AreEqual(4, TipCalculatorTask.CalculateTip(20, "Excellent"));
                    Assert.AreEqual(3, TipCalculatorTask.CalculateTip(26.95, "good"));
                }
                [Test]
                public void ExclamationMarksSeries4Test()
                {
                    Assert.AreEqual("Hi!", ExclamationMarksSeries4Task.Remove("Hi!"));
                    Assert.AreEqual("Hi!", ExclamationMarksSeries4Task.Remove("Hi!!!"));
                    Assert.AreEqual("Hi!", ExclamationMarksSeries4Task.Remove("!Hi"));
                    Assert.AreEqual("Hi!", ExclamationMarksSeries4Task.Remove("!Hi!"));
                    Assert.AreEqual("Hi Hi!", ExclamationMarksSeries4Task.Remove("Hi! Hi!"));
                    Assert.AreEqual("Hi!", ExclamationMarksSeries4Task.Remove("Hi"));
                }

                [Test]
                public void IsThereAVowelInThereTest()
                {
                    Assert.AreEqual(new object[] { 118, "u", 120, 121, "u", 98, 122, "a", 120, 106, 104, 116, 113, 114, 113, 120, 106 }, IsThereAVowelInThereTask.IsVow(new object[] { 118, 117, 120, 121, 117, 98, 122, 97, 120, 106, 104, 116, 113, 114, 113, 120, 106 }));
                    Assert.AreEqual(new object[] { "e", 121, 110, 113, 113, 103, 121, 121, "e", 107, 103 }, IsThereAVowelInThereTask.IsVow(new object[] { 101, 121, 110, 113, 113, 103, 121, 121, 101, 107, 103 }));
                }
                [Test]
				public void SumOfMultiplesTest()
				{
					Assert.AreEqual(20, SumOfMultiplesTask.SumMul(2, 9), "n = 2, m = 9");
					Assert.AreEqual(30, SumOfMultiplesTask.SumMul(5, 20), "n = 5, m = 20");
					Assert.AreEqual(1860, SumOfMultiplesTask.SumMul(4, 123), "n = 4, m = 123");
					Assert.AreEqual(86469, SumOfMultiplesTask.SumMul(123, 4567), "n = 123, m = 4567");
					Assert.Throws<ArgumentException>(() => SumOfMultiplesTask.SumMul(4, 1), "n = 4, m = 1");
					Assert.Throws<ArgumentException>(() => SumOfMultiplesTask.SumMul(0, 20), "n = 0, m = 20");
				}

				[Test]
				public void SurfaceAreaAndVolumeOfABoxTest()
				{
					Assert.AreEqual(new[] { 88, 48 }, SurfaceAreaAndVolumeOfABoxTask.Get_size(4, 2, 6));
					Assert.AreEqual(new[] { 6, 1 }, SurfaceAreaAndVolumeOfABoxTask.Get_size(1, 1, 1));
					Assert.AreEqual(new[] { 10, 2 }, SurfaceAreaAndVolumeOfABoxTask.Get_size(1, 2, 1));
					Assert.AreEqual(new[] { 16, 4 }, SurfaceAreaAndVolumeOfABoxTask.Get_size(1, 2, 2));
					Assert.AreEqual(new[] { 600, 1000 }, SurfaceAreaAndVolumeOfABoxTask.Get_size(10, 10, 10));
				}
				[Test]
				public void ExclamationMarksSeriesSixTest()
				{
					Assert.AreEqual("Hi", ExclamationMarksSeriesSixTask.Remove("Hi!", 1));
					Assert.AreEqual("Hi", ExclamationMarksSeriesSixTask.Remove("Hi!", 100));
					Assert.AreEqual("Hi!!", ExclamationMarksSeriesSixTask.Remove("Hi!!!", 1));
					Assert.AreEqual("Hi", ExclamationMarksSeriesSixTask.Remove("Hi!!!", 100));
					Assert.AreEqual("Hi", ExclamationMarksSeriesSixTask.Remove("!Hi", 1));
					Assert.AreEqual("Hi!", ExclamationMarksSeriesSixTask.Remove("!Hi!", 1));
					Assert.AreEqual("Hi", ExclamationMarksSeriesSixTask.Remove("!Hi!", 100));
					Assert.AreEqual("!!Hi !!hi!!! !hi", ExclamationMarksSeriesSixTask.Remove("!!!Hi !!hi!!! !hi", 1));
					Assert.AreEqual("Hi !!hi!!! !hi", ExclamationMarksSeriesSixTask.Remove("!!!Hi !!hi!!! !hi", 3));
					Assert.AreEqual("Hi hi!!! !hi", ExclamationMarksSeriesSixTask.Remove("!!!Hi !!hi!!! !hi", 5));
					Assert.AreEqual("Hi hi hi", ExclamationMarksSeriesSixTask.Remove("!!!Hi !!hi!!! !hi", 100));
				}

				[Test]
                public void Contamination1StringTest()
                {
                    Assert.AreEqual("zzz", Contamination1StringTask.Contamination("abc", "z"));
                    Assert.AreEqual("", Contamination1StringTask.Contamination("", "z"));
                    Assert.AreEqual("&&&&&&&&", Contamination1StringTask.Contamination("_3ebzgh4", "&"));
                    Assert.AreEqual("      ", Contamination1StringTask.Contamination("//case", " "));
                }

                [Test]
                public void TheIfFunctionTest()
                {
                    var a = false;

                    TheIfFunctionTask.If(true, () => a = true, () => a = false);

                    Assert.True(a, "func1 should be called");
                }

                [Test]
                public void RemoveAllExclamationMarksFromTheEndTest()
                {
                    Assert.AreEqual("Hi", RemoveAllExclamationMarksFromTheEndTask.Remove("Hi!"));
                    Assert.AreEqual("Hi", RemoveAllExclamationMarksFromTheEndTask.Remove("Hi!!!"));
                    Assert.AreEqual("!Hi", RemoveAllExclamationMarksFromTheEndTask.Remove("!Hi"));
                    Assert.AreEqual("!Hi", RemoveAllExclamationMarksFromTheEndTask.Remove("!Hi!"));
                    Assert.AreEqual("Hi! Hi", RemoveAllExclamationMarksFromTheEndTask.Remove("Hi! Hi"));
                    Assert.AreEqual("Hi", RemoveAllExclamationMarksFromTheEndTask.Remove("Hi"));
                }

                [Test]
                public void TakeTheFirstNElementsTest()
                {
                    Assert.AreEqual(new int[] { 0, 1, 2 }, TakeTheFirstNElementsTask.Take(new int[] { 0, 1, 2, 3, 5, 8, 13 }, 3));
                    Assert.AreEqual(new int[] { }, TakeTheFirstNElementsTask.Take(new int[] { 0, 1, 2, 3, 5, 8, 13 }, 0));
                    Assert.AreEqual(new int[] { }, TakeTheFirstNElementsTask.Take(new int[] { }, 3));
                }
                [Test]
                public void SimpleCalculatorTest()
                {
                    Assert.AreEqual(8, SimpleCalculatorTask.Calculator(6, 2, '+'));
                    Assert.AreEqual(1, SimpleCalculatorTask.Calculator(4, 3, '-'));
                    Assert.AreEqual(25, SimpleCalculatorTask.Calculator(5, 5, '*'));
                    Assert.AreEqual(1.25, SimpleCalculatorTask.Calculator(5, 4, '/'));
                    Assert.Throws<ArgumentException>(() => SimpleCalculatorTask.Calculator(6, 2, '&'));
                }


                [Test]
                public void ReturnTheDayTest()
                {
                    Assert.AreEqual("Sunday", ReturnTheDayTask.WhatDay(1));
                    Assert.AreEqual("Monday", ReturnTheDayTask.WhatDay(2));
                    Assert.AreEqual("Tuesday", ReturnTheDayTask.WhatDay(3));
                    Assert.AreEqual("Wednesday", ReturnTheDayTask.WhatDay(4));
                    Assert.AreEqual("Thursday", ReturnTheDayTask.WhatDay(5));
                    Assert.AreEqual("Friday", ReturnTheDayTask.WhatDay(6));
                    Assert.AreEqual("Saturday", ReturnTheDayTask.WhatDay(7));
                    Assert.AreEqual("Wrong, please enter a number between 1 and 7", ReturnTheDayTask.WhatDay(-7));
                }

                [Test]
                public void DoYouSpeakEnglishTest()
                {
                    Assert.AreEqual(false, DoYouSpeakEnglishTask.SpeakEnglish("hello world"));
                    Assert.AreEqual(false, DoYouSpeakEnglishTask.SpeakEnglish("egnlish"));
                    Assert.AreEqual(false, DoYouSpeakEnglishTask.SpeakEnglish(""));
                    Assert.AreEqual(true, DoYouSpeakEnglishTask.SpeakEnglish("english"));
                    Assert.AreEqual(true, DoYouSpeakEnglishTask.SpeakEnglish("eNgliSh"));
                    Assert.AreEqual(true, DoYouSpeakEnglishTask.SpeakEnglish("1234#$%%eNglish ;k9"));

                }

                [Test]
                public void FundamentalsReturnTest()
                {
                    Assert.AreEqual(12, FundamentalsReturnTask.Add(5, 7));
                    Assert.AreEqual(10, FundamentalsReturnTask.Multiply(5, 2));
                    Assert.AreEqual(5, FundamentalsReturnTask.Divide(10, 2));
                    Assert.AreEqual(4, FundamentalsReturnTask.Exponent(2, 2));
                    Assert.AreEqual(3, FundamentalsReturnTask.Subt(5, 2));
                    Assert.AreEqual(0, FundamentalsReturnTask.Mod(2, 2));
;
                }


                [Test]
                public void IncludeTest()
                {
                    Assert.AreEqual(true, IncludeTask.Include(new int[] { 1, 2, 3, 4 }, 3));
                    Assert.AreEqual(false, IncludeTask.Include(new int[] { 1, 2, 4, 5 }, 3));
                }
                [Test]
                public void DefineACardSuitTest()
                {
                    Assert.AreEqual("clubs", DefineACardSuitTask.DefineSuit("3♣"));
                    Assert.AreEqual("spades", DefineACardSuitTask.DefineSuit("Q♠"));
                    Assert.AreEqual("diamonds", DefineACardSuitTask.DefineSuit("9♦"));
                    Assert.AreEqual("hearts", DefineACardSuitTask.DefineSuit("J♥"));
                }
                [Test]
                public void HexToDecTest()
                {
                    Assert.AreEqual(1, HexToDecimalTask.HexToDec("1"));
                    Assert.AreEqual(10, HexToDecimalTask.HexToDec("a"));
                    Assert.AreEqual(16, HexToDecimalTask.HexToDec("10"));
                    Assert.AreEqual(255, HexToDecimalTask.HexToDec("FF"));
                    Assert.AreEqual(-12, HexToDecimalTask.HexToDec("-C"));
                }

                [Test]
                public static void HowManyLightsabersDoYouOwnTest()
                {
                    Assert.AreEqual(18, HowManyLightsabersDoYouOwnTask.HowManyLightsabersDoYouOwn("Zach"));
                    Assert.AreEqual(0, HowManyLightsabersDoYouOwnTask.HowManyLightsabersDoYouOwn("Adam"));
                    Assert.AreEqual(0, HowManyLightsabersDoYouOwnTask.HowManyLightsabersDoYouOwn("John"));
                }
                [Test]
                public void RegexCountLowercaseLettersTest()
                {
                    Assert.AreEqual(3, RegexCountLowercaseLettersTask.LowercaseCountCheck("abc"));
                    Assert.AreEqual(3, RegexCountLowercaseLettersTask.LowercaseCountCheck("abcABC123"));
                    Assert.AreEqual(3, RegexCountLowercaseLettersTask.LowercaseCountCheck("abcABC123!@€£#$%^&*()_-+=}{[]|':;?/>.<,~"));
                    Assert.AreEqual(0, RegexCountLowercaseLettersTask.LowercaseCountCheck("ABC123!@€£#$%^&*()_-+=}{[]|':;?/>.<,~"));
                    Assert.AreEqual(26, RegexCountLowercaseLettersTask.LowercaseCountCheck("abcdefghijklmnopqrstuvwxyz"));
                }

                [Test]
                public void SimpleValidationOfAUsernameWithRegexTest()
                {
                    Assert.AreEqual(true, SimpleValidationOfAUsernameWithRegexTask.ValidateUsr("asddsa"));
                    Assert.AreEqual(false, SimpleValidationOfAUsernameWithRegexTask.ValidateUsr("a"));
                    Assert.AreEqual(false, SimpleValidationOfAUsernameWithRegexTask.ValidateUsr("Hasd_12ssssssssssssssasasasasasssasassss"));
                    Assert.AreEqual(false, SimpleValidationOfAUsernameWithRegexTask.ValidateUsr("Haas"));
                    Assert.AreEqual(false, SimpleValidationOfAUsernameWithRegexTask.ValidateUsr(""));
                    Assert.AreEqual(true, SimpleValidationOfAUsernameWithRegexTask.ValidateUsr("____"));
                    Assert.AreEqual(false, SimpleValidationOfAUsernameWithRegexTask.ValidateUsr("asd43 34"));
                    Assert.AreEqual(true, SimpleValidationOfAUsernameWithRegexTask.ValidateUsr("asd43_34"));
                }

                [Test]
                public void GetCharacterFromASCIIValueTest()
                {
                    Assert.AreEqual('7', GetCharacterFromASCIIValueTask.GetChar(55));
                    Assert.AreEqual('8', GetCharacterFromASCIIValueTask.GetChar(56));
                    Assert.AreEqual('A', GetCharacterFromASCIIValueTask.GetChar(65));
                    Assert.AreEqual('@', GetCharacterFromASCIIValueTask.GetChar(64));
                }

                [Test]
                public void SquaringAnArgumentTest()
                {
                    Assert.AreEqual(4, SquaringAnArgumentTask.Square(2));
                    Assert.AreEqual(100, SquaringAnArgumentTask.Square(10));
                }
                [Test]
                public void USDToCNYTest()
                {
                    Assert.AreEqual("101,25 Chinese Yuan", USDToCNYTask.Usdcny(15));
                    Assert.AreEqual("3138,75 Chinese Yuan", USDToCNYTask.Usdcny(465));
                }

                [Test]
                public void WhatIsTheRealFloorTest()
                {
                    Assert.AreEqual(0, WhatIsTheRealFloorTask.GetRealFloor(1));
                    Assert.AreEqual(4, WhatIsTheRealFloorTask.GetRealFloor(5));
                    Assert.AreEqual(13, WhatIsTheRealFloorTask.GetRealFloor(15));
                    Assert.AreEqual(-5, WhatIsTheRealFloorTask.GetRealFloor(-5));
                }

                [Test]
                public void ReverseListOrderTest()
                {
                    Assert.AreEqual(new List<int> { 1, 2, 3, 4 }, ReverseListOrderTask.ReverseList(new List<int> { 4, 3, 2, 1 }));
                    Assert.AreEqual(new List<int> { 3, 1, 5, 4 }, ReverseListOrderTask.ReverseList(new List<int> { 4, 5, 1, 3 }));
                    Assert.AreEqual(new List<int> { 3, 6, 9, 2 }, ReverseListOrderTask.ReverseList(new List<int> { 2, 9, 6, 3 }));

                }

                [Test]
                public void FirstNonConsecutiveTest()
                {
                    Assert.AreEqual(6, FirstNonConsecutiveTask.FirstNonConsecutive(new int[] { 1, 2, 3, 4, 6, 7, 8 }));
                    Assert.AreEqual(null, FirstNonConsecutiveTask.FirstNonConsecutive(new int[] { 1, 2, 3, 4 }));

                }

                [Test]
                public void IfElseAndTernaryOperatorTest()
                {
                    Assert.AreEqual(100, IfElseAndTernaryOperatorTask.SaleHotDogs(1));
                    Assert.AreEqual(400, IfElseAndTernaryOperatorTask.SaleHotDogs(4));
                    Assert.AreEqual(475, IfElseAndTernaryOperatorTask.SaleHotDogs(5));
                    Assert.AreEqual(855, IfElseAndTernaryOperatorTask.SaleHotDogs(9));
                    Assert.AreEqual(900, IfElseAndTernaryOperatorTask.SaleHotDogs(10));
                    Assert.AreEqual(9000, IfElseAndTernaryOperatorTask.SaleHotDogs(100));
                }
                [Test]
                public void ALTerNAtiNGCaSeTest()
                {
                    Assert.AreEqual("HELLO WORLD", ALTerNAtiNGCaSeTask.ToAlternatingCase("hello world"));
                    Assert.AreEqual("hello world", ALTerNAtiNGCaSeTask.ToAlternatingCase("HELLO WORLD"));
                    Assert.AreEqual("HELLO world", ALTerNAtiNGCaSeTask.ToAlternatingCase("hello WORLD"));
                    Assert.AreEqual("HELLO WORLD", ALTerNAtiNGCaSeTask.ToAlternatingCase("hello world"));
                    Assert.AreEqual("12345", ALTerNAtiNGCaSeTask.ToAlternatingCase("12345"));
                    Assert.AreEqual("1A2B3C4D5E", ALTerNAtiNGCaSeTask.ToAlternatingCase("1a2b3c4d5e"));
                    
                }

                [Test]
                public void BartenderDrinksTest()
                {
                    Assert.AreEqual("Patron Tequila", BartenderDrinksTask.GetDrinkByProfession("jabrOni"), "'Jabroni' should map to 'Patron Tequila'");
                    Assert.AreEqual("Anything with Alcohol", BartenderDrinksTask.GetDrinkByProfession("scHOOl counselor"), "'School Counselor' should map to 'Anything with alcohol'");
                    Assert.AreEqual("Hipster Craft Beer", BartenderDrinksTask.GetDrinkByProfession("prOgramMer"), "'Programmer' should map to 'Hipster Craft Beer'");
                    Assert.AreEqual("Moonshine", BartenderDrinksTask.GetDrinkByProfession("bike ganG member"), "'Bike Gang Member' should map to 'Moonshine'");
                    Assert.AreEqual("Your tax dollars", BartenderDrinksTask.GetDrinkByProfession("poLiTiCian"), "'Politician' should map to 'Your tax dollars'");
                    Assert.AreEqual("Cristal", BartenderDrinksTask.GetDrinkByProfession("rapper"), "'Rapper' should map to 'Cristal'");
                    Assert.AreEqual("Beer", BartenderDrinksTask.GetDrinkByProfession("pundit"), "'Pundit' should map to 'Beer'");
                    Assert.AreEqual("Beer", BartenderDrinksTask.GetDrinkByProfession("Pug"), "'Pug' should map to 'Beer'");
                }

                [Test]
                public void NameShufflerTest()
                {
                    Assert.AreEqual("McClane john", NameShufflerTask.NameShuffler("john McClane"));
                    Assert.AreEqual("jeggins Mary", NameShufflerTask.NameShuffler("Mary jeggins"));
                    Assert.AreEqual("jerry tom", NameShufflerTask.NameShuffler("tom jerry"));
                }

                [Test]
                public void PillarsTest()
                {
                    Assert.AreEqual(2000, PillarsTask.Pillars(2, 20, 25));
                    Assert.AreEqual(15270, PillarsTask.Pillars(11, 15, 30));
                    Assert.AreEqual(0, PillarsTask.Pillars(1, 10, 10));
                }


                [Test]
                public void AppleTurnoverTest()
                {
                    Assert.AreEqual("It's hotter than the sun!!", AppleTurnoverTask.Apple("50"));
                    Assert.AreEqual("Help yourself to a honeycomb Yorkie for the glovebox.", AppleTurnoverTask.Apple(4));
                }

                [Test]
                public void HowOldWillIBeInTest()
                {
                    Assert.AreEqual("You are 17 years old.", HowOldWillIBeInTask.CalculateAge(2003, 2020));
                    Assert.AreEqual("You are 1 year old.", HowOldWillIBeInTask.CalculateAge(2019, 2020));
                    Assert.AreEqual("You were born this very year!", HowOldWillIBeInTask.CalculateAge(2003, 2003));
                    Assert.AreEqual("You will be born in 17 years.", HowOldWillIBeInTask.CalculateAge(2020, 2003));
                    Assert.AreEqual("You will be born in 1 year.", HowOldWillIBeInTask.CalculateAge(2020, 2019));
                }

                [Test]
                public void SortAndStarTest()
                {
                    Assert.AreEqual("b***i***t***c***o***i***n", SortAndStarTask.TwoSort(new[] { "bitcoin", "take", "over", "the", "world", "maybe", "who", "knows", "perhaps" }));
                    Assert.AreEqual("a***r***e", SortAndStarTask.TwoSort(new[] { "turns", "out", "random", "test", "cases", "are", "easier", "than", "writing", "out", "basic", "ones" }));
                }

                [Test]
                public void PriceOfMangoesTest()
                {
                    Assert.AreEqual(6, PriceOfMangoesTask.Mango(3, 3));
                    Assert.AreEqual(30, PriceOfMangoesTask.Mango(9, 5));
                }

                [Test]
                public void WelcomeToTheCityTest()
                {
                    Assert.AreEqual("Hello, John Smith! Welcome to Phoenix, Arizona!", WelcomeToTheCityTask.SayHello(new string[] { "John", "Smith" }, "Phoenix", "Arizona"));
                }

                [Test]
                public void RemoveFirstAndLastCharacterPartTwoTest()
                {
                    Assert.AreEqual(null, RemoveFirstAndLastCharacterPartTwoTask.Array(""));
                    Assert.AreEqual(null, RemoveFirstAndLastCharacterPartTwoTask.Array("1"));
                    Assert.AreEqual(null, RemoveFirstAndLastCharacterPartTwoTask.Array("1, 3"));
                    Assert.AreEqual("2", RemoveFirstAndLastCharacterPartTwoTask.Array("1,2,3"));
                    Assert.AreEqual("2 3", RemoveFirstAndLastCharacterPartTwoTask.Array("1,2,3,4"));
                }


                [Test]
                public void SumOfDifferencesInArrayTest()
                {
                    Assert.AreEqual(0, SumOfDifferencesInArrayTask.SumOfDifferences(new int[] { }));
                    Assert.AreEqual(0, SumOfDifferencesInArrayTask.SumOfDifferences(new int[] { 0 }));
                    Assert.AreEqual(0, SumOfDifferencesInArrayTask.SumOfDifferences(new int[] { 1 }));
                    Assert.AreEqual(0, SumOfDifferencesInArrayTask.SumOfDifferences(new int[] { -1 }));
                    Assert.AreEqual(34, SumOfDifferencesInArrayTask.SumOfDifferences(new int[] { -17, 17 }));
                    Assert.AreEqual(9, SumOfDifferencesInArrayTask.SumOfDifferences(new int[] { 2, 1, 10 }));
                    Assert.AreEqual(2, SumOfDifferencesInArrayTask.SumOfDifferences(new int[] { -3, -2, -1 }));
                    Assert.AreEqual(0, SumOfDifferencesInArrayTask.SumOfDifferences(new int[] { 1, 1, 1, 1, 1 }));
                    Assert.AreEqual(0, SumOfDifferencesInArrayTask.SumOfDifferences(new int[] { 0, 0, 0, 0, 0 }));
                    Assert.AreEqual(4, SumOfDifferencesInArrayTask.SumOfDifferences(new int[] { 1, 2, 3, 4, 5 }));
                    Assert.AreEqual(29, SumOfDifferencesInArrayTask.SumOfDifferences(new int[] { 0, 29, 24, 17 }));
                    Assert.AreEqual(50, SumOfDifferencesInArrayTask.SumOfDifferences(new int[] { 25, 24, -25, 2 }));
                    Assert.AreEqual(22, SumOfDifferencesInArrayTask.SumOfDifferences(new int[] { -26, -4, -8, -8 }));
                }

                [Test]
                public void IsCubeTest()
                {
                    Assert.AreEqual(true, IsCubeTask.IsCube(1, 1));
                    Assert.AreEqual(true, IsCubeTask.IsCube(8, 2));
                    Assert.AreEqual(false, IsCubeTask.IsCube(2, 1));
                    Assert.AreEqual(false, IsCubeTask.IsCube(6, 3));
                    Assert.AreEqual(false, IsCubeTask.IsCube(-8, -2));
                    Assert.AreEqual(false, IsCubeTask.IsCube(0, 0));
                    Assert.AreEqual(false, IsCubeTask.IsCube(200, 4));
                }
                [Test]
                public void FilterOutTheGeeseTest()
                {
                    Assert.AreEqual(new string[] { "Mallard", "Hook Bill", "Crested", "Blue Swedish" },
                        FilterOutTheGeeseTask.GooseFilter(new string[] { "Mallard", "Hook Bill", "African", "Crested", "Pilgrim", "Toulouse", "Blue Swedish" }));

                    Assert.AreEqual(new string[] { "Mallard", "Barbary", "Hook Bill", "Blue Swedish", "Crested" },
                        FilterOutTheGeeseTask.GooseFilter(new string[] { "Mallard", "Barbary", "Hook Bill", "Blue Swedish", "Crested" }));

                    Assert.AreEqual(new string[] { },
                        FilterOutTheGeeseTask.GooseFilter(new string[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" }));
                }

                [Test]
                public void PluralTest()
                {
                    Assert.AreEqual(true, PluralTask.Plural(0), "Plural for 0");
                    Assert.AreEqual(true, PluralTask.Plural(0.5), "Plural for 0.5");
                    Assert.AreEqual(false, PluralTask.Plural(1), "Plural for 1");
                    Assert.AreEqual(true, PluralTask.Plural(100), "Plural for 100");
                    Assert.AreEqual(true, PluralTask.Plural(double.PositiveInfinity), "Plural for Infinity");
                }

                [Test]
                public void HolidayVIIIDutyFreeTest()
                {
                    Assert.AreEqual(166, HolidayVIIIDutyFreeTask.DutyFree(12, 50, 1000));
                    Assert.AreEqual(294, HolidayVIIIDutyFreeTask.DutyFree(17, 10, 500));
                    Assert.AreEqual(357, HolidayVIIIDutyFreeTask.DutyFree(24, 35, 3000));
                }


                [Test]
                public void TakeTheDerivativeTest()
                {
                    Assert.AreEqual("56x^7", TakeTheDerivativeTask.Derive(7, 8));
                    Assert.AreEqual("45x^8", TakeTheDerivativeTask.Derive(5, 9));

                }

                [Test]
                public void ReversingWordsInAStringTest()
                {
                    Assert.AreEqual("World Hello", ReversingWordsInAStringTask.Reverse("Hello World"));
                    Assert.AreEqual("There. Hi", ReversingWordsInAStringTask.Reverse("Hi There."));
                    Assert.AreEqual("this at expert an am I", ReversingWordsInAStringTask.Reverse("I am an expert at this"));
                }

                [Test]
                public void ConvertNumberToReversedArrayOfDigitsTest()
                {
                    Assert.AreEqual(new long[] { 1, 3, 2, 5, 3 }, ConvertNumberToReversedArrayOfDigitsTask.Digitize(35231));
                    Assert.AreEqual(new long[] { 0 }, ConvertNumberToReversedArrayOfDigitsTask.Digitize(0));
                }

                [Test]
                public void StringCleaningTest()
                {
                    Assert.AreEqual("", StringCleaningTask.StringClean(""));
                    Assert.AreEqual("! !", StringCleaningTask.StringClean("! !"));
                    Assert.AreEqual("", StringCleaningTask.StringClean("1234567890"));
                    Assert.AreEqual("Dsa cdsc csa!!! I Am cool!", StringCleaningTask.StringClean("Dsa32 cdsc34232 csa!!! 1I 4Am cool!"));
                    Assert.AreEqual("A A! AAA   JKL@!!!", StringCleaningTask.StringClean("A1 A1! AAA   3J4K5L@!!!"));
                    Assert.AreEqual("Adgre Asad! AAA fvfdvJKL@", StringCleaningTask.StringClean("Adgre2321 A1sad! A2A3A4 fv3fdv3J544K5L@"));
                    Assert.AreEqual("Addsadds A  $$sad! AAAe fKL@ ", StringCleaningTask.StringClean("Ad2dsad3ds21 A  1$$s122ad! A2A3Ae24 f44K5L@222222 "));
                    Assert.AreEqual("Addsadds A  $$sa!d! A!A!Ae$ f## ", StringCleaningTask.StringClean("33333Ad2dsad3ds21 A3333  1$$s122a!d! A2!A!3Ae$24 f2##222 "));
                    Assert.AreEqual("My \"messy\" data issues! Will they ever, ever be solved?", StringCleaningTask.StringClean("My \"me3ssy\" d8ata issues2! Will1 th4ey ever, e3ver be3 so0lved?"));
                    Assert.AreEqual("Why can't we buy the good software? #cheapskates", StringCleaningTask.StringClean("Wh7y can't we3 bu1y the goo0d software3? #cheapskates3"));
                }

                [Test]
                public void ArrayMeanTest()
                {
                    Assert.AreEqual(1, ArrayMeanTask.FindAverage(new[] { 1 }));
                    Assert.AreEqual(4, ArrayMeanTask.FindAverage(new[] { 1, 3, 5, 7 }));
                    Assert.AreEqual(-5, ArrayMeanTask.FindAverage(new[] { -10, -5, -5, 0 }));
                    Assert.AreEqual(0, ArrayMeanTask.FindAverage(new[] { 0 }));

                }

                [Test]
                public void HelloNameOrWorldTest()
                {
                    Assert.AreEqual("Hello, Jeff!", HelloNameOrWorldTask.Hello("jEFF"));
                    Assert.AreEqual("Hello, Tony!", HelloNameOrWorldTask.Hello("tonY"));
                    Assert.AreEqual("Hello, Alicia!", HelloNameOrWorldTask.Hello("Alicia"));
                    Assert.AreEqual("Hello, Vasya!", HelloNameOrWorldTask.Hello("vasya"));
                    Assert.AreEqual("Hello, John!", HelloNameOrWorldTask.Hello("JOHN"));
                    Assert.AreEqual("Hello, World!", HelloNameOrWorldTask.Hello(""));
                    Assert.AreEqual("Hello, World!", HelloNameOrWorldTask.Hello(null));
                }


                [Test]
                public void BasicFunctionFixerTest()
                {
                    Assert.AreEqual(10, BasicFunctionFixerTask.AddFive(5));
                    Assert.AreEqual(15, BasicFunctionFixerTask.AddFive(10));
                    Assert.AreEqual(30, BasicFunctionFixerTask.AddFive(25));
                    Assert.AreEqual(88, BasicFunctionFixerTask.AddFive(83));

                }

                [Test]
                public void VowelRemoverTest()
                {
                    Assert.AreEqual("hll", VowelRemoverTask.Shortcut("hello"));
                    Assert.AreEqual("hw r y tdy?", VowelRemoverTask.Shortcut("how are you today?"));
                    Assert.AreEqual("cmpln", VowelRemoverTask.Shortcut("complain"));
                    Assert.AreEqual("nvr", VowelRemoverTask.Shortcut("never"));

                }

                [Test]
                public void JustCountSheepTest()
                {
                    Assert.That(JustCountSheepTask.CountSheep(0), Is.EqualTo(""));
                    Assert.That(JustCountSheepTask.CountSheep(1), Is.EqualTo("1 sheep..."));
                    Assert.That(JustCountSheepTask.CountSheep(2), Is.EqualTo("1 sheep...2 sheep..."));
                    Assert.That(JustCountSheepTask.CountSheep(3), Is.EqualTo("1 sheep...2 sheep...3 sheep..."));
                }
                [Test]
                public void WhatIsBetweenTest()
                {
                    Assert.AreEqual(new int[] { 0, 1, 2, 3 }, WhatIsBetweenTask.Between(0, 3));
                    Assert.AreEqual(new int[] { -2, -1, 0, 1, 2 }, WhatIsBetweenTask.Between(-2, 2));
                    Assert.AreEqual(new int[] { -10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, WhatIsBetweenTask.Between(-10, 10));
                }


                [Test]
                public void PowersOfTwoTest()
                {
                    Assert.AreEqual(new BigInteger[] { 1 }, PowersOfTwoTask.PowersOfTwo(0));
                    Assert.AreEqual(new BigInteger[] { 1, 2 }, PowersOfTwoTask.PowersOfTwo(1));
                    Assert.AreEqual(new BigInteger[] { 1, 2, 4, 8, 16 }, PowersOfTwoTask.PowersOfTwo(4));
                }


                [Test]
                public void ConvertAStringToANumberTest()
                {
                    Assert.AreEqual(1234, ConvertAStringToANumberTask.StringToNumber("1234"));
                    Assert.AreEqual(605, ConvertAStringToANumberTask.StringToNumber("605"));
                    Assert.AreEqual(1405, ConvertAStringToANumberTask.StringToNumber("1405"));
                    Assert.AreEqual(-7, ConvertAStringToANumberTask.StringToNumber("-7"));
                }

                [Test]
                public void XXAndXYChromosomesTest()
                {
                    Assert.AreEqual("Congratulations! You're going to have a son.", XXAndXYChromosomesTask.ChromosomeCheck("XY"));
                    Assert.AreEqual("Congratulations! You're going to have a daughter.", XXAndXYChromosomesTask.ChromosomeCheck("XX"));
                }

                [Test]
                public void AddLengthTest()
                {
                    Assert.AreEqual(new string[] { "apple 5", "ban 3" }, AddLengthTask.AddLength("apple ban"));
                    Assert.AreEqual(new string[] { "you 3", "will 4", "win 3" }, AddLengthTask.AddLength("you will win"));
                }

                [Test]
                public void MultiplicationTableTest()
                {
                    string one = "1 * 1 = 1\n2 * 1 = 2\n3 * 1 = 3\n4 * 1 = 4\n5 * 1 = 5\n6 * 1 = 6\n7 * 1 = 7\n8 * 1 = 8\n9 * 1 = 9\n10 * 1 = 10";
                    Assert.AreEqual(one, MultiplicationTableTask.MultiTable(1));

                    string five = "1 * 5 = 5\n2 * 5 = 10\n3 * 5 = 15\n4 * 5 = 20\n5 * 5 = 25\n6 * 5 = 30\n7 * 5 = 35\n8 * 5 = 40\n9 * 5 = 45\n10 * 5 = 50";
                    Assert.AreEqual(five, MultiplicationTableTask.MultiTable(5));
                }
                [Test]
                public void CockroachTest()
                {
                    Assert.AreEqual(30, CockroachTask.CockroachSpeed(1.08));
                    Assert.AreEqual(30, CockroachTask.CockroachSpeed(1.09));
                    Assert.AreEqual(0, CockroachTask.CockroachSpeed(0));
                }


                [Test]
                public static void CheckForFactorTest()
                {
                    Assert.AreEqual(true, CheckForFactorTask.CheckForFactor(10, 2));
                    Assert.AreEqual(true, CheckForFactorTask.CheckForFactor(63, 7));
                    Assert.AreEqual(true, CheckForFactorTask.CheckForFactor(2450, 5));
                    Assert.AreEqual(false, CheckForFactorTask.CheckForFactor(653, 7));
                    Assert.AreEqual(false, CheckForFactorTask.CheckForFactor(9, 2));
                    Assert.AreEqual(false, CheckForFactorTask.CheckForFactor(24617, 3));
                }

                [Test]
                public void LoveDetectorTest()
                {
                    Assert.AreEqual(false, LoveDetectorTask.Lovefunc(2, 2));
                    Assert.AreEqual(true, LoveDetectorTask.Lovefunc(1, 4));
                    Assert.AreEqual(false, LoveDetectorTask.Lovefunc(0, 0));
                    Assert.AreEqual(true, LoveDetectorTask.Lovefunc(0, 1));
                }


                [Test]
                public void DifferenceOfVolumesOfCuboidsTest()
                {
                    Assert.AreEqual(14, DifferenceOfVolumesOfCuboidsTask.FindDifference(new int[] { 3, 2, 5 }, new int[] { 1, 4, 4 } ));
                    Assert.AreEqual(106, DifferenceOfVolumesOfCuboidsTask.FindDifference(new int[] { 9, 7, 2 }, new int[] { 5, 2, 2 }));
                    Assert.AreEqual(30, DifferenceOfVolumesOfCuboidsTask.FindDifference(new int[] { 11, 2, 5 }, new int[] { 1, 10, 8 } ));
                }


                [Test]
                public void PersonalizedMessageTest()
                {
                    Assert.AreEqual("Hello boss", PersonalizedMessageTask.Greet("Daniel", "Daniel"));
                    Assert.AreEqual("Hello guest", PersonalizedMessageTask.Greet("Greg", "Daniel"));
                }

                [Test]
                public void EvenOrOddTest()
                {
                    Assert.AreEqual("Even", EvenOrOddTask.EvenOrOdd(0));
                    Assert.AreEqual("Odd", EvenOrOddTask.EvenOrOdd(5));
                    Assert.AreEqual("Even", EvenOrOddTask.EvenOrOdd(8));
                    Assert.AreEqual("Odd", EvenOrOddTask.EvenOrOdd(3));
                }


                [Test]
                public static void AreYouPlayingBanjoTest()
                {
                    Assert.AreEqual("Martin does not play banjo", AreYouPlayingBanjoTask.AreYouPlayingBanjo("Martin"));
                    Assert.AreEqual("Rikke plays banjo", AreYouPlayingBanjoTask.AreYouPlayingBanjo("Rikke"));
                    Assert.AreEqual("rolf plays banjo", AreYouPlayingBanjoTask.AreYouPlayingBanjo("rolf"));
                    Assert.AreEqual("bravo does not play banjo", AreYouPlayingBanjoTask.AreYouPlayingBanjo("bravo"));
                }

                [Test]
                public static void CenturyFromYearTest()
                {
                    Assert.AreEqual(18, CenturyYearTask.СenturyYear(1701));
                    Assert.AreEqual(19, CenturyYearTask.СenturyYear(1900));
                    Assert.AreEqual(17, CenturyYearTask.СenturyYear(1601));
                    Assert.AreEqual(20, CenturyYearTask.СenturyYear(2000));
                }

                [Test]
                public static void TerminalGameCombatFunctionTest()
                {
                    Assert.AreEqual(95, TerminalGameCombatFunctionTask.Combat(100, 5));
                    Assert.AreEqual(84, TerminalGameCombatFunctionTask.Combat(92, 8));
                    Assert.AreEqual(0, TerminalGameCombatFunctionTask.Combat(20, 30));
                }

                [Test]
                public static void KeepHydratedTest()
                {
                    Assert.AreEqual(6, KeepHydratedTask.Litres(12.3));
                    Assert.AreEqual(0, KeepHydratedTask.Litres(1.4));
                    Assert.AreEqual(1, KeepHydratedTask.Litres(2));
                    Assert.AreEqual(0, KeepHydratedTask.Litres(0.82));
                    Assert.AreEqual(893, KeepHydratedTask.Litres(1787));
                    Assert.AreEqual(5, KeepHydratedTask.Litres(11.8));
                    Assert.AreEqual(0, KeepHydratedTask.Litres(0));
                }

                [Test]
                public void WideMouthedFrogTest()
                {
                    Assert.AreEqual("wide", WideMouthedFrogTask.MouthSize("toucan"));
                    Assert.AreEqual("wide", WideMouthedFrogTask.MouthSize("ant bear"));
                    Assert.AreEqual("small", WideMouthedFrogTask.MouthSize("alligator"));
                }

                [Test]
                public static void RemoveAllExclamationMarksTest()
                {
                    Assert.AreEqual("", RemoveAllExclamationMarksTask.RemoveExclamationMarks(""), "Input: Empty string");
                    Assert.AreEqual("", RemoveAllExclamationMarksTask.RemoveExclamationMarks("!"), "Input: " + "!");
                    Assert.AreEqual("", RemoveAllExclamationMarksTask.RemoveExclamationMarks("!!"), "Input: " + "!!");
                    Assert.AreEqual("Hi", RemoveAllExclamationMarksTask.RemoveExclamationMarks("Hi!"), "Input: " + "Hi!");
                    Assert.AreEqual("?", RemoveAllExclamationMarksTask.RemoveExclamationMarks("!?!"), "Input: " + "!?!");
                }

                [Test]
                public void TerminalGameMoveFunctionTest()
                {
                    Assert.That(TerminalGameMoveFunctionTask.Move(0, 4), Is.EqualTo(8));
                }

                [Test]
                public void FiveWithoutNumbersTest()
                {
                    Assert.That(FiveWithoutNumbersTask.UnusualFive(), Is.EqualTo(5));
                }
                [Test]
                public void FindMultiplesOfANumberTest()
                {
                    Assert.AreEqual(new List<int> { 5, 10, 15, 20, 25 }, FindMultiplesOfANumberTask.FindMultiples(5, 25));
                    Assert.AreEqual(new List<int> { 1, 2 }, FindMultiplesOfANumberTask.FindMultiples(1, 2));
                }

                [Test]
                public void RemoveAnExclamationTest()
                {
                    Assert.AreEqual("Hi", RemoveAnExclamationTask.Remove("Hi!"));
                    Assert.AreEqual("Hi!!", RemoveAnExclamationTask.Remove("Hi!!!"));
                    Assert.AreEqual("!Hi", RemoveAnExclamationTask.Remove("!Hi"));
                    Assert.AreEqual("!Hi", RemoveAnExclamationTask.Remove("!Hi!"));
                    Assert.AreEqual("Hi! Hi", RemoveAnExclamationTask.Remove("Hi! Hi"));
                    Assert.AreEqual("Hi", RemoveAnExclamationTask.Remove("Hi"));
                }

                [Test]
                public void BasicMathematicalOperationsTest()
                {
                    Assert.AreEqual(11, BasicMathematicalOperationsTask.basicOp('+', 4, 7));
                    Assert.AreEqual(-3, BasicMathematicalOperationsTask.basicOp('-', 15, 18));
                    Assert.AreEqual(25, BasicMathematicalOperationsTask.basicOp('*', 5, 5));
                    Assert.AreEqual(7, BasicMathematicalOperationsTask.basicOp('/', 49, 7));
                    Assert.AreEqual(0, BasicMathematicalOperationsTask.basicOp('x', 55, 7));
                }

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