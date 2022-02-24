using System.Net.NetworkInformation;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace MusicEvents.Security.API.HealthChecks;

public class PingHealthCheck
{
    private readonly string _host;

    public PingHealthCheck(string host)
    {
        _host = host;
    }
    public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
    {
        var ping = new Ping();

        HealthCheckResult result;

        try
        {

            var reply = await ping.SendPingAsync(_host);

            switch (reply.Status)
            {
                case IPStatus.Success:
                    result = HealthCheckResult.Healthy("Un éxito el desarrollo con C#!!");
                    break;
                case IPStatus.TimedOut:
                    result = HealthCheckResult.Degraded($"El host {_host} se encuentra lento");
                    break;
                default:
                    result = HealthCheckResult.Unhealthy($"Servicio {_host} no funciona");
                    break;
            }

        }
        catch (Exception e)
        {
            result = HealthCheckResult.Unhealthy("Error General", e);
        }

        return result;
    }
}
