using Store.Application.TodoLists.Queries.ExportTodos;

namespace Store.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
