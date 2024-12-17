namespace ConsoleApp1.Service;

public interface ICreateFolderService
{
    public void Create(string nameFolder);
    public bool CheckExists(string path);
}