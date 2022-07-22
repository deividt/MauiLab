using FluentAssertions;

namespace MauiLab.SpecFlow.Tests.Steps;

[Binding, Scope(Tag = "MainPage")]
public sealed class MainPageSteps
{
    private readonly MainPage _mainPage;

    public MainPageSteps(ScenarioContext scenarioContext)
    {
        _mainPage = new MainPage();
    }

    [Given(@"the app shows the main page")]
    public void GivenTheAppShowsTheMainPage()
    {
        _mainPage.Should().NotBeNull();
    }

    [Then(@"the count button text should be ""(.*)""")]
    public void ThenTheCountButtonTextShouldBe(string text)
    {
        var countButton = _mainPage.FindByName<Button>("CounterBtn");
        countButton.Text.Should().Be(text);
    }
}