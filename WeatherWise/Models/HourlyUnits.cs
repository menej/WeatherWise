using System.Text.Json.Serialization;

namespace WeatherWise.Models;

public class HourlyUnits
{
    [JsonPropertyName("time")]
    public string? TimeUnit { get; set; }

    [JsonPropertyName("temperature_2m")]
    public string? Temperature2MUnit { get; set; }
    
    [JsonPropertyName("apparent_temperature")]
    public string? ApparentTemperatureUnit { get; set; }
    
    [JsonPropertyName("relative_humidity_2m")]
    public string? RelativeHumidity2MUnit { get; set; }
}