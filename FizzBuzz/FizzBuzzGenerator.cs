namespace FizzBuzzWhitebelt
{
    public class FizzBuzzGenerator
    {
        public string Generate(int number)
        {
            if (number % 3 == 0)
            {
                return "Fizz";
            }
            return number.ToString();
        }
    }
}