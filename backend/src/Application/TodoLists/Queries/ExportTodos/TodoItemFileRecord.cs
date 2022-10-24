using AzureDotnetDeployment.Application.Common.Mappings;
using AzureDotnetDeployment.Domain.Entities;

namespace AzureDotnetDeployment.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
