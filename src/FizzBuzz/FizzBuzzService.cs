using System.Collections.Generic;
using System.Linq;
using Shared;

namespace FizzBuzz;

public class FizzBuzzService
{

    private readonly IOrderedEnumerable<INumberToStringTranslator> _translators;

    public FizzBuzzService(IEnumerable<INumberToStringTranslator> translators)
    {
        _translators = translators.OrderByDescending( x => x.Priority);
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