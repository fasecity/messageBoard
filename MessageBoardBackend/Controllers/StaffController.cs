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
    [Route("api/Staff")]
    public class StaffController : Controller
    {
        //endpoint to the service alerts for staff
        string endpoint = "https://api.namara.io/v0/data_sets/58419648-dec7-4690-b577-fe786c54797c/data/en-3?geometry_format=wkt&api_key=fd890e0680f35954c1da532a8e7580bb3fca4012ed01130bea47bdc830b16b05";

        //persisted data in memory
        List<Staff> StaffAlertsList = new List<Staff>();
        public static List<Staff> AlertsList = new List<Staff>();
        
        /// <summary>
        ///  Gets staff sorts by priority floor date n request type
        /// </summary>
        /// <returns></returns>
        public async Task<List<Staff>> Getme()
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
                  //deserialize
                  StaffAlertsList = JsonConvert.DeserializeObject<List<Staff>>(data);

                  //persist in list
                  AlertsList = StaffAlertsList;                   
                }
            }                    
            // var GeneralMaintanence = AlertsList.FindAll(x => x.trade == "General Maintenance").ToList();
            var betterSort = AlertsList
                .OrderBy(x => x.date_received)
                .ThenBy(x => x.priority)
                .ThenBy(x => x.floor)
                .ThenBy(x => x.request_type).ToList();
            
                return betterSort ;          
        }

    }
}