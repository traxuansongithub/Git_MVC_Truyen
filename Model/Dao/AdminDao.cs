using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    //dùng tạo kết nối với database và viết hàm xử lý
    public class AdminDao
    {
        OnlineStoryDB db = null; // tạo biến kết nối
        public AdminDao()
        {
            db = new OnlineStoryDB(); // kết nối csdl bằng entity
        }
        public long Insert (Admin entity)
        {
            db.Admin.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }

        // Phương thức lấy UserName của tài khoản 
        public Admin GetByID(string adminName)
        {
            return db.Admin.SingleOrDefault(x => x.UserName == adminName); // trả về số UserName = với số UserName nhập vào
        }

        //phương thức đếm số username
        public bool Login(string userName, string pass)
        {
            var result = db.Admin.Count(x => x.UserName == userName && x.PassWord == pass); //đếm số tài khoản trùng với UserName và PassWord truyền vào
            if (result > 0)
                return true;
            else
                return false;
        }
    }
}
