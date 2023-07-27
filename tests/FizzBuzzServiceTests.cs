using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;
using Shared;

namespace Tests;

[TestClass]
public class FizzBuzzServiceTests
{
    private FizzBuzzService _fizzBuzzService;

    public FizzBuzzServiceTests()
    {
        _fizzBuzzService = new FizzBuzzService(new INumberToStringTranslator[0]);
    }

    [TestMethod]
    public void ShouldEmitFizzForNumbersDivisibleByThree()
    {
        Assert.AreEqual("Fizz", _fizzBuzzService.Translate(0));
    }
}
