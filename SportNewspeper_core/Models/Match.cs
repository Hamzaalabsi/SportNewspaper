using SportNewspeper_core.Models.SharedProperty;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SportNewspeper_core.Models
{
    public class Match: PerantEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public string StadiumName { get; set; }
        public string RefereeName { get; set; }
        public bool IsImportant { get; set; }
        public virtual List<TeamMatsh> TeamMatshes { get; set; }



    }
}
