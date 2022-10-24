using AzureDotnetDeployment.Application.Common.Interfaces;

namespace AzureDotnetDeployment.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
