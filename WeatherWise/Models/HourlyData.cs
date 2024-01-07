using System.Text.Json.Serialization;

namespace WeatherWise.Models;

public class HourlyData
{
    [JsonPropertyName("time")]
    public string[] Time { get; set; }

    [JsonPropertyName("temperature_2m")]
    public double[] Temperature_2m { get; set; }
}