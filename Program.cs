using reactcomponent;

using Spectre.Console;
using Spectre.Console.Cli;

var app = new CommandApp();

app.Configure(app =>
{
    app.AddCommand<CreateComponentCommand>("create");
});

app.Run(args);

