namespace FizzBuzzD
{
    public class StandardFizzBuzzService : IFizzBuzzService
    {
        private readonly int _buzz;
        private readonly int _fizz;

        public StandardFizzBuzzService(int fizz, int buzz)
        {
            _fizz = fizz;
            _buzz = buzz;
        }

        public int? GetIntFromString(string input)
        {
            return int.TryParse(input, out var result) ? result : (int?) null;
        }

        public bool IsFizz(int input)
        {
            return input % _fizz == 0;
        }

        public bool IsBuzz(int input)
        {
            return input % _buzz == 0;
        }
    }
}