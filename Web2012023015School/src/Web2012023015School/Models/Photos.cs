﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web2012023015School.Models
{
    public class Photos
    {
        //校园风光
        public int Id { get; set; }
        public string Title { get; set; }
        public string Discription { get; set; }
        public DateTime Datatime { get; set; }
        public byte[] Picture { get; set; } 
        public int Priority { get; set; }
    }
}
