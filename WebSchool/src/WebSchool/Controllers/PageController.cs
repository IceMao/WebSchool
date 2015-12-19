using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WebSchool.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebSchool.Controllers
{
    public class PageController : Controller
    {
        // GET: /<controller>/
        [FromServices]
        public ArticleContext DB { get; set; }
        [HttpGet]
        public IActionResult News()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Article()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Inform()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Photos()
        {
            return View();
        }

        [HttpGet]    
        public IActionResult RecruitStudents()
        {
            var ret = DB.RecruitStudents.ToList();
            return View(ret);
        }

        [HttpGet]
        public IActionResult SchoolInfo()
        {
            return View();
        }
    }
}
