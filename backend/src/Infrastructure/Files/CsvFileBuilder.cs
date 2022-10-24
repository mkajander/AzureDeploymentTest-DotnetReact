using System.Globalization;
using AzureDotnetDeployment.Application.Common.Interfaces;
using AzureDotnetDeployment.Application.TodoLists.Queries.ExportTodos;
using AzureDotnetDeployment.Infrastructure.Files.Maps;
using CsvHelper;

namespace AzureDotnetDeployment.Infrastructure.Files;

public class CsvFileBuilder : ICsvFileBuilder
{
    public byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.Configuration.RegisterClassMap<TodoItemRecordMap>();
            csvWriter.WriteRecords(records);
        }

        return memoryStream.ToArray();
    }
}
