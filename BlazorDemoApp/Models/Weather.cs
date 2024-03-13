using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

public class WeatherForecast
{
    public List<string> Time { get; set; }
    public List<double> Temperature_2m { get; set; }
}

public class WeatherApiResponse
{
    public WeatherForecast Hourly { get; set; }
}