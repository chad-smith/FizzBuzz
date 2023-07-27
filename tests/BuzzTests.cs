using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberToStringTranslators;

namespace FizzBuzz;

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
}