using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSchool.Models;

namespace WebSchool.Controllers
{
    public class BaseController : BaseController<ArticleContext, User, string>
    {
    }
}
