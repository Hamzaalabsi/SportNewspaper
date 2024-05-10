using SportNewspeper_core.Models.SharedProperty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SportNewspeper_core.Models
{
    public class Team : PerantEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public String FoundingDate{ get; set; }
        public string CoachName { get; set; }
        public virtual List<CompetaitionTems>? Tems { get; set; }
        public virtual List<TeamMatsh>? TeamMatshes { get; set; }
        public virtual List<TeamNews>? TeamNews { get; set; }
    }
}
