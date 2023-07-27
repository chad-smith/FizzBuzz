using Shared;

namespace NumberToStringTranslators;

public class FizzBuzzTranslator : INumberToStringTranslator
{
    public string Value => "FizzBuzz";
    public int Priority => 10;
    
    public bool CheckNumber(int number) {
        return number % 15 == 0;
    }
}