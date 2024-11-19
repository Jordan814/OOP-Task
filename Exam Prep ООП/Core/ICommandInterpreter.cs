namespace Exam_Prep_ООП.Core;

public interface ICommandInterpreter
{
    string ExecuteCommand(string[] data, IController controller);
}