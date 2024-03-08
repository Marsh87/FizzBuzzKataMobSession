using NUnit.Framework;

namespace FizzBuzzKata.Tests;

[TestFixture]
public class TestFizzBuzz
{
    [Test]
    public void Given_GetResult_WithInput_1_ShouldReturn_String_1()
    {
        // Arrange
        var input = 1;
        var fizzBuzz = new FizzBuzz();
        // Act
        var result = fizzBuzz.GetResult(input);
        // Assert
        var expected = "1";
        Assert.That(result,Is.EqualTo(expected));
    }
}