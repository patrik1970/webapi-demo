﻿using ConsoleDemo;
using System;
using System.Net.Http;

swaggerClient client = new("https://localhost:44373", new HttpClient());

var records = await client.WeatherForecastAsync();

foreach (var r in records) 
{
    Console.WriteLine($"{ r.Date }: { r.Summary }");
}       