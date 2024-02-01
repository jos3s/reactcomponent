using Spectre.Console.Cli;

namespace reactcomponent;
internal class CreateComponentCommand : Command<CreateComponentSettings>
{
    public override int Execute(CommandContext context, CreateComponentSettings settings)
    {

        var directory = new DirectoryInfo(Environment.CurrentDirectory + $@"\{settings.ComponentName}");

        if (!directory.Exists)
            directory = Directory.CreateDirectory($@"{Environment.CurrentDirectory}\{settings.ComponentName}");
        File.Create(directory.FullName + @"\index.jsx");
        File.Create(directory.FullName + @"\styles.css");
        return 0;
    }
}       
