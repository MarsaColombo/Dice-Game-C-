using System;
using DiceGame;
using Xunit;


using Xunit;


public class TestDiceRandomness
{
    [Fact]
    public void Test_SendNumber_ReturnRandomPositive()
    {
        // Arrange
        Dice dice = new Dice();
        // Act
        int result = dice.Roll();
        // Assert
        Assert.True(result > 0);

    }
    [Fact]
    public void Test_SendNumber_ReturnFalseForNegative()
    {
        // Arrange
        Dice dice = new Dice();
        // Act
        int result = dice.Roll();
        // Assert
        Assert.False(result < 0);

    }
    // The returned integer is within the range of 0 to Int32.MaxValue.
    [Fact]
    public void Test_Returned_Integer_Within_Range()
    {
        // Arrange
        Dice dice = new Dice();

        // Act
        int result = dice.Roll();

        // Assert
        Assert.InRange(result, 0, Int32.MaxValue);
    }
    [Fact]
    public void Test_Multiple_Calls_To_Roll()
    {
        // Arrange
        Dice dice = new Dice();

        // Act & Assert
        for (int i = 0; i < 10; i++)
        {
            int result = dice.Roll();
            Assert.IsType<int>(result);
        }
    }
    // Test that it doesn't return a negative int
    [Fact]
    public void test_roll_does_not_return_negative_int()
    {
        // Arrange
        Dice dice = new Dice();

        // Act
        int result = dice.Roll();

        // Assert
        Assert.True(result >= 0);
    }

    // The Roll method returns an integer between 1 and 6.
    [Fact]
    public void test_roll_between_1_and_6()
    {
        Dice dice = new Dice();
        int result = dice.Roll();
        Assert.True(result >= 1 && result <= 6);
    }

    // The Roll method returns a different number each time it is called
    [Fact]
    public void test_roll_returns_different_number_each_time()
    {
        Dice dice = new Dice();
        int result1 = dice.Roll();
        int result2 = dice.Roll();
        Assert.NotEqual(result1, result2);
    }

    // The Roll method returns an integer between 1 and 6.
    [Fact]
    public void test_roll_returns_integer_between_1_and_6()
    {
        Dice dice = new Dice();
        int result = dice.Roll();
        Assert.InRange(result, 1, 6);
    }
}
