using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageBoardBackend.Models
{
    //this is the message class
    public class Message
    {
        public int Id { get; set; }
        public string Owner { get; set; }
        public string Text { get; set; }
    }
}
