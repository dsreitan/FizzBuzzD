namespace FizzBuzzD
{
    public interface IFizzBuzzService
    {
        int? GetIntFromString(string input);
        bool IsFizz(int input);
        bool IsBuzz(int input);
    }
}