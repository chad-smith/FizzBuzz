using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberToStringTranslators;

namespace FizzBuzz;

[TestClass]
public class FizzBuzzTests
{
    [TestMethod]
    public void ShouldWriteFizzForNumbersDivisibleByThree()
    {
        var fizzTranslator = new FizzTranslator();

        Assert.IsTrue(fizzTranslator.CheckNumber(3));
    }

    [TestMethod]
    public void ShouldNotWriteFizzForNumbersNotDivisibleByThree()
    {
        var fizzTranslator = new FizzTranslator();

        Assert.IsFalse(fizzTranslator.CheckNumber(2));
    }
}