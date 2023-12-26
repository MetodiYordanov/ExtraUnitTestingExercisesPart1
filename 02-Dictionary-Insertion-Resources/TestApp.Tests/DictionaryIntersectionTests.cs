using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class DictionaryIntersectionTests
{
    [Test]
    public void Test_Intersect_TwoEmptyDictionaries_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dictionary1 = new Dictionary<string, int>();
        Dictionary<string, int> dictionary2 = new Dictionary<string, int>();
        Dictionary<string, int> expected = new Dictionary<string, int>();

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dictionary1, dictionary2);

        // Assert
        Assert.That(result.Count, Is.EqualTo(expected.Count));
    }

    [Test]
    public void Test_Intersect_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dictionary1 = new Dictionary<string, int>
        { 
            { "Sasho", 12 },
            { "Pesho", 15 }
        };
        Dictionary<string, int> dictionary2 = new Dictionary<string, int>();
        Dictionary<string, int> expected = new Dictionary<string, int>();

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dictionary1, dictionary2);

        // Assert
        Assert.That(result.Count, Is.EqualTo(expected.Count));
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithNoCommonKeys_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dictionary1 = new Dictionary<string, int>
        { 
            { "Sasho", 12 },
            { "Pesho", 15 }
        };
        Dictionary<string, int> dictionary2 = new Dictionary<string, int>
        {
            { "Maria", 18 },
            { "Ani", 16 }
        };
        Dictionary<string, int> expected = new Dictionary<string, int>();

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dictionary1, dictionary2);

        // Assert
        Assert.That(result.Count, Is.EqualTo(expected.Count));
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndValues_ReturnsIntersectionDictionary()
    {
        // Arrange
        Dictionary<string, int> dictionary1 = new Dictionary<string, int>
        {
            { "Sasho", 12 },
            { "Pesho", 15 }
        };
        Dictionary<string, int> dictionary2 = new Dictionary<string, int>
        {
            { "Sasho", 12 },
            { "Ani", 16 }
        };
        Dictionary<string, int> expected = new Dictionary<string, int>
        {
            { "Sasho", 12 }
        };

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dictionary1, dictionary2);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndDifferentValues_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dictionary1 = new Dictionary<string, int>
        {
            { "Sasho", 12 },
            { "Pesho", 15 }
        };
        Dictionary<string, int> dictionary2 = new Dictionary<string, int>
        {
            { "Sasho", 14 },
            { "Ani", 16 }
        };
        Dictionary<string, int> expected = new Dictionary<string, int>();

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dictionary1, dictionary2);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
