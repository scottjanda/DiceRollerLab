using DiceRoller;

string userContinue = "y";

do
{
    string message = "";

    Console.WriteLine("Welcome to the Grand Circus Casino!");
    Console.Write("How many sides should each die have? ");
    bool validNumber = int.TryParse(Console.ReadLine(), out int number);
    Console.Clear();

    if (validNumber == false)
    {
        Console.WriteLine("That was not a valid number!");
        Console.WriteLine();
        continue;
    }

    Console.Write("Roll the dice by pressing enter!");
    Console.ReadLine();
    int result1 = DiceMethods.DiceRoll(number);
    int result2 = DiceMethods.DiceRoll(number);

    if (number == 6)
    {
        if (result1 + result2 == 2) { message = ", Craps and Snake eyes!"; }
        else if (result1 + result2 == 3) { message = ", Craps and Ace Deuce!"; }
        else if (result1 == 6 && result2 == 6) { message = ", Boxcars!"; }
        else if (result1 + result2 == 7 || result1 + result2 == 11) { message = ", Win!"; }
        else if (result1 + result2 == 12) { message = ", Craps!"; }
    }

    else
    {
        //extra credit messages
        if (result1 == result2) { message = ", both dice are the same number!"; }
        if (result1 + result2 == 10) { message = ", these results add up to 10!"; }
        if (result1 + result2 == 20) { message = ", these results add up to 20!"; }
    }

    Console.WriteLine($"You rolled {result1} and {result2}{message}");
    Console.WriteLine();

    Console.Write("Do you want to continue (y/n)? ");
    userContinue = Console.ReadLine();
    Console.Clear();

} while (userContinue.ToLower() == "y");

Console.WriteLine("Thanks for playing!");







