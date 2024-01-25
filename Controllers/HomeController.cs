using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WEB_QLBN.Models;

namespace WEB_QLBN.Controllers
{
    public class HomeController : Controller
    {
        string apiUrl = "http://api.ctu-it.com:5000/api/Benhnhan";
        List<Benhnhan> benhnhans = new List<Benhnhan>();

        async Task<List<Benhnhan>> Getdata()
        {
            List<Benhnhan> benhnhanList = new List<Benhnhan>();

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    benhnhanList = JsonConvert.DeserializeObject<List<Benhnhan>>(jsonString);
                }
            }
            
            return benhnhanList;
        }

        // GET: Home
        public async Task<ActionResult> Index()
        {
            benhnhans = await Getdata();
            return View(benhnhans);
        }
    }
}