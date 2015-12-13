using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSchool.Models
{
    public class RecruitStudents
    {
        //招生信息
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Datatime { get; set; }
        public string Content { get; set; }
    }
}
