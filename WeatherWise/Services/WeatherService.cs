using System.Text.Json;
using WeatherWise.Models;

namespace WeatherWise.Services;

public class WeatherService
{
    private static readonly string BaseUrl = "https://api.open-meteo.com/v1/forecast";

    private static readonly HttpClient _client = new HttpClient();

    static WeatherService()
    {
    }

    public static async Task<WeatherForecast?> GetDailyTemperatureAndHumidity(double latitude, double longitude)
    {
        // https://api.open-meteo.com/v1/forecast?latitude=52.519986&longitude=13.41&
        // hourly=temperature_2m,relative_humidity_2m,apparent_temperature
        var parameters = 
            $"?" +
            $"latitude={latitude}&" +
            $"longitude={longitude}&" +
            $"hourly=temperature_2m,relative_humidity_2m,apparent_temperature&" +
            $"forecast_days=1";

        var url = BaseUrl + parameters;

        WeatherForecast? weatherForecast = null;

        try
        {
            using HttpResponseMessage response = await _client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            weatherForecast = JsonSerializer.Deserialize<WeatherForecast>(responseBody);
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"HTTP Request Exception: {e.Message}");
        }
        catch (JsonException e)
        {
            Console.WriteLine($"JSON Deserialization Exception: {e.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"General Exception: {e.Message}");
        }

        return weatherForecast;
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