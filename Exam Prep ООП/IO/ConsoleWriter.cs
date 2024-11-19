namespace Exam_Prep_ООП.IO;

public class ConsoleWriter : IWriter
{
    public void CustomWriteLine(string text)
    {
        Console.WriteLine(text);
    }

    public void CustomWrite(string text)
    {
        Console.Write(text);
    }
}

    
