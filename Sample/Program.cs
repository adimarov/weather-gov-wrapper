using GeoJSON.Net.Feature;
using Newtonsoft.Json;
using Polly;
using RestSharp;
using WeatherGov.Wrapper.Api;
using WeatherGov.Wrapper.Client;


Random jitter = new Random();


var policy = Policy<RestResponse>
  .Handle<Exception>()
  .WaitAndRetryAsync(5,
      retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt))
                    + TimeSpan.FromMilliseconds(jitter.Next(0, 1000))
  );

RetryConfiguration.AsyncRetryPolicy = policy;

var api = new DefaultApi("https://api.weather.gov");
var result = await api.GridpointForecastAsync(WeatherGov.Wrapper.Model.NWSForecastOfficeId.TBW, 61, 104);