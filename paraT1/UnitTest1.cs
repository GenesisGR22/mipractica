using NUnit.Framework;

namespace paraT1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

      
        [Test]
        public void Caso01()
        {
            var carrito = 1;

            var result = 1;
            Assert.AreEqual(1, result);
        }
    }
}