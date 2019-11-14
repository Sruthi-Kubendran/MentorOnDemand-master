using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MOD.AuthLibrary.Models;



namespace MOD.AuthLibrary.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        MODContext context;
        public AdminRepository()
        {

        }
        public bool AddSkill(Skill model)
        {
            throw new NotImplementedException();
        }

        public bool blockUserById(int id, bool isActive)
        {
            var user = context.MODUsers.SingleOrDefault(u => u.Id == id.ToString());
            user.IsActive = true;
            context.SaveChanges();
           
            return true;
        }
    }
}
