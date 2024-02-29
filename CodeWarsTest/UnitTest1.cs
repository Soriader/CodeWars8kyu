using CodeWars8kyu;

namespace CodeWarsTest
{
    public class Tests
    {

        [TestFixture]
        public class KataTest
        {
            [Test]
            public void MakeNegativeTest()
            {
                Assert.That(-42 == Kata.MakeNegative(42));
            }

        }

    }
}