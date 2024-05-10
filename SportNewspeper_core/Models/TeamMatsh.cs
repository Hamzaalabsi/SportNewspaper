using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNewspeper_core.Models
{
    public class TeamMatsh
    {
        public int Id { get; set; }
       
        public virtual Team Team { get; set; }
        public virtual Match Match { get; set; }
        
    }
}
