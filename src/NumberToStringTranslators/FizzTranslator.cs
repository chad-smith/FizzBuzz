using Shared;

namespace NumberToStringTranslators;

public class FizzTranslator : INumberToStringTranslator
{
    public string Value => "Fizz";
    public int Priority => 5;

    public bool CheckNumber(int number) {
        return number % 3 == 0;
    }

}