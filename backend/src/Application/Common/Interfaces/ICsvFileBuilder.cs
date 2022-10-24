using AzureDotnetDeployment.Application.TodoLists.Queries.ExportTodos;

namespace AzureDotnetDeployment.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
