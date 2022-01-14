using System.Globalization;
using AuthVec.Application.TodoLists.Queries.ExportTodos;
using CsvHelper.Configuration;

namespace AuthVec.Infrastructure.Files.Maps;

public class TodoItemRecordMap : ClassMap<TodoItemRecord>
{
    public TodoItemRecordMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Done).ConvertUsing(c => c.Done ? "Yes" : "No");
    }
}
