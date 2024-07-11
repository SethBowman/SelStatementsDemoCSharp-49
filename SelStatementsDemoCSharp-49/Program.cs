namespace SelStatementsDemoCSharp_49;

class Program
{
    static void Main(string[] args)
    {
        //if-else statement

        bool condition = false;

        // if (condition == false)
        // {
        //     Console.WriteLine("If scope");
        // }
        // else
        // {
        //     Console.WriteLine("Else scope");
        // }
        //
        // Console.WriteLine("Continue");

        int a = 20;
        int b = 200;

        if (a == b)
        {
            Console.WriteLine("If scope");
        }
        else if (a > b)
        {
            Console.WriteLine("1st else if");
        }
        else
        {
            Console.WriteLine("Else");
        }
        
        //ternary operator (inline if statement)
        int i = 1;
        string message = i > 0 ? "Positive" : "Negative";
        Console.WriteLine(message);

        //switch case statement

        string today = "thurs";

        switch (today.ToUpper())
        {
            case "sunday":
                Console.WriteLine("It is Sunday");
                break;
            case "monday":
                Console.WriteLine("It is Monday");
                break;
            case "tuesday":
                Console.WriteLine("It is Tuesday");
                break;
            case "wednesday":
                Console.WriteLine("It is Wednesday");
                break;
            case "thursday":
            case "thurs":    
                Console.WriteLine("It is Thursday");
                break;
            case "friday":
                Console.WriteLine("It is Friday");
                break;
            case "saturday":
                Console.WriteLine("It is Saturday");
                break;
            default:
                Console.WriteLine("That's not a day of the week");
                break;
        }
    }
}