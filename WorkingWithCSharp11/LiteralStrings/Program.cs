

string shortLoremIpsum = """Lorem ipsum "dolor sit amet", consectetur adipiscing elit.""";

string longLoremIpsum = """
    Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
        Vivamus mattis placerat orci, nec sagittis dolor blandit at. 
        
    Nulla nec rhoncus enim. Proin facilisis orci eu viverra auctor.  
        In luctus libero vestibulum posuere interdum.            Nullam feugiat orci purus, id tristique magna tempus in. 
        In hac habitasse platea dictumst.           Morbi faucibus volutpat quam, in blandit eros interdum sit amet.
    """;



Console.WriteLine(shortLoremIpsum);
Console.WriteLine(longLoremIpsum);
Console.WriteLine();

//string invalidSingleLine = """Lorem
//      ipsum "dolor sit amet", consectetur adipiscing elit.
//    """;


int Latitude = 10;
int Longitude = 20;


var location = $$"""
   GPS coordinates: {{{Longitude}}, {{Latitude}}}
   """;

Console.WriteLine(location);
Console.WriteLine();


List<WeatherForecast> weatherForecasts = new List<WeatherForecast>()
{
    new WeatherForecast(){  Date = DateTime.Now, Summary = "Snow", TemperatureC = -3},
    new WeatherForecast(){  Date = DateTime.Now.AddDays(1), Summary = "Sunny and cold", TemperatureC = -5},
    new WeatherForecast(){  Date = DateTime.Now.AddDays(2), Summary = "Snow showers", TemperatureC = -1},

};

var json = $$"""
    [
      {
        "date": "{{weatherForecasts[0].Date}}",
        "temperatureC": {{weatherForecasts[0].TemperatureC}},
        "summary": "{{weatherForecasts[0].Summary}}"
      },
      {
        "date": "{{weatherForecasts[1].Date}}",
        "temperatureC": {{weatherForecasts[1].TemperatureC}},
        "summary": "{{weatherForecasts[1].Summary}}"
      },{
        "date": "{{weatherForecasts[2].Date}}",
        "temperatureC": {{weatherForecasts[2].TemperatureC}},
        "summary": "{{weatherForecasts[2].Summary}}"
      },
    ]
    """;

Console.WriteLine(json);

Console.ReadLine();

class WeatherForecast
{
    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public string? Summary { get; set; }

}


