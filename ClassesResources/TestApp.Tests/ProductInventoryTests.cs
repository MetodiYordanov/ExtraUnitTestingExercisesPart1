using NUnit.Framework;
using System;
using TestApp.Product;

namespace TestApp.Tests;

[TestFixture]
public class ProductInventoryTests
{
    private ProductInventory _inventory = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._inventory = new();
    }
    
    [Test]
    public void Test_AddProduct_ProductAddedToInventory()
    {
        // Arrange
        string productName = "Banana";
        double productPrice = 2.50;
        int productQuantity = 5;
        string expected = $"Product Inventory:{Environment.NewLine}Banana - Price: $2.50 - Quantity: 5";

        // Act
        this._inventory.AddProduct(productName, productPrice, productQuantity);
        string result = this._inventory.DisplayInventory();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayInventory_NoProducts_ReturnsEmptyString()
    {
        // Arrange
        string expected = "Product Inventory:";

        // Act
        string result = this._inventory.DisplayInventory();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayInventory_WithProducts_ReturnsFormattedInventory()
    {
        // Arrange
        string productName = "Banana";
        double productPrice = 2.50;
        int productQuantity = 5;
        string productName2 = "Coffee";
        double productPrice2 = 4.25;
        int productQuantity2 = 3;
        string expected = $"Product Inventory:{Environment.NewLine}Banana - Price: $2.50 - Quantity: 5" +
            $"{Environment.NewLine}Coffee - Price: $4.25 - Quantity: 3";

        // Act
        this._inventory.AddProduct(productName, productPrice, productQuantity);
        this._inventory.AddProduct(productName2, productPrice2, productQuantity2);
        string result = this._inventory.DisplayInventory();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateTotalValue_NoProducts_ReturnsZero()
    {
        // Arrange
        double expected = 0;

        // Act
        double result = this._inventory.CalculateTotalValue();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateTotalValue_WithProducts_ReturnsTotalValue()
    {
        // Arrange
        string productName = "Banana";
        double productPrice = 2.50;
        int productQuantity = 5;
        string productName2 = "Coffee";
        double productPrice2 = 4.25;
        int productQuantity2 = 3;
        double expected = 25.25;

        // Act
        this._inventory.AddProduct(productName, productPrice, productQuantity);
        this._inventory.AddProduct(productName2, productPrice2, productQuantity2);
        double result = this._inventory.CalculateTotalValue();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
