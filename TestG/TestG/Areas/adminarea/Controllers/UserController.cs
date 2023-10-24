using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestG.Models;

namespace TestG.Areas.adminarea.Controllers
{
    
    public class UserController : Controller
    {
        QuanLyGaraaDataContext db=new QuanLyGaraaDataContext(@"Data Source=DESKTOP-JS1E7FS\SQLEXPRESS;Initial Catalog=QuanLyGaRa;Integrated Security=True");
        // GET: adminarea/User
        public ActionResult DangKy()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DangNhap() { 
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(FormCollection f)
        {
            var sTenTk = f["User"];
            var sMK = f["PassWord"];
            int a = 1;
            User user = db.Users.SingleOrDefault(n=>n.TenTK==sTenTk && n.MK==sMK && n.IDChucVu==a);
            if (user!=null)
            {
                Session["User"]=user;
                return RedirectToAction("IndexAdmin","HomeAdmin");
            }
                else
                {
                    ViewBag.ThongBao = "Tên đăng nhập hoặc mật khẩu không đúng";
                }
            return View();
        }
        public ActionResult QuenMatKhau()
        {
            return View();
        }
        public ActionResult TaoTaiKhoan()
        {
            return View();
        }
        public ActionResult DoiMatKhau()
        {

            return View();
        }
    }
}