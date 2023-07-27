using System;

namespace FizzBuzz;

public class Program
{
    public static void Main(string[] args) {
        var translatorLoader = new NumberToStringTranslatorLoader();
        var translators = translatorLoader.LoadAll();

        var service = new FizzBuzzService(translators);

        var start = 1;
        var end = 100;
        for (int number = start; number <= end; number++)
        {
            Console.Write(service.Translate(number));
            if (number < end){
                Console.Write(",");
            }
        }
    }
}