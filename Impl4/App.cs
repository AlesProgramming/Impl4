namespace Impl4;

public class App
{
    public static void Numbers()
    {
        string total = "";
        int value = 0;
        
        Console.WriteLine("Quit to cancel, keep inputting numbers");
        string input = GetNonNullInput();
        while(input != "quit"){
            total += input;
            value += Int32.Parse(input);
            
            Console.WriteLine("Hodnota: " + value);
            Console.WriteLine("Zadáno: " + total);
            input = GetNonNullInput();
        } 
        
        Console.WriteLine("Application Quit");
    }

    public static string GetNonNullInput()
    {
        string inp = Console.ReadLine().Trim();
        if (!string.IsNullOrEmpty(inp))
        {
            return inp;
        }
        Console.WriteLine("Enter a valid input.");
        GetNonNullInput();
        return "";
    }
}