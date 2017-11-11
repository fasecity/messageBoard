using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageBoardBackend.MyModels
{
    public class Staff
    {
        public int Id { get; set; }
        public string property { get; set; }//limited types can be need to know all of them
        public string building { get; set; }//limited types need to know all of them
        public bool proactive { get; set; }
        public string status { get; set; }//--------- status variables names - need to know all of them
        public string date_due { get; set; }
        public string date_dispatched { get; set; }
        public string date_completed { get; set; }
        public string date_closed { get; set; }
        public string date_received { get; set; }
        public string date_responded { get; set; }
        public string tenant { get; set; }
        public string floor { get; set; }
        public string suite { get; set; }
        public string request_type { get; set; }
        public string trade { get; set; }
        public int priority { get; set; }//--------------------------------see what priorities mean
        public string wo_description { get; set; }
        public string schedule_id { get; set; }
        public string wo_detail { get; set; }

    }
}
