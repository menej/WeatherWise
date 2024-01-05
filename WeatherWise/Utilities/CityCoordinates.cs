namespace WeatherAnalyzer;

public class CityCoordinates
{
    public static readonly Dictionary<string, (double Latitude, double Longitude)> coordinates = new()
    {
        { "Ljubljana", (46.056946, 14.505752) },
        { "Kranj", (46.23887, 14.35561) },
        { "Koper", (45.548059, 13.730188) },
    };
}