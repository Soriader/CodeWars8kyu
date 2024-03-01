using CodeWars8kyu;

namespace CodeWarsTest
{
    public class Tests
    {

        [TestFixture]
        public class KataTest
        {
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
            public void MultiplyTask()
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