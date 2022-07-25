using FluentAssertions;
using MauiLab.Views;
using Moq.AutoMock;

namespace MauiLab.Tests;

public class MainPageTest
{
    [Fact]
    public void MainPage_Counter_Button_Text_Should_Be()
    {
        // Arrange
        var mocker = new AutoMocker();
        mocker.CreateInstance<MainPage>();
        var sut = mocker.GetMock<MainPage>().Object;

        // Act
        var countButton = sut.FindByName<Button>("CounterBtn");

        // Assert
        countButton.Text.Should().Be("Click me");
    }
}