using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MessageBoardBackend.MyModels;
using System.Net.Http;
using Newtonsoft.Json;

namespace MessageBoardBackend.Controllers
{
    [Produces("application/json")]
    [Route("api/BestTemp")]
    public class BestTempController : Controller
    {
        //endpoint to the service alerts for staff
        string endpoint = "http://samples.openweathermap.org/data/2.5/weather?q=Toronto,ca&appid=b1b15e88fa797225412429c1c50c122a1";

        //persisted data in memory
        List<RootObject> MyHolderList = new List<RootObject>();
        public static List<RootObject> Weather = new List<RootObject>();
        RootObject mystringer;
      static  double currentemp;
       
        //same shit
        public async Task<double> Getme()
        {
            //HTTP client Get requests amara
            string page = endpoint;
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(endpoint))
            using (HttpContent content = response.Content)
            {
                string data = await content.ReadAsStringAsync();

                if (data != null)
                {
                    
                    //deserialize gets it
                    var ll = JsonConvert.DeserializeObject<RootObject>(data);
                    mystringer = ll;
                    double myTemp = mystringer.main.temp;
                    currentemp = myTemp;
                    //persist in list
                    // MyHolderList = Weather;
                }
            }
            

            return mystringer.main.temp;
        }

        //return toronto temp
        //
       [HttpGet]
        [Route("api/Temp")]
        public double Get()
        {

            return currentemp;

        }
    }
}