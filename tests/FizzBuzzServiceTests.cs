using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;
using Shared;
using NumberToStringTranslators;

namespace Tests;

[TestClass]
public class FizzBuzzServiceTests
{
    private FizzBuzzService _fizzBuzzService;

    public FizzBuzzServiceTests()
    {
        _fizzBuzzService = new FizzBuzzService(new INumberToStringTranslator[] { new FizzTranslator() });
    }

    [TestMethod]
    public void ShouldEmitFizzForNumbersDivisibleByThree()
    {

        var divisibleNumbers = new[] { -3,0,3,6,9,12,15,18,21,24,27,30 };

        foreach (var number in divisibleNumbers)
        {
            Assert.AreEqual("Fizz", _fizzBuzzService.Translate(number), $"{number} did not emit Fizz");
        }
    }

    
}
