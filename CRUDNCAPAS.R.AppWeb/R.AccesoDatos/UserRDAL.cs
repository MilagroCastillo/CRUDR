using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using R.EN;


namespace R.AccesoDatos
{
    public class UserRDAL
    {
        public static async Task<UserR>GetById(UserR pUserR)
        {
            var userR = new UserR();
            using(var dbContext = new ComunDB())
            {
                userR = await dbContext.UserR.FirstOrDefaultAsync(s => s.Id == pUserR.Id);
            }
            return userR;
        }
        public static async Task<int>Create(UserR pUserR)
        {
            int result = 0;
            using (var bdContext = new ComunDB())
            {
                bdContext.Add(pUserR);
                result = await bdContext.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<int> Update(UserR pUserR)
        {
            int result = 0;
            using(var bdContext = new ComunDB())
            {
                var userR = await bdContext.UserR.FirstOrDefaultAsync(r => r.Id == pUserR.Id);
                userR.NombreR = pUserR.NombreR;
                userR.ApellidoR = pUserR.ApellidoR;
                userR.FechaNacimientoR = pUserR.FechaNacimientoR;
                userR.SueldoR = pUserR.SueldoR;
                userR.EstatusR = pUserR.EstatusR;
                userR.ComentarioR = pUserR.ComentarioR;
                bdContext.Update(userR);
                result = await bdContext.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<int>Delete(UserR pUserR)
        {
            int result = 0;
            using (var bdContext = new ComunDB())
            {
                var userR = await bdContext.UserR.FirstOrDefaultAsync(r => r.Id == pUserR.Id);
                bdContext.Remove(userR);
                result = await bdContext.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<List<UserR>>GetAll()
        {
            var usersR = new List<UserR>();
            using (var bdContext=new ComunDB())
            {
                usersR = await bdContext.UserR.ToListAsync();
            }
            return usersR;
        }

    }
}
