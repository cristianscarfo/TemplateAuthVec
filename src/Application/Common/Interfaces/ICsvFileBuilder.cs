using AuthVec.Application.TodoLists.Queries.ExportTodos;

namespace AuthVec.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
