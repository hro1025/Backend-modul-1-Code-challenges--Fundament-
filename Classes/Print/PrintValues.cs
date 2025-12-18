using Backend_modul_1_Code_challenges__Fundament_.Classes.AllValues;
using Spectre.Console;

namespace Backend_modul_1_Code_challenges__Fundament_.Classes.Print;

public class PrintValues
{
    public void Table()
    {
        Values values = new Values();

        var table = new Table();
        table.Title("Variables");
        table.AddColumn("Type");
        table.AddColumn("Value");
        table.AddRow("string", $"{values.stringVariable}");
        table.AddRow("int", $"{values.intVariable}");
        table.AddRow("double", $"{values.doubleVariable}");
        table.AddRow("char", $"{values.charVariable}");
        table.AddRow("bool", $"{values.boolVariable}");

        AnsiConsole.Write(table);
    }
}
