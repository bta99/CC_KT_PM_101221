using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CC_PT_MM.Models
{
    public class User
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }
}
