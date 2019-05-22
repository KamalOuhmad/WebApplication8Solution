using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppCourses.Models;

namespace WebAppCourses.Controllers
{
    public class HomeController : Controller
    {
        CoursesDataDBContext db = new CoursesDataDBContext();
        public ActionResult Index()
        {
            List<CoursesTypes> CourseList = db.Course.ToList();
            ViewBag.CourseList = new SelectList(CourseList, "CourseId", "CourseName");
            return View();
        }

        public JsonResult GetTypeList(int CourseId)
        {
            db.Configuration.ProxyCreationEnabled = false;
            List<Types> TypeList = db.Type.Where(x => x.CourseId == CourseId).ToList();
            return Json(TypeList, JsonRequestBehavior.AllowGet);
        }


    }
}
   
