using EspiMoon.MareConfiguration.Models;
using EspiMoon.WebAPI;
using EspiMoon.WebAPI.SignalR;

namespace EspiMoon.MareConfiguration.Configurations;

[Serializable]
public class ServerConfig : IMareConfiguration
{
    public int CurrentServer { get; set; } = 0;

    public List<ServerStorage> ServerStorage { get; set; } = new()
    {
        { new ServerStorage() { ServerName = ApiController.MainServer, ServerUri = ApiController.MainServiceUri, UseOAuth2 = true } },
        { new ServerStorage() { ServerName = "Lightless", ServerUri = "wss://sync.lightless-sync.org", UseOAuth2 = true } },
    };

    public bool SendCensusData { get; set; } = false;
    public bool ShownCensusPopup { get; set; } = false;

    public int Version { get; set; } = 2;
}