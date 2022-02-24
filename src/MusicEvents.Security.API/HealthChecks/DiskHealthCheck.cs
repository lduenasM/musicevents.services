using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace MusicEvents.Security.API.HealthChecks;
public class DiskHealthCheck : IHealthCheck
{
    private readonly IConfiguration _configuration;

    public DiskHealthCheck(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
    {
        var directory = new DirectoryInfo(_configuration.GetSection("StorageConfiguration:Path").Value);

        return await Task.FromResult(directory.Exists
            ? HealthCheckResult.Healthy("La carpeta existe")
            : HealthCheckResult.Unhealthy("La carpeta fue borrada"));
    }
}
