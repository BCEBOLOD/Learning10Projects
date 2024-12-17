using System.Text.Encodings.Web;
using ConsoleApp1.Model;
using System.Text.Json;
using ConsoleApp1.DTO;

namespace ConsoleApp1.Service;

public class FileCreatingJsonService : IFileCreatingService
{
    private readonly string _nameFile;
    private readonly string _pathFile;
    private ICreateFolderService _serviceFolder;

    public FileCreatingJsonService(string nameFile, string pathFile)
    {
        _nameFile = nameFile;
        _pathFile = pathFile;
        _serviceFolder = new CreateFolderService(_pathFile);
    }

    public async Task Create(IEnumerable<ReadTaskDTO> models)
    {
        if (!_serviceFolder.CheckExists(_pathFile))
            _serviceFolder.Create(_pathFile);

        string pathWrite = Path.Combine(_pathFile, _nameFile + ".json");
        var option = new JsonSerializerOptions
        {
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            WriteIndented = true
        };
        var result = JsonSerializer.Serialize(models, option);
        using (StreamWriter stream = new StreamWriter(pathWrite, false))
        {
            await stream.WriteAsync(result);
        }
    }
}