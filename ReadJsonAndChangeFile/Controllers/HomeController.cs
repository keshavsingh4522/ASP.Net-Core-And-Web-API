using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using ReadJsonAndChangeFile.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ReadJsonAndChangeFile.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly User users;


        public HomeController(ILogger<HomeController> logger,IOptions<User> user)
        {
            _logger = logger;
            users = user.Value;
        }

        public IActionResult Index()
        {
            // accesing configured data
            User temp = new User();
            temp.Name = users.Name;
            temp.Class = users.Class;
            temp.City = users.City;

            // serring session to browser
            HttpContext.Session.SetString("session",JsonConvert.SerializeObject(temp));
            return View(temp);
        }

        public IActionResult Privacy()
        {
            List<Test> items = new List<Test>();
            //using (StreamReader r = new StreamReader(@"E:\Logics PPP\ReadJsonAndChangeFile\wwwroot\test.json"))
            //{
            //    string json = r.ReadToEnd();
            //    items = JsonConvert.DeserializeObject<List<Test>>(json);
            //}

            // get session from browser
            ViewBag.user = JsonConvert.DeserializeObject(HttpContext.Session.GetString("session"));
            return View(items);
        }
        public void LoadJson()
        {
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
