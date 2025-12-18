using Spectre.Console;

namespace Backend_modul_1_Code_challenges__Fundament_.Classes.Calculator;

public class Cli
{
    public void Calculator()
    {
        CalculatorMath myCalculator = new CalculatorMath();

        bool keepMainRunning = true;

        while (keepMainRunning)
        {
            // Input and safe of the value
            double inputFirstNumber = AnsiConsole.Ask<double>("First Number: ");
            double inputSecondNumber = AnsiConsole.Ask<double>("Second Number");

            bool newNumber = true;

            while (newNumber)
            {
                var choice = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("Select the formula you want to use")
                        .AddChoices(new[] { "+", "-", "*", "/", "New Numbers?", "Exit" })
                );

                switch (choice) //choose the answer based on the users input
                {
                    case "+":
                        Console.WriteLine(
                            myCalculator.AddNumbers(inputFirstNumber, inputSecondNumber)
                        );
                        break;

                    case "-":
                        Console.WriteLine(
                            myCalculator.SubtractNumbers(inputFirstNumber, inputSecondNumber)
                        );
                        break;

                    case "*":
                        Console.WriteLine(
                            myCalculator.MultiplyNumber(inputFirstNumber, inputSecondNumber)
                        );
                        break;

                    case "/":
                        Console.WriteLine(
                            myCalculator.DivisionNumber(inputFirstNumber, inputSecondNumber)
                        );
                        break;

                    case "New Numbers?": // Exit the inner loop and ask for the numbers again
                        newNumber = false;
                        break;
                    case "Exit":
                        return;
                }
            }
        }
    }
}
