using System.Text.Json;
using System.Text.Json.Serialization;
using WeatherAnalyzer;

double[] ljubljana = { 46.056946, 14.505752 };

var latitude = ljubljana[0];
var longitude = ljubljana[1];

string baseUrl = "https://api.open-meteo.com/v1/forecast";
string parameters = $"?latitude={latitude}&longitude={longitude}&hourly=temperature_2m&forecast_days=1";
string url = baseUrl + parameters;


HttpClient client = new HttpClient();

WeatherForecast? weatherForecast = null;

try
{
    using HttpResponseMessage response = await client.GetAsync(url);
    response.EnsureSuccessStatusCode();
    string responseBody = await response.Content.ReadAsStringAsync();

    weatherForecast = JsonSerializer.Deserialize<WeatherForecast>(responseBody);
}
catch (HttpRequestException e)
{
    Console.WriteLine("\nException Caught!");
    Console.WriteLine($"Message: {e.Message}");
}
catch (JsonException e)
{
    Console.WriteLine($"JSON Deserialization Exception: {e.Message}");
}
catch (Exception e)
{
    Console.WriteLine($"General Exception: {e.Message}");    
}

if (weatherForecast != null)
{
    if (weatherForecast.Hourly != null)
    {
        // Console.WriteLine("Hourly data is not null.");
        // Console.WriteLine("Hourly Time Data: " + string.Join(", ", weatherForecast.Hourly.Time));
        int hour = DateTime.Now.Hour;
        var currentTemp = weatherForecast.Hourly.Temperature_2m[hour];
        Console.WriteLine($"Current temperature is: {currentTemp}");
    }
}
else
{
    Console.WriteLine("WeatherForecast object is null.");
}

Console.ReadLine();