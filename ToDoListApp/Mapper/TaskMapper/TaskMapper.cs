using ConsoleApp1.DTO;
using ConsoleApp1.Model;

namespace ConsoleApp1.Mapper;

public static class TaskMapper
{
    public static TaskModel
        FromCreateDtoToModel(this CreateTaskDTO dto, int id = 0) // id для работы с коллекцией.При работе с бд не нужен
    {
        TaskModel model = new(id, dto.title, dto.description, dto.time);
        return model;
    }

    public static ReadTaskDTO FromModelToRead(this TaskModel model)
    {
        ReadTaskDTO dto = new(model.id, model.title, model.description, model.time);
        return dto;
    }

    public static TaskModel
        FromUpdateDtoToModel(this TaskModel model,
            UpdateTaskDTO dto) // id для работы с коллекцией.При работе с бд не нужен
    {
        return model = model with
        {
            title = dto.title,
            description = dto.description,
            time = dto.time
        };
    }
}