using Shared;

namespace NumberToStringTranslators;

public class FizzBuzzTranslator : INumberToStringTranslator
{
    public bool CheckNumber(int number) {
        return number % 15 == 0;
    }

    public string Value => "FizzBuzz";
}