using Backend_modul_1_Code_challenges__Fundament_.Classes.Variable;
using Spectre.Console;

namespace Backend_modul_1_Code_challenges__Fundament_.Classes.Print;

public class PrintValues
{
    public void ValueToTable()
    {
        var values = new Values();

        var table = new Table();
        table.Title("Normal Variables");
        table.Border = TableBorder.Heavy;
        table.ShowRowSeparators();
        table.AddColumn("Type");
        table.AddColumn("Value");
        table.AddRow("string", $"{values.stringVariable}");
        table.AddRow("int", $"{values.intVariable}");
        table.AddRow("double", $"{values.doubleVariable}");
        table.AddRow("char", $"{values.charVariable}");
        table.AddRow("bool", $"{values.boolVariable}");

        AnsiConsole.Write(table);
    }

    public void ValueToArray()
    {
        var valuesToArray = new ValuesToArray();

        var stringArray = valuesToArray.stringArray;
        var intArray = valuesToArray.intArray;
        var doubleArray = valuesToArray.doubleArray;
        var charArray = valuesToArray.charArray;
        var boolArray = valuesToArray.boolArray;

        var table = new Table();
        table.Title("Array Variable");
        table.Border = TableBorder.Heavy;
        table.ShowRowSeparators();
        table.HideHeaders();
        int maxColumns = Math.Max(stringArray.Length, intArray.Length);

        for (int i = 0; i < maxColumns; i++)
        {
            table.AddColumn($"Col {i}");
        }

        table.AddRow(stringArray);
        table.AddRow(intArray.Select(x => x.ToString()).ToArray());
        table.AddRow(doubleArray.Select(x => x.ToString()).ToArray());
        table.AddRow(charArray.Select(x => x.ToString()).ToArray());
        table.AddRow(boolArray.Select(x => x.ToString()).ToArray());

        AnsiConsole.Write(table);
    }
}
