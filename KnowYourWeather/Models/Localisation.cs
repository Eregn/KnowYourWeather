using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using KnowYourWeather.Views;
using KnowYourWeather.Models;

namespace KnowYourWeather.Models
{
	public class Localisation 
	{
		public string country;
		public string city;

		public Localisation(string country, string city)
		{
			this.country = country;
			this.city = city;
		}

		public string Country
		{
			get { return country; }
			set { country = value; }
		}
		public string City
		{
			get { return city; }
			set { city = value; }
		}

		// Create a list and set data in it for the listView cell
		public static List<Localisation> LocalisationLst = new List<Localisation>();
		public static void LocalLst()
		{
			if(LocalisationLst.Count == 0)
			{
				LocalisationLst.Add(new Localisation("GB", "London"));
				LocalisationLst.Add(new Localisation("FR", "Paris"));
				LocalisationLst.Add(new Localisation("US", "New York"));
				LocalisationLst.Add(new Localisation("US", "Los Angeles"));
				LocalisationLst.Add(new Localisation("CA", "Toronto"));
				LocalisationLst.Add(new Localisation("JP", "Tokyo"));
				LocalisationLst.Add(new Localisation("ES", "Madrid"));
				LocalisationLst.Add(new Localisation("ES", "Barcelona"));
				LocalisationLst.Add(new Localisation("CN", "Shanghai"));
				LocalisationLst.Add(new Localisation("BR", "Sao Paulo"));
				LocalisationLst.Add(new Localisation("AU", "Melbourne"));
				LocalisationLst.Add(new Localisation("AU", "Sydney"));
				LocalisationLst.Add(new Localisation("RE", "Saint-Denis"));
			}
			

		}

	}
}
