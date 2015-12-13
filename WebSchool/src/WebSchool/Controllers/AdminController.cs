using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WebSchool.Models;
using Microsoft.AspNet.Authorization;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebSchool.Controllers
{
    [Authorize]
    public class AdminController : BaseController
    {
        [FromServices]
        public ArticleContext DB { get; set; }
        //文章，新闻，....管理模块

        //新闻版（增删改查）

        //分页
        [HttpGet]
        public IActionResult DetailsNews()
        {
            return PagedView(DB.News, 10);
        }

        //渲染添加新闻页面
        [HttpGet]
        public IActionResult CreateNews()
        {
            return View();
        }

        //处理添加新闻请求
        [HttpPost]
        public IActionResult CreateNews(News news)
        {
            DB.News.Add(news);
            DB.SaveChanges();
            return RedirectToAction("DetailsNews", "Admin");

        }

        //渲染编辑页面
        [HttpGet]
        public IActionResult EditNews(int id)
        {
            var news = DB.News
                .Where(x => x.Id == id)
                .SingleOrDefault();
            if (news == null)
                return Content("没有此记录！");
            else
                return View(news);
        }

        //处理编辑新闻请求
        [HttpPost]
        public IActionResult EditNews(int id, News news)
        {
            var n = DB.News
                .Where(x => x.Id == id)
                .SingleOrDefault();

            if (n == null)
                return Content("没有该记录！");
            n.Title = news.Title;
            n.Content = news.Content;
            n.Datatime = news.Datatime;
            n.Source = news.Source;
            DB.SaveChanges();
            return RedirectToAction("DetailsNews", "Admin");
         
        }

        // 删除新闻
        public IActionResult DeleteNews(int id)
        {
            var news = DB.News
                .Where(x => x.Id == id)
                .SingleOrDefault();
            DB.News.Remove(news);
            DB.SaveChanges();
            System.Diagnostics.Debug.Write("id=" + id);
            return RedirectToAction("DetailsNews", "Admin");
        }

        //文章
        
    }
}
