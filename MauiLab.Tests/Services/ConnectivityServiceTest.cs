using FluentAssertions;
using MauiLab.Services;
using Moq.AutoMock;

namespace MauiLab.Tests.Services;

public class ConnectivityServiceTest
{
    private readonly AutoMocker _mocker;
    
    public ConnectivityServiceTest()
    {
        _mocker = new AutoMocker();
        _mocker.CreateInstance<ConnectivityService>();
    }
    
    [Theory]
    [InlineData(NetworkAccess.Internet)]
    public void When_Has_NetworkAccess_IsConnect_Should_Be_True(NetworkAccess netWorkAccess)
    {
        // Arrange
        var connectivityMock = _mocker.GetMock<IConnectivity>();
        
        // Act
        connectivityMock.Setup(c => c.NetworkAccess).Returns(netWorkAccess);

        // Assert
        _mocker.GetMock<ConnectivityService>().Object.IsConnected.Should().BeTrue();
    }
    
    [Theory]
    [InlineData(NetworkAccess.None)]
    [InlineData(NetworkAccess.Unknown)]
    [InlineData(NetworkAccess.Local)]
    [InlineData(NetworkAccess.ConstrainedInternet)]
    public void When_Do_Not_Have_NetworkAccess_IsConnect_Should_Be_False(NetworkAccess netWorkAccess)
    {
        // Arrange
        var connectivityMock = _mocker.GetMock<IConnectivity>();
        
        // Act
        connectivityMock.Setup(c => c.NetworkAccess).Returns(netWorkAccess);

        // Assert
        _mocker.GetMock<ConnectivityService>().Object.IsConnected.Should().BeFalse();
    }
}