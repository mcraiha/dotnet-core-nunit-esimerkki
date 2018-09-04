using NUnit.Framework;
using konsoliesimerkki;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void KertomisTesti()
        {
            // Arrange
            Kertoja kertoja = new Kertoja();

            // Act
            int tulos = kertoja.Kerro(5, 3);

            // Assert
            Assert.AreEqual(15, tulos, "Pitäisi olla 15");
        }
    }
}