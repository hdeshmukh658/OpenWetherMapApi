﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenWeatherMapApi.Models
{
    public class OpenWeatherMap
    {
        public string apiResponse { get; set; }

        public Dictionary<string, string> cities
        {
            get; set;
        }
    }
}