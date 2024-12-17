using ConsoleApp1.DTO;

namespace ConsoleApp1.Service;

public class FindTaskByDescription : IFindTaskByDescriptionService
{
    public List<ReadTaskDTO> GetTaskByDescription(string descripton, IEnumerable<ReadTaskDTO> dtos)
    {
        var result = dtos.Where(x => x.description.ToLower().Contains(descripton, StringComparison.OrdinalIgnoreCase))
            .ToList();
        return result;
    }
}