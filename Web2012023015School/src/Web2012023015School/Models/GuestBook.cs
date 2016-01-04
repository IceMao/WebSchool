using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web2012023015School.Models
{
    public class GuestBook
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public DateTime Time { get; set; }
        public string Content { get; set; }
    }
}
