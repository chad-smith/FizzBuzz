using Shared;

namespace NumberToStringTranslators;

public class BuzzTranslator : INumberToStringTranslator
{
    public bool CheckNumber(int number) {
        return number % 5 == 0;
    }

    public string Value => "Buzz";
}