using Shared;

namespace NumberToStringTranslators;

public class BuzzTranslator : INumberToStringTranslator
{
    public string Value => "Buzz";
    public int Priority => 5;

    public bool CheckNumber(int number) {
        return number % 5 == 0;
    }
}