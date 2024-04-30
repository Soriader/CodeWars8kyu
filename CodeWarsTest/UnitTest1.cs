using CodeWars8kyu;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Numerics;
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
                    Assert.AreEqual("", Contamination1StringTask.Contamination("abc", String.Empty));
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