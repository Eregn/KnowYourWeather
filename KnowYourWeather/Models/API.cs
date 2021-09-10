using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xamarin.Essentials;

namespace KnowYourWeather.Models
{
	public class API
	{
		//Create variable that will be upgraded regarding the use of the app
		public static string Parameters; // //Paramater for choose the unit display
		


		//Method to connect to the web api and parse to json format
		public async static Task<JObject> GetAPI()
		{
			var City = Preferences.Get("isCity", "Perth"); //Paramater saved as preference for the city
			var State = Preferences.Get("isCountry", "AU"); //Paramater saved as preference for the state
			var url = $"https://api.openweathermap.org/data/2.5/weather?q={City},{State}&units={Parameters}&appid=03216b249fe94aec84b7cd3de6f8e4ee";
			var client = new HttpClient();
			var response = await client.GetAsync(url);
			var responseString = await response.Content.ReadAsStringAsync();
			var obj = JObject.Parse(responseString);
			return obj;
		}

		//Display the temperature gotten from the weather API
		public static string DisplayTemp(float temperature)
		{
			string temperatureFormat;
			if (Parameters == "imperial")
			{
				temperatureFormat = String.Format("Temp - {0}°F", Math.Round(temperature, 0));
				
			}
			else
			{
				temperatureFormat  = String.Format("Temp - {0}°C", Math.Round(temperature, 0));
				
			}
			return temperatureFormat;
		}

		//Display the Feels like temperature gotten from the weather API
		public static string DisplayFeels(float feelsLike)
		{
			string feelsLikeFormat;
			if (Parameters == "imperial")
			{

				feelsLikeFormat = String.Format("Feels like - {0}°F", Math.Round(feelsLike, 0));
			}
			else
			{
				feelsLikeFormat = String.Format("Feels like - {0}°C", Math.Round(feelsLike, 0));
			}
			return feelsLikeFormat;
		}
	}
}
