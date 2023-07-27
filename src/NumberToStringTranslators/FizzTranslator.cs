using Shared;

namespace NumberToStringTranslators;

public class FizzTranslator : INumberToStringTranslator
{
    public bool CheckNumber(int number) {
        return number % 3 == 0;
    }
}