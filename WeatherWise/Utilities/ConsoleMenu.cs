using WeatherAnalyzer;

namespace WeatherWise.Utilities;

public class ConsoleMenu
{
    public void DisplayMainMenu()
    {
        DisplayWelcomeMessage();

        var user = new User();
        
        while (true)
        {
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. General info");
            Console.WriteLine("2. Temperature and humidity");
            Console.WriteLine("3. Sunrise and sunset");
            Console.WriteLine("4. Precipitation probability");
            Console.WriteLine("5. Wind info");
            
            if (user.DefaultLocation == null) Console.WriteLine("6. Set default location");
            else Console.WriteLine("6. Change or unset default location");
            
            Console.WriteLine("7. Exit application");
            Console.WriteLine();

            Console.Write("Enter option: ");
            
            string? option = Console.ReadLine();
            
            switch (option)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }

    private static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Hello there, welcome to the best Weather app!");
    }
}