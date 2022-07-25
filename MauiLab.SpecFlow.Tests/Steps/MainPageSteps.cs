using FluentAssertions;
using MauiLab.Views;
using Moq.AutoMock;

namespace MauiLab.SpecFlow.Tests.Steps;

[Binding, Scope(Tag = "MainPage")]
public sealed class MainPageSteps
{
    private readonly MainPage _sut;
    private readonly AutoMocker _mocker;

    public MainPageSteps(ScenarioContext scenarioContext)
    {
        _mocker = new AutoMocker();
        _mocker.CreateInstance<MainPage>();
        _sut = _mocker.GetMock<MainPage>().Object;
    }

    [Given(@"the app shows the main page")]
    public void GivenTheAppShowsTheMainPage()
    {
        _sut.Should().NotBeNull();
    }

    [Then(@"the count button text should be ""(.*)""")]
    public void ThenTheCountButtonTextShouldBe(string text)
    {
        var countButton = _sut.FindByName<Button>("CounterBtn");
        countButton.Text.Should().Be(text);
    }
}