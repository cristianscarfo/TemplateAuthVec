using AuthVec.Application.Common.Mappings;
using AuthVec.Domain.Entities;

namespace AuthVec.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
