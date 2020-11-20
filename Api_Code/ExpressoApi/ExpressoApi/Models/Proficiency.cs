using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressoApi.Models
{
    public class Proficiency
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ProficiencyGroup> ProficiencyGroup { get; set; }
    }
}
