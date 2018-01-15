using System.IO;

namespace NUnitPractice.Mocking
{
    public interface IFileReader
    {
        string Read(string filePath);
    }

    public class FileReader : IFileReader
    {
        public string Read(string filePath)
        {
            return File.ReadAllText(filePath);
        }
    }
}
