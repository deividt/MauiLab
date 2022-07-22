using FluentAssertions;

namespace MauiLab.Tests;

public class MainPageTest
{
    [Fact]
    public void MainPage_Counter_Button_Text_Should_Be()
    {
        // Arrange
        var sut = new MainPage();

        // Act
        var countButton = sut.FindByName<Button>("CounterBtn");

        // Assert
        countButton.Text.Should().Be("Click me");
    }
}