using Fist_Hello.Common;
using Fist_Hello.Models;
using Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fist_Hello.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        /*Lấy giá trị UserName và Pass từ model AdminDao 
         * Đếm Số tài khoản trùng với UserName và Pass lấy lên từ model
         * Nếu lớn hơn 0 và nhỏ hơn 2
            * Thì sử dụng hàm để lấy UserName
            * khởi tạo 1 session
            * gán giá trị session với UserName và ID được lấy từ Common/AdminLogin
            * chèn giá trị vào sesion
            * trả về view
         * Ngược lại báo lỗi 
         */
        public ActionResult Login(LoginModel model)
        {
            if(ModelState.IsValid)
            {
                var dao = new AdminDao();
                var result = dao.Login(model.UserName, model.PassWord);
                if(result)
                {
                    var admin = dao.GetByID(model.UserName);
                    var AdminSession = new AdminLogin();

                    AdminSession.UserName = admin.UserName;
                    AdminSession.UserID = admin.ID;

                    Session.Add(CommonConstants.Admin_Session,AdminSession);
                    return View("Index","Login");
                }
                else
                {
                    ModelState.AddModelError("","Đăng Nhập Sai");
                }
            }
            return View("Index");
        }
    }
}