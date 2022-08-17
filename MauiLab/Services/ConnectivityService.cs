using MauiLab.Services.Interfaces;

namespace MauiLab.Services;

public class ConnectivityService : IConnectivityService
{
    private readonly IConnectivity _connectivity;

    public ConnectivityService(IConnectivity connectivity)
    {
        _connectivity = connectivity;
    }

    public bool IsConnected => _connectivity.NetworkAccess == NetworkAccess.Internet;
}