using Exam_Prep_ООП.Core;
using Exam_Prep_ООП.IO;

string pathFile = Path.Combine("..", "..", "..", "output.txt");
File.Create(pathFile).Close();

IReader reader = new ConsoleReader();
IWriter writer = new FileWriter(pathFile);
ICommandInterpreter commandInterpreter = new CommandInterpreter();
IController controller = new Controller();

IEngine engine = new Engine(reader, writer, commandInterpreter, controller);
engine.Run();