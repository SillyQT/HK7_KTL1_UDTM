using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BLL
{
    public class BLL_SV
    {
        DAL_SV dal = new DAL_SV();
        public BLL_SV() { }

        public bool BLL_SV_login(string username, string password)
        {
            return dal.CheckLoginSV(username, password);
        }
    }
}
