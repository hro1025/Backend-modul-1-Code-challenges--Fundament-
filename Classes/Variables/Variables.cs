using Spectre.Console;

namespace Backend_modul_1_Code_challenges__Fundament_.Classes.Variables;

public class Variables
{
    string stringVariable = "This is a String";

    int intVariable = 212;

    double doubleVariable = 334.33;

    char charVariable = 'A';

    bool boolVariable = true;

    public void Table()
    {
        var table = new Table();
        table.Title("Variables");
        table.AddColumn("Type");
        table.AddColumn("Value");
        table.AddRow("string", stringVariable);
        table.AddRow("int", $"{intVariable}");
        table.AddRow("double", $"{doubleVariable}");
        table.AddRow("char", $"{charVariable}");
        table.AddRow("bool", $"{boolVariable}");

        AnsiConsole.Write(table);
    }
}
