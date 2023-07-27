namespace FizzBuzz;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Shared;

public class NumberToStringTranslatorLoader {
    public IEnumerable<INumberToStringTranslator> LoadAll() {
        var translators = new List<INumberToStringTranslator>();

        var path = Path.Combine(
            Assembly.GetExecutingAssembly().Location,
            "../../../../..", // from bin/debug/net6.0 folder to the src folder
            "NumberToStringTranslators/bin/debug/net6.0",
            "NumberToStringTranslators.dll"
        );

        var translatorTypes = AppDomain.CurrentDomain.Load(File.ReadAllBytes(path))
            .GetTypes()
            .Where( t => !t.IsInterface && typeof(INumberToStringTranslator).IsAssignableFrom(t));

        return translatorTypes.Select( t => (INumberToStringTranslator)Activator.CreateInstance(t)! );
    }
}