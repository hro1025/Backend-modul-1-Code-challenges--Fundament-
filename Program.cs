using System.Runtime.InteropServices;
using Backend_modul_1_Code_challenges__Fundament_.Classes.Calculator;
using Backend_modul_1_Code_challenges__Fundament_.Classes.Print;
using Backend_modul_1_Code_challenges__Fundament_.Classes.Variable;
using Spectre.Console;

namespace Backend_modul_1_Code_challenges__Fundament_;

class Program
{
    static void Main(string[] args)
    {
        var printValues = new PrintValues();
        var cli = new Cli();

        while (true)
        {
            // create the selection menu
            Console.WriteLine();
            var operation = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("[bold]Choose your Operation[/]?")
                    .AddChoices(new[] { "Normal Variable", "Array Variable", "Calculator", "Exit" })
            );

            switch (operation)
            {
                case "Normal Variable":
                    printValues.ValueToTable();
                    break;

                case "Array Variable":
                    printValues.ValueToArray();
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
