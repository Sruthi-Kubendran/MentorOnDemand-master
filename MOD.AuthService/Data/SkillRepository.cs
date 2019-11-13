using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.AuthLibrary;
using MOD.AuthLibrary.Models;

namespace MOD.AuthService.Data
{
    public class SkillRepository : IRepository
    {
        MODContext context;
        public SkillRepository(MODContext context)
        {
            this.context = context;
        }
        public bool AddSkill(Skill skill)
        {
            try
            {
                context.Skills.Add(skill);
                int result = context.SaveChanges();
                if (result > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool DeleteSkill(Skill skill)
        {
            try
            {
                context.Skills.Remove(skill);
                int result = context.SaveChanges();
                if (result > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Skill GetSkill(int id)
        {
            return context.Skills.Find(id); 
        }

        public IEnumerable<Skill> GetSkills()
        {
            throw new NotImplementedException();
        }

        public bool UpdateSkill(Skill skill)
        {
            try
            {
                context.Skills.Update(skill);
                int result = context.SaveChanges();
                if (result > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
