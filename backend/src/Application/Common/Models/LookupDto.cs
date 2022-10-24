using AzureDotnetDeployment.Application.Common.Mappings;
using AzureDotnetDeployment.Domain.Entities;

namespace AzureDotnetDeployment.Application.Common.Models;

// Note: This is currently just used to demonstrate applying multiple IMapFrom attributes.
public class LookupDto : IMapFrom<TodoList>, IMapFrom<TodoItem>
{
    public int Id { get; set; }

    public string? Title { get; set; }
}
