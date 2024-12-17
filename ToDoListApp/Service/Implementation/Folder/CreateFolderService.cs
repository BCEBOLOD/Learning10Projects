namespace ConsoleApp1.Service;

public class CreateFolderService : ICreateFolderService
{
    private readonly string _pathFolder;

    public CreateFolderService(string pathFolder)
    {
        _pathFolder = pathFolder;
    }

    public void Create(string nameFolder)
    {
        var path = Path.Combine(_pathFolder, nameFolder);
        Directory.CreateDirectory(path);
        Console.WriteLine($"Папка создана {path}");
    }

    public bool CheckExists(string path) =>
        (Directory.Exists(path));
}