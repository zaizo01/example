using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_REST.Models
{
    public class Users
    {
        public int ID { get; set; }
        public string User { get; set; }
        
        public string Password { get; set; }
    }
}
