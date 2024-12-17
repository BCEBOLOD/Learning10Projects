using ConsoleApp1.DTO;
using ConsoleApp1.Service;

ICRUDToDoListService serviceCRUD = new CrudToDoListNoBDService();
IFileCreatingService serviceJson = new FileCreatingJsonService("models", "E:\\mem");
IFindTaskByDescriptionService serviceFindDescription = new FindTaskByDescription();
serviceCRUD.Create(new CreateTaskDTO("First", "MyDescription", DateTime.Now));
serviceCRUD.Create(new CreateTaskDTO("Aleksei", "Bcebolod", DateTime.Now));


Console.WriteLine("-------------------");

serviceCRUD.Update(1, new UpdateTaskDTO("New Name", "Описание на русском", DateTime.Now));
var result = serviceCRUD.ReadAll();
foreach (var readTaskDto in result)
{
    Console.WriteLine(readTaskDto);
}

var findDescriptionResult = serviceFindDescription.GetTaskByDescription("bceb", result);
if (findDescriptionResult.Any())
{
    foreach (var item in findDescriptionResult)
    {
        Console.WriteLine(item.description);
    }
}

await serviceJson.Create(result);