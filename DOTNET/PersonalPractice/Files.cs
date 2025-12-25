namespace PersonalPractice
{
  class Files
  {
    private static string _sourceFilePath = "Text1.txt";
    private static string _destinationFilePath = "Text2.txt";

    // Creating a file
    private static void CreateFile(string filePath)
    {
      File.Create(filePath);
      Console.WriteLine("File created successfully");
    }

    /* Writing to file
        -> If the file does not exists, then it will create a file and writes.
        -> If the file exists, it will replace all the text with the new one. (Be carefull here)
     */
    private static void WriteTextToFile(string filePath, string text)
    {
      File.WriteAllText(filePath, text);
      Console.WriteLine("File is written successfully!");

    }

    /* Appending text to file
        -> If the file exists, it will append the text to the file without disturbing the existing text.
        -> If the file does not exists, it will creates the file and appends the text.
    */
    private static void AppendTextToFile(string filePath, string newText)
    {
      File.AppendAllText(filePath, newText);
      Console.WriteLine("File appended with new text successfully!");
    }

    /* Reading file
        -> If file does not exists, it will throw an exception
    */
    private static void ReadFile(string filePath)
    {
      // string readText = File.ReadAllText("C:/Users/matha/OneDrive/Desktop/Sathya Tech/DOTNET/PersonalPractice/Text.txt"); // absolute path
      string readText = IsFileExists(filePath) ? File.ReadAllText(filePath) : "\n\nFile does not exists\n\n";
      Console.WriteLine(readText);
    }

    // Copy file
    private static void CopyFile(string sourceFilePath, string destinationFilePath)
    {
      if (IsFileExists(sourceFilePath))
      {
        File.Copy(sourceFilePath, destinationFilePath);
        Console.WriteLine($"{sourceFilePath} copied to {destinationFilePath} successfully");
        return;
      }
      Console.WriteLine("Source file does not exists");
    }

    // Delete file
    private static void DeleteFile(string filePath)
    {
      File.Delete(filePath);
      Console.WriteLine($"File: {filePath} deleted successfully");
    }

    /* Checks if file exists
        -> returns a boolean value
    */
    private static bool IsFileExists(string filePath)
    {
      return File.Exists(filePath);
    }


    public static void Run()
    {
      // CreateFile(_sourceFilePath);

      // string text = "Hello! This is Kirankumar Matham.\nIm a software engineer specialized in fullstack development.";
      // WriteTextToFile(_sourceFilePath, text);
      // ReadFile(_sourceFilePath);

      // string newText = "\n\nThis is new line of text appended to this file recently.";
      // AppendTextToFile(_sourceFilePath, newText); // if file does not exists, it will create a new file and appends the text.
      // ReadFile(_sourceFilePath);

      // CopyFile(_sourceFilePath, _destinationFilePath); // if file does not exists, it will create a new file and copies.
      // ReadFile(_destinationFilePath);

      // DeleteFile("Text1.txt");
    }
  }
}