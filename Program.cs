using Backend_modul_1_Code_challenges__Fundament_.Classes;
using Backend_modul_1_Code_challenges__Fundament_.Classes.Calculator;
using Backend_modul_1_Code_challenges__Fundament_.Classes.Variables;
using Spectre.Console;

namespace Backend_modul_1_Code_challenges__Fundament_;

class Program
{
    static void Main(string[] args)
    {
        Variables variable = new Variables();
        Cli cli = new Cli();

        while (true)
        {
            // create the selection menu
            Console.WriteLine();
            var operation = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("[bold]Choose your Operation[/]?")
                    .AddChoices(new[] { "Variable", "Calculator", "Exit" })
            );

            switch (operation)
            {
                case "Variable":
                    variable.Table();
                    break;

                case "Calculator":
                    cli.Calculator();
                    break;
                case "Exit":
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
