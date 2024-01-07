namespace WeatherWise.UserInterface;

public class ConsoleHelper
{
    public static void WaitForKeyPress()
    {
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey(true);

        // Clear the "Press any key to continue." line
        Console.SetCursorPosition(0, Console.CursorTop - 1);
        ClearCurrentConsoleLine();        
    }

    private static void ClearCurrentConsoleLine()
    {
        int currentLineCursor = Console.CursorTop;
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write(new string(' ', Console.WindowWidth)); 
        Console.SetCursorPosition(0, currentLineCursor);
    }
}