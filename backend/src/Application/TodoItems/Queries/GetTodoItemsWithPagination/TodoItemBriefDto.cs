using AzureDotnetDeployment.Application.Common.Mappings;
using AzureDotnetDeployment.Domain.Entities;

namespace AzureDotnetDeployment.Application.TodoItems.Queries.GetTodoItemsWithPagination;

public class TodoItemBriefDto : IMapFrom<TodoItem>
{
    public int Id { get; set; }

    public int ListId { get; set; }

    public string? Title { get; set; }

    public bool Done { get; set; }
}
