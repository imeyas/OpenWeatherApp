﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherApp
{
    public class WeatherMap
    {
        public static double GetTemp(string apiCall)
        {
            var client = new HttpClient();

            var response = client.GetStringAsync(apiCall).Result;

            var temperature = double.Parse(JObject.Parse(response)["main"]["temp"].ToString());

            return temperature;
        }
       
    }
}
