using ConsoleApp1.DTO;
using ConsoleApp1.Model;

namespace ConsoleApp1.Service;

public interface ICRUDToDoListService
{
    public void Create(CreateTaskDTO model);
    public ReadTaskDTO Read(int id);
    public IEnumerable<ReadTaskDTO> ReadAll();
    public void Update(int id, UpdateTaskDTO dto);
    public void Delete(int id);
}