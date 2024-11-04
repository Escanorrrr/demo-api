namespace my_app.Services
{
    public interface IWeatherForecastAdaptor
    {
        Task<string> GetWeatherDataAsync(string city);
    }
}
