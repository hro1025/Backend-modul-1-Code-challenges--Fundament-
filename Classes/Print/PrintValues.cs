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
            table.AddColumn($" {i}");
        }

        table.AddRow(stringArray);
        table.AddRow(intArray.Select(x => x.ToString()).ToArray());
        table.AddRow(doubleArray.Select(x => x.ToString()).ToArray());
        table.AddRow(charArray.Select(x => x.ToString()).ToArray());
        table.AddRow(boolArray.Select(x => x.ToString()).ToArray());

        AnsiConsole.Write(table);
    }

    public void ValuesToList()
    {
        var values = new Values();

        List<object> valuesToList =
        [
            values.stringVariable,
            values.intVariable,
            values.doubleVariable,
            values.charVariable,
            values.boolVariable,
        ];

        var table = new Table();
        table.Title("List Values");
        table.Border = TableBorder.Heavy;
        table.ShowRowSeparators();
        table.AddColumn("Type");
        table.AddColumn("Value");

        foreach (var item in valuesToList)
        {
            table.AddRow(item.GetType().Name, item.ToString()!);
        }
        AnsiConsole.Write(table);
    }

    public void ValuesToDictionary()
    {
        var values = new Values();
        var Dictionary = new Dictionary<string, object>
        {
            { "string", $"{values.stringVariable}" },
            { "int", values.intVariable },
            { "double", values.doubleVariable },
            { "char", values.charVariable },
            { "bool", values.boolVariable },
        };

        foreach (var item in Dictionary)
        {
            Console.WriteLine(item);
        }
    }
}
