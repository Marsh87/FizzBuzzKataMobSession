namespace FizzBuzzKata;

public class FizzBuzz
{
    public string GetResult(int input)
    {
        if (IsDivisibleByThree(input) && IsDivisibleByFive(input))
        {
            return "FizzBuzz";
        }

        if (IsDivisibleByThree(input))
        {
            return "Fizz";
        }

        if (IsDivisibleByFive(input))
        {
            return "Buzz";
        }

        return input.ToString();
    }

    private bool IsDivisibleByThree(int input)
    {
        return input % 3 == 0;
    }

    private bool IsDivisibleByFive(int input)
    {
        return input % 5 == 0;
    }
}