using MOD.AuthLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.AuthService.Data
{
    public interface IRepository
    {

        bool AddSkill(Skill skill);
        IEnumerable<Skill> GetSkills();
        Skill GetSkill(int id);
        bool UpdateSkill(Skill skill);
        bool DeleteSkill(Skill skill);
       
    }
}
