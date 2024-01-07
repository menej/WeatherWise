namespace WeatherWise.Services;

public class WeatherService
{
    private static readonly string BaseUrl = "https://api.open-meteo.com/v1/forecast";

    private static readonly HttpClient _client = new HttpClient();

    static WeatherService()
    {
    }

    public static void GetDailyTemperatureAndHumidity(double latitude, double lognitude)
    {
        throw new NotImplementedException();
    }
    
    public static void GetWeeklyTemperatureAndHumidity(double latitude, double lognitude)
    {
        throw new NotImplementedException();
    }
    
    public static void GetGeneralInfo(double latitude, double lognitude)
    {
        throw new NotImplementedException();
    }
    
    public static void GetDailyWindInfo(double latitude, double lognitude)
    {
        throw new NotImplementedException();
    }
    
    public static void GetWeeklyWindInfo(double latitude, double lognitude)
    {
        throw new NotImplementedException();
    }
    
    public static void GetDailyPrecipitationProbability(double latitude, double lognitude)
    {
        throw new NotImplementedException();
    }
    
    public static void GetWeeklyPrecipitationProbability(double latitude, double lognitude)
    {
        throw new NotImplementedException();
    }
    
}