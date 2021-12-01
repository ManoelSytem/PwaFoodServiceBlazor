﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PwaFoodServiceBlazor.Service
{
    public class Servico
    {
        public Servico()
        {
          
        }

        public static string UrlBase()
        {
            var builder = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile($"appsettings.json");
            var config = builder.Build();

            string urlBase = config.GetSection("APIServAutenticacao:UrlBase").Value;
            return urlBase;
        }

        public static string UrlBaseFoodService()
        {
            string urlBase = "http://localhost:81/api";
            return urlBase;
        }
    }
}
