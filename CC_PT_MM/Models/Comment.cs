using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CC_PT_MM.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime DayComment { get; set; }
        public string Content { get; set; }
    }
}
