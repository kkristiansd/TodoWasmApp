using Domain.DTOs;
using Domain.Models;

namespace Application.DaoInterfaces;

public interface ITodoDao
{
    Task<Todo> CreateAsync(Todo todo);
    Task<IEnumerable<Todo>> GetAsync(SearchTodoParametersDto searchParameters);
    Task<Todo?> GetByIdAsync(int dtoId);
    Task UpdateAsync(Todo updated);
    Task DeleteAsync(int id);
}