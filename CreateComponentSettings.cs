using Spectre.Console.Cli;

namespace reactcomponent;

internal class CreateComponentSettings : CommandSettings
{
    [CommandArgument(0, "<componentName>")]
    public string ComponentName { get; set; }
}