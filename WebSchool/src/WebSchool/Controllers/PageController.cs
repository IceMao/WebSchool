using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WebSchool.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebSchool.Controllers
{
    public class PageController : BaseController
    {
        // GET: /<controller>/
        [FromServices]
        public ArticleContext DB { get; set; }
        [HttpGet]
        public IActionResult News()
        {
            return PagedView(DB.News, 7);
        }

        [HttpGet]
        public IActionResult Article()
        {
            return PagedView(DB.Article, 7);
        }
        
        [HttpGet]
        public IActionResult Inform()
        {
            return PagedView(DB.Inform, 10);
        }

        [HttpGet]
        public IActionResult Photos()
        {
            return PagedView(DB.Photos, 10);
        }

        [HttpGet]    
        public IActionResult RecruitStudents()
        {
            return PagedView(DB.RecruitStudents, 10);
        }

        [HttpGet]
        public IActionResult SchoolInfo()
        {
            return PagedView(DB.SchoolInfo, 10);
        }
    }
}
