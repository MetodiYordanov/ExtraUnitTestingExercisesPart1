using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;
        int postitons = 3;
        string expected = string.Empty;

        // Act
        string result = StringRotator.RotateRight(input, postitons);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
 
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        // Arrange
        string input = "apple";
        int postitons = 0;
        string expected = "apple";

        // Act
        string result = StringRotator.RotateRight(input, postitons);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        // Arrange
        string input = "apple";
        int postitons = 3;
        string expected = "pleap";

        // Act
        string result = StringRotator.RotateRight(input, postitons);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        // Arrange
        string input = "apple";
        int postitons = -4;
        string expected = "pplea";

        // Act
        string result = StringRotator.RotateRight(input, postitons);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        // Arrange
        string input = "apple";
        int postitons = 6;
        string expected = "eappl";

        // Act
        string result = StringRotator.RotateRight(input, postitons);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
