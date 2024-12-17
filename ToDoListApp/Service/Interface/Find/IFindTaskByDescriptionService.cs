using ConsoleApp1.DTO;

namespace ConsoleApp1.Service;

public interface IFindTaskByDescriptionService
{
    public List<ReadTaskDTO> GetTaskByDescription(string descripton, IEnumerable<ReadTaskDTO> dtos);
}