using WeatherAnalyzer;

namespace WeatherWise.Utilities;

public class ConsoleMenu
{
    public User AppUser { get; set; }

    public ConsoleMenu()
    {
        AppUser = new User();
    }

    public void DisplayMainMenu()
    {
        DisplayWelcomeMessage();

        while (true)
        {
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. General info");
            Console.WriteLine("2. Temperature and humidity");
            Console.WriteLine("3. Sunrise and sunset");
            Console.WriteLine("4. Precipitation probability");
            Console.WriteLine("5. Wind info");

            if (AppUser.DefaultLocation == null) Console.WriteLine("6. Set default location");
            else Console.WriteLine("6. Change or unset default location");

            Console.WriteLine("7. Exit application");
            Console.WriteLine();

            Console.Write("Enter option: ");

            string? option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    DisplayGeneralInfo();
                    break;
                case "2":
                    DisplayTemperatureAndHumidity();
                    break;
                case "3":
                    DisplaySunriseAndSunset();
                    break;
                case "4":
                    DisplayPrecipitationProbability();
                    break;
                case "5":
                    DisplayWindInfo();
                    break;
                case "6":
                    SetOrChangeDefaultLocation();
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }

    private void DisplayTemperatureAndHumidity()
    {
        var userCity = ChooseLocation();
        if (userCity == null)
        {
            return;
        }

        Console.WriteLine("Displaying temperature and humidity.");
        Console.WriteLine();
    }

    private static string? ChooseLocation()
    {
        var cities = CityCoordinates.coordinates;
        var cityNames = cities.Keys;

        string? userChoice = null;

        while (userChoice == null)
        {
            Console.WriteLine("Available cities: " + string.Join(", ", cityNames));
            Console.WriteLine("Type \"back\" to return to main menu.");
            Console.Write("Please enter a City from the available list: ");

            var userInput = Console.ReadLine();

            if (userInput is "back" or "\"back\"")
            {
                return null;
            }
            
            var matchedCity =
                cityNames.FirstOrDefault(city => city.Equals(userInput, StringComparison.OrdinalIgnoreCase));

            if (matchedCity == null)
            {
                Console.WriteLine("Please provide a city that is on the list.\n");
                continue;
            } 

            userChoice = matchedCity;
            Console.WriteLine($"You have selected: {userChoice}");
        }
        
        if (userChoice == null)
        {
            throw new InvalidOperationException("User choice should never be null here.");
        }
        
        return userChoice;
    }

    private void SetOrChangeDefaultLocation()
    {
        throw new NotImplementedException();
    }

    private void DisplayWindInfo()
    {
        throw new NotImplementedException();
    }

    private void DisplayPrecipitationProbability()
    {
        throw new NotImplementedException();
    }

    private void DisplaySunriseAndSunset()
    {
        throw new NotImplementedException();
    }


    private void DisplayGeneralInfo()
    {
        throw new NotImplementedException();
    }

    private static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Hello there, welcome to the best Weather app!");
    }
}