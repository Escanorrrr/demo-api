
namespace my_app.Services
{
    public class WeatherForecastAdaptor : IWeatherForecastAdaptor
    {
        private readonly HttpClient _httpClient;
        public WeatherForecastAdaptor(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<string> GetWeatherDataAsync(string city)
        {
            string apikey = "dfbbabcde1805261149d50eca9fee2ba";
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apikey}";

            HttpResponseMessage response = await _httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            else
            {
                throw new Exception($"Hata: {response.StatusCode}");
            }
        }
    }
}
