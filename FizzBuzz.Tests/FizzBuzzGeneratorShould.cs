using FizzBuzzWhitebelt;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzGeneratorShould

    {
        // Given
        private FizzBuzzGenerator _fizzBuzzGenerator = new FizzBuzzGenerator();

        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        [TestCase(4, "4")]
        [TestCase(5, "Buzz")]
        public void ConvertNumberToString(int input, string output)
        {
            // When
            var result = _fizzBuzzGenerator.Generate(input);

            // Then
            Assert.That(result, Is.EqualTo(output));
        }
        
        
    }
}