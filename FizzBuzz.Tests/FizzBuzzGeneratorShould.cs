using FizzBuzzWhitebelt;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzGeneratorShould

    {
        // Given
        private FizzBuzzGenerator _fizzBuzzGenerator = new FizzBuzzGenerator();

        [Test]
        public void ConvertNumberToString()
        {
            // When
            var result = _fizzBuzzGenerator.Generate(1);

            // Then
            Assert.That(result, Is.EqualTo("1"));
        }
    }
}