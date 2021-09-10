using System;
using System.Collections.Generic;
using System.Text;

namespace KnowYourWeather.Models
{
	class Epoch
	{
		//Get the date and time on UTC (same as GMT) and convert to Unix time (in seconds)
		private static long epoch = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

		//Method that add the timezone of countries (in seconds) to the epoch Utc and
		//convert back to date and time string format
		public static DateTimeOffset GetTimeAndDate(long timezone)
		{
			long currenTime = epoch + timezone;
			DateTimeOffset date = DateTimeOffset.FromUnixTimeSeconds(currenTime);
			return date;
		}

	

		
	}
}
