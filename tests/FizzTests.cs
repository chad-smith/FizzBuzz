using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberToStringTranslators;

namespace FizzBuzz;

[TestClass]
public class FizzTests
{
    [TestMethod]
    public void ShouldReturnTrueForNumbersDivisibleByThree()
    {
        var fizzTranslator = new FizzTranslator();

        var divisibleNumbers = new[] { -3,0,3,6,9,12,15,18,21,24,27,30 };

        foreach (var number in divisibleNumbers)
        {
            Assert.IsTrue(fizzTranslator.CheckNumber(number));
        }
    }

    [TestMethod]
    public void ShouldReturnFalseForNumbersNotDivisibleByThree()
    {
        var fizzTranslator = new FizzTranslator();

        var divisibleNumbers = new[] { -1,1,2,4,5,7,8,10,11,13,14,16,17,19,20,22,23,25,26,28,29 };

        foreach (var number in divisibleNumbers)
        {
            Assert.IsFalse(fizzTranslator.CheckNumber(number));
        }
    }
}