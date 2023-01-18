namespace GridShowDetailInformation.Data {
    public class WeatherForecastService {
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<List<WeatherForecast>> GetForecastAsync() {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 4).Select(index => new WeatherForecast {
                Date = DateTime.Today.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToList());
        }
    }
}
