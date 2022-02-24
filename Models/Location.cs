﻿namespace WeatherApp.Models
{
    /// <summary>
    /// A class to represent the location of a weather forecast.
    /// </summary>
    public class Location
    {
        public string Name { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public double Lat { get; set; }

        public double Lon { get; set; }
        public string Tz_id { get; set; }
        public int Localtime_epoch { get; set; }
        public DateTime Localtime { get; set; }

    }
}