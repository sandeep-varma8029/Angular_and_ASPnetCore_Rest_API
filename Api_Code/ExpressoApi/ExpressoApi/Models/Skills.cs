using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressoApi.Models
{
    public class Skills
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<SkillGroup> SkillGroup { get; set; }
    }
}
