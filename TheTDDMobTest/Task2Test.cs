using NUnit.Framework;
using TheTDDMob;

namespace TheTDDMobTest
{
    public class Task2Test
    {
        [TestFixture]
        public class Tests
        {
            [Test]
            public void mostCommonCharacter_ReturnsInputGiven()
            {
                Assert.True(Task2.mostCommonCharacter("a") == 'a');
            }

            [Test]
            public void DifferentTest()
            {
                Assert.True(Task2.mostCommonCharacter("bb") == 'b');
            }

            [Test]
            public void Test3()
            {
                Assert.IsTrue(Task2.mostCommonCharacter("cbb") == 'b');
            }

            [Test]
            public void Test4()
            {
                Assert.IsTrue((Task2.mostCommonCharacter("ccbb")) == 'c');
            }

            [Test]
            public void Test5()
            {
                Assert.IsTrue(Task2.mostCommonCharacter("bbaaaabb") == 'b');
            }
    
        }
    }
}