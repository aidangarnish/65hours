using _65hours.Domain.AbstractRepository;
using _65hours.Domain.AbstractServices;
using _65hours.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _65hours.Domain.Services
{
    public class SkillService : ISkillService
    {
        private ISkillRepository skillRepository;

        public SkillService(ISkillRepository SkillRepository)
        {
            this.skillRepository = SkillRepository;
        }

        public IEnumerable<Skill> Skills
        {
            get { return skillRepository.GetAll(); }
        }

        public Skill GetByID(int skillId)
        {
            return skillRepository.GetById(skillId);
        }

        public void Save(Skill skill)
        {

            if (skill.SkillID == 0)
            {
                skillRepository.Add(skill);
            }
            else
            {
                skillRepository.Update(skill);
            } 
        }

        public void Delete(Skill product)
        {
            skillRepository.Delete(product);
        }

        public void Delete(int skillId)
        {
            skillRepository.Delete(s => s.SkillID == skillId);
        }
    }
}
