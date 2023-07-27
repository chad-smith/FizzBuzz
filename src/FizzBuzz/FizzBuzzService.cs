using Shared;

namespace FizzBuzz;

public class FizzBuzzService
{

    private readonly INumberToStringTranslator[] _translators;

    public FizzBuzzService(INumberToStringTranslator[] translators)
    {
        _translators = translators;
    }

    public string Translate(int number)
    {
        foreach (var translator in _translators)
        {
            if (translator.CheckNumber(number))
            {
                return translator.Value;
            }
        }

        return number.ToString();
    }
}