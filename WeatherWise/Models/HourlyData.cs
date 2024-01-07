using System.Text.Json.Serialization;

namespace WeatherWise.Models;

public class HourlyData
{
    [JsonPropertyName("time")]
    public string[]? Time { get; set; }

    [JsonPropertyName("temperature_2m")]
    public double[]? Temperature2M { get; set; }
    
    [JsonPropertyName("apparent_temperature")]
    public double[]? ApparentTemperature { get; set; }
    
    [JsonPropertyName("relative_humidity_2m")]
    public double[]? RelativeHumidity2M { get; set; }
}