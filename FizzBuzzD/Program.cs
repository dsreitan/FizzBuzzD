using System;

namespace FizzBuzzD
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IFizzBuzzService fizzBuzzService = new StandardFizzBuzzService(3, 5);
            var rounds = Constants.DefaultNumberOfRounds;

            while (true)
            {
                for (var i = 0; i < rounds; i++)
                {
                    var result = i.ToString("D"+rounds.ToString().Length);
                    result += fizzBuzzService.IsFizz(i) ? Constants.Fizz : string.Empty;
                    result += fizzBuzzService.IsBuzz(i) ? Constants.Buzz : string.Empty;
                    Console.WriteLine(result);
                }

                Console.WriteLine("\nPlease set number of rounds: ");
                var input = Console.ReadLine();

                #region Secret

                if (input.Contains("easteregg"))
                {
                    fizzBuzzService = new RandomFizzBuzzService();
                }

                #endregion

                rounds = fizzBuzzService.GetIntFromString(input) ?? Constants.DefaultNumberOfRounds;
            }
        }
    }
}