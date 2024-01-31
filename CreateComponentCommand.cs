using Spectre.Console.Cli;

namespace reactcomponent;
internal class CreateComponentCommand : Command<CreateComponentSettings>
{
    public override int Execute(CommandContext context, CreateComponentSettings settings)
    {
        Console.WriteLine($"nome do component {settings.ComponentName}");
        return 0;
    }
}

internal class CreateComponentSettings : CommandSettings
{
    [CommandArgument(0, "<componentName>")]
    public string ComponentName { get; set; }
}