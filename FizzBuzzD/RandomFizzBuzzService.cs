using System;

namespace FizzBuzzD
{
    internal class RandomFizzBuzzService : IFizzBuzzService
    {
        private readonly Random _random;

        public RandomFizzBuzzService()
        {
            _random = new Random();
        }

        public int? GetIntFromString(string input)
        {
            return int.TryParse(input, out var result) ? result : (int?) null;
        }

        public bool IsFizz(int input)
        {
            return GetRandomBool();
        }

        public bool IsBuzz(int input)
        {
            return GetRandomBool();
        }

        private bool GetRandomBool()
        {
            return _random.NextDouble() >= 0.5;
        }
    }
}