using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using System.IO;
using TestG.Models;
namespace TestG.Areas.adminarea.Controllers
{
    public class SanPhamController : Controller
    {
        QuanLyGaraaDataContext db = new QuanLyGaraaDataContext(@"Data Source=DESKTOP-JS1E7FS\SQLEXPRESS;Initial Catalog=QuanLyGaRa;Integrated Security=True");
        // GET: adminarea/SanPham
        public ActionResult Index()
        {
            return View();
        }
    }
}