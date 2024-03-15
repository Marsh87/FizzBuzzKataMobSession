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
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Given_GetResult_WithInput_2_ShouldReturn_String_2()
    {
        // Arrange
        var input = 2;
        var fizzBuzz = new FizzBuzz();
        // Act
        var result = fizzBuzz.GetResult(input);
        // Assert
        var expected = "2";
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Given_GetResult_WithInput_3_ShouldReturn_String_Fizz()
    {
        // Arrange
        var input = 3;
        var fizzBuzz = new FizzBuzz();
        // Act
        var result = fizzBuzz.GetResult(input);
        // Assert
        var expected = "Fizz";
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Given_GetResult_WithInput_4_ShouldReturn_String_4()
    {
        // Arrange
        var input = 4;
        var fizzBuzz = new FizzBuzz();
        // Act
        var result = fizzBuzz.GetResult(input);
        // Assert
        var expected = "4";
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Given_GetResult_WithInput_5_ShouldReturn_String_Buzz()
    {
        // Arrange
        var input = 5;
        var fizzBuzz = new FizzBuzz();
        // Act
        var result = fizzBuzz.GetResult(input);
        // Assert
        var expected = "Buzz";
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Given_GetResult_WithInput_6_ShouldReturn_String_Fizz()
    {
        // Arrange
        var input = 6;
        var fizzBuzz = new FizzBuzz();
        // Act
        var result = fizzBuzz.GetResult(input);
        // Assert
        var expected = "Fizz";
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Given_GetResult_WithInput_9_ShouldReturn_String_Fizz()
    {
        // Arrange
        var input = 9;
        var fizzBuzz = new FizzBuzz();
        // Act
        var result = fizzBuzz.GetResult(input);
        // Assert
        var expected = "Fizz";
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Given_GetResult_WithInput_15_ShouldReturn_String_FizzBuzz()
    {
        // Arrange
        var input = 15;
        var fizzBuzz = new FizzBuzz();
        // Act
        var result = fizzBuzz.GetResult(input);
        // Assert
        var expected = "FizzBuzz";
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void Given_GetResult_WithInput_20_ShouldReturn_String_Buzz()
    {
        // Arrange
        var input = 20;
        var fizzBuzz = new FizzBuzz();
        // Act
        var result = fizzBuzz.GetResult(input);
        // Assert
        var expected = "Buzz";
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void Given_GetResult_WithInput_30_ShouldReturn_String_FizzBuzz()
    {
        // Arrange
        var input = 30;
        var fizzBuzz = new FizzBuzz();
        // Act
        var result = fizzBuzz.GetResult(input);
        // Assert
        var expected = "FizzBuzz";
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void Given_GetResult_WithInput_75_Should_Return_String_FizzBuzz()
    {
        // Arrange
        var input = 75;
        var fizzBuzz = new FizzBuzz();
        // Act
        var result = fizzBuzz.GetResult(input);
        // Assert
        var expected = "FizzBuzz";
        Assert.That(result, Is.EqualTo(expected));
    }
}