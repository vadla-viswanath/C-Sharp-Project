using System.IO;
public class ConvertTextFileToUppercase
{
    public static void Main(string[] args)
    {
        string lowerCaseFile = "lowerCaseFile.txt";
        string upperCaseFile = "upperCaseFile.txt";
        string inputContent = File.ReadAllText(lowerCaseFile);
        inputContent = inputContent.ToUpper();
        File.WriteAllText(upperCaseFile, inputContent);
    }
}