using NUnit.Framework;

namespace Yz.Csharp.Core
{

    public class SampleTest
    {
        int[] array;

        [SetUp]
        public void Setup()
        {
            array = new int[]{ 1, 6, 12, 7, 3, 8 };

        }

        [TearDown]
        public void TearDown()
        {
            array = null;
        }

        [OneTimeSetUp]
        public void OneTimeSetup()
        {

        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {

        }

        [Test]
        public void ArrayTest()
        {
            Assert.That(array.Length, Is.EqualTo(6));


            Assert.Pass();
        }

        [Test]
        public void StringTest()
        {

        }
    }
}