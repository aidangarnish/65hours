using _65hours.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _65hours.Domain.AbstractServices
{
    public interface ISkillService
    {
        IEnumerable<Skill> Skills { get; }
        Skill GetByID(int skillId);
        void Save(Skill skill);
        void Delete(Skill skill);
        void Delete(int skillId);
    }
}
