// Hold user input for date
string thedate = "";
// Holds current date
DateTime today = DateTime.Today;

do
{
    Console.WriteLine("Which date? (or 'exit')");
    thedate = Console.ReadLine();

    if (thedate == "exit")
    {
        break;
    }

    DateTime parsedDate;
    TimeSpan ts;
    if (DateTime.TryParse(thedate, out parsedDate))
    {
        if (parsedDate < today)
        {
            ts = today - parsedDate;
            System.Console.WriteLine($"That date went by {ts.Days} days ago!");
        }
        else if (parsedDate == today)
        {
            System.Console.WriteLine($"That date is today!");
        }
        else
        {
            ts = parsedDate - today;
            System.Console.WriteLine($"That date will be in {ts.Days} days!");
        }
    }
    else
    {
        Console.WriteLine("That doesn't seem to be a valid date!");
    }
} while (thedate != "exit");