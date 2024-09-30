using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAL_SV
    {
        LINQ_TracNghiemDataContext db = new LINQ_TracNghiemDataContext();
        
        public bool CheckLoginSV(string username, string password)
        {
            //var result = db.tblSVs
            //    .Count(sv => sv.MaSV == username && sv.MatKhau == password);

            //return result > 0;

            // Sử dụng LINQ để kiểm tra tài khoản trong cơ sở dữ liệu
            var user = db.tblSVs
                         .Where(u => u.MaSV == username && u.MatKhau == password)
                         .FirstOrDefault();
            return user != null; // Trả về true nếu tìm thấy tài khoản, ngược lại false
        }
    }
}
