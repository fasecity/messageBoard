using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MessageBoardBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace MessageBoardBackend.Controllers
{


    /// <summary>
    /// currently filled with mock data to pass into
    /// angular cli uses ienumreble and returns json array of Models.message
    /// </summary>
    [Produces("application/json")]
    [Route("api/Messages")]
    public class MessagesController : Controller
    {
        //--------------------------------------db static ----------------------------------------
        public static DbContextOptions<ApiContext> options = new DbContextOptions<ApiContext>();
        public static ApiContext db = new ApiContext(Options);
        public static DbContextOptions<ApiContext> Options { get => options; set => options = value; }
        //------------------------------------------------------------------------------------------



        public IEnumerable<Message> Get()
        {
            var  q = db.Messages.ToList();
            
            return q;
        }

        [HttpGet("{name}")]
        public IEnumerable<Message> Get(string name)
        {
            
            return db.Messages.Where(m => m.Owner == name);
         
        }

        //post req
        [HttpPost]
        public Message Post([FromBody] Message message)
        {
                   
            var msg = new Message { Owner = message.Owner, Text = message.Text };
            db.Messages.AddAsync(msg);
            db.SaveChangesAsync();
            
            return message;
           
        }
    }
}