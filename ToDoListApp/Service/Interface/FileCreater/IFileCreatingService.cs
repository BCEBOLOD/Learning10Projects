using ConsoleApp1.DTO;
using ConsoleApp1.Model;

namespace ConsoleApp1.Service;

public interface IFileCreatingService
{
    public Task Create(IEnumerable<ReadTaskDTO> models);
}