using ConsoleApp1.DTO;
using ConsoleApp1.Model;
using ConsoleApp1.Mapper;


namespace ConsoleApp1.Service;

public class CrudToDoListNoBDService : ICRUDToDoListService
{
    private readonly List<TaskModel> AllModels = new();

    public void Create(CreateTaskDTO model)
    {
        int count = AllModels.Count + 1;
        AllModels.Add(model.FromCreateDtoToModel(count));
    }

    public ReadTaskDTO Read(int id)
    {
        var first = AllModels.FirstOrDefault(x => x.id == id) ?? throw new Exception("File not find");
        var result = new ReadTaskDTO(first.id, first.title, first.description, first.time);
        return result;
    }

    public IEnumerable<ReadTaskDTO> ReadAll()
    {
        var readList = new List<ReadTaskDTO>(AllModels.Count);
        AllModels.ForEach(x => readList.Add(x.FromModelToRead()));
        return readList;
    }


    public void Update(int id, UpdateTaskDTO dto)
    {
        var model = AllModels.FirstOrDefault(x => x.id == id);
        if (model == null) throw new Exception($"Объект по {id} не был найден");
        var index = AllModels.IndexOf(model);
        AllModels[index] = model.FromUpdateDtoToModel(dto);
    }

    public void Delete(int id)
    {
        var model = AllModels.FirstOrDefault(x => x.id == id);
        Console.WriteLine(AllModels.Remove(model) ? "Объект был удален" : "Объект для удаление  не найден");
    }
}