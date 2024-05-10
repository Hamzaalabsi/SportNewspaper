using SportNewspeper_core.Models.SharedProperty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SportNewspeper_core.Models
{
    public class Competaition: PerantEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<CompetaitionTems> Tems { get; set; }
        public virtual List<News>? News { get; set; }
        
    }
}
