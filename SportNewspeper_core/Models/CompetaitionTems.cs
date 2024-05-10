using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNewspeper_core.Models
{
    public class CompetaitionTems
    {
        public int Id { get; set; }
        public virtual Competaition Competaition { get; set; }
        public virtual Team Tems { get; set; }
    }
}
