using CodeWars8kyu;

namespace CodeWarsTest
{
    public class Tests
    {

        [TestFixture]
        public class KataTest
        {

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