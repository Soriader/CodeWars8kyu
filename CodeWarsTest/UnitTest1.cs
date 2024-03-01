using CodeWars8kyu;

namespace CodeWarsTest
{
    public class Tests
    {

        [TestFixture]
        public class KataTest
        {
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