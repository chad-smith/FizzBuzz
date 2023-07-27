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
        _fizzBuzzService = new FizzBuzzService(new INumberToStringTranslator[] { 
            new FizzTranslator(),
            new BuzzTranslator(),
            new FizzBuzzTranslator()
        });
    }

    [TestMethod]
    public void ShouldEmitFizzForNumbersDivisibleByThree()
    {

        var divisibleNumbers = new[] { -3,3,6,9,12,18,21,24,27 };

        foreach (var number in divisibleNumbers)
        {
            Assert.AreEqual("Fizz", _fizzBuzzService.Translate(number), $"{number} did not emit Fizz");
        }
    }

    [TestMethod]

    public void ShouldEmitBuzzForNumbersDivisibleByFive()
    {
        var divisibleNumbers = new[] { -5,5,10,20,25 };

        foreach (var number in divisibleNumbers)
        {
            Assert.AreEqual("Buzz", _fizzBuzzService.Translate(number), $"{number} did not emit Buzz");
        }
    }

    [TestMethod]

    public void ShouldEmitFizzBuzzForNumbersDivisibleByBothThreeAndFive()
    {
        var divisibleNumbers = new[] { -15,0,15,30 };

        foreach (var number in divisibleNumbers)
        {
            Assert.AreEqual("FizzBuzz", _fizzBuzzService.Translate(number), $"{number} did not emit FizzBuzz");
        }
    }
}
