namespace FizzBuzz;

using System.Collections.Generic;
using Shared;

public class NumberToStringTranslatorLoader {
    public IEnumerable<INumberToStringTranslator> LoadAll() {
        var translators = new List<INumberToStringTranslator>();

        return translators;
    }
}