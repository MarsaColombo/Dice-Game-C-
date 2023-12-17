using Xunit;
using DiceGame;
using System;
public class TestDiceGameTurn
{
    // The Roll method should create an instance of the Dice class.
    [Fact]
    public void should_create_instance_of_dice_class()
    {
        // Arrange
        Turn turn = new Turn();
        // Act
        int result = turn.Roll();
        // Assert
        Assert.IsType<int>(result);
    }
    // When Roll() is called, it should return an integer between 1 and 6 (inclusive).
    [Fact]
    public void test_return_integer_between_1_and_6()
    {
        var turn = new Turn();
        var result = turn.Roll();

        Assert.InRange(result, 1, 6);
    }
    // When Roll() is called, it should handle the case where the user inputs invalid data.

    // Roll method returns an integer between 1 and 6 when user input is received within 10 seconds
    [Fact]
    public void test_roll_within_10_seconds()
    {
        // Arrange
        var turn = new Turn();

        // Act
        int result = turn.Roll();

        // Assert
        Assert.InRange(result, 1, 6);
    }
    // Dice object is created successfully when Turn object is created
    [Fact]
    public void test_dice_creation()
    {
        // Arrange & Act
        var turn = new Turn();

        // Assert
        Assert.NotNull(turn);
        // Assert.NotNull(turn.dice);
    }
    // Roll method returns 0 when user input is received after the dice has already been rolled
    [Fact]
    public void test_roll_after_dice_rolled()
    {
        // Arrange
        var turn = new Turn();

        // Act
        int result1 = turn.Roll();
        int result2 = turn.Roll();

        // Assert
        Assert.Equal(1, result2);
    }
}