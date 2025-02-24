﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationStart.Models;

namespace WebApplicationStart.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Tasks()
        {
            return View();
        }

        public string Task1()
        {
            var timeInHour = DateTime.Now.Hour;
            if (timeInHour >= 0 && timeInHour < 6)
                return "Доброй ночи";
            if (timeInHour >= 6 && timeInHour < 12)
                return "Доброе утро";
            if (timeInHour >= 12 && timeInHour < 18)
                return "Добрый день";
            return "Добрый вечер";
        }

        public double Task2(double a, double b)
        {
            return a + b;
        }

        public string Task3(double a, double b, char op = '+')
        {
            switch (op)
            {
                case '+': return (a + b).ToString();
                case '-': return (a - b).ToString();
                case '*': return (a * b).ToString();
                default:
                    return "Данная операция недоступна.\nСущетсвует возможность только ввода '+', '-' и '*'";
            }
        }

        public string Task4(double a, double b, char op = '+')
        {
            switch (op)
            {
                case '+': return $"{a} + {b} = {a + b}";
                case '-': return $"{a} - {b} = {a - b}";
                case '*': return $"{a} * {b} = {a * b}";
                case '/': return b != 0 ? $"{a} / {b} = {a / b}" : "Делить на 0 нельзя!";
                default:
                    return "Данная операция недоступна.\nСущетсвует возможность только ввода '+', '-' и '*', '/'";
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}