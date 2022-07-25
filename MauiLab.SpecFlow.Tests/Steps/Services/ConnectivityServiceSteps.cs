using FluentAssertions;
using MauiLab.Services;
using Moq.AutoMock;

namespace MauiLab.SpecFlow.Tests.Steps.Services;

[Binding, Scope(Tag = "ConnectivityService")]
public class ConnectivityServiceSteps
{
    private readonly AutoMocker _mocker;
    private NetworkAccess _networkAccess;

    public ConnectivityServiceSteps()
    {
        _mocker = new AutoMocker();
        _mocker.CreateInstance<ConnectivityService>();
    }
    
    [Given(@"the phone is connected to (.*)")]
    public void GivenThePhoneIsConnectedTo(string connectionType)
    {
        Enum.TryParse(connectionType, out _networkAccess);
        var connectivityMock = _mocker.GetMock<IConnectivity>();
        connectivityMock.Setup(c => c.NetworkAccess).Returns(_networkAccess);
    }

    [Then(@"the connection result should be (.*)")]
    public void ThenTheConnectionResultShouldBe(bool expectedResult)
    {
        _mocker.GetMock<ConnectivityService>().Object.IsConnected.Should().Be(expectedResult);
    }
}