using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberToStringTranslators;

namespace Tests;

[TestClass]
public class BuzzTests
{
    [TestMethod]
    public void ShouldReturnTrueForNumbersDivisibleByFive()
    {
        var buzzTranslator = new BuzzTranslator();

        var divisibleNumbers = new[] { -5,0,5,10,15,20,25,30 };

        foreach (var number in divisibleNumbers)
        {
            Assert.IsTrue(buzzTranslator.CheckNumber(number));
        }
    }

    [TestMethod]
    public void ShouldReturnFalseForNumbersNotDivisibleByFive()
    {
        var buzzTranslator = new BuzzTranslator();

        var divisibleNumbers = new[] { -1, 4, 9, 12, 18, 24, 29 };

        foreach (var number in divisibleNumbers)
        {
            Assert.IsFalse(buzzTranslator.CheckNumber(number));
        }
    }
}