using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R.EN;
using R.AccesoDatos;

namespace R.LogicaNegocio
{
    public class UserRBL
    {
        public static async Task<UserR> GetById(UserR pUserR)
        {
            return await UserRDAL.GetById(pUserR);
        }
        public static async Task<int> Create(UserR pUserR)
        {
            return await UserRDAL.Create(pUserR);
        }
        public static async Task<int> Update(UserR pUserR)
        {
            return await UserRDAL.Update(pUserR);
        }
        public static async Task<int> Delete (UserR pUserR)
        {
            return await UserRDAL.Delete(pUserR);
        }
        public static async Task<List<UserR>>GetAll()
        {
            return await UserRDAL.GetAll();
        }
    }
}
