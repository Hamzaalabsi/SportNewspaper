using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNewspeper_core.Models
{
    public class TeamNews
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public virtual Team Team { get; set; }
        public virtual News News { get; set; }
    }
}
