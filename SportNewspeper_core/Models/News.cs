using SportNewspeper_core.Models.SharedProperty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNewspeper_core.Models
{
    public class News: PerantEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string ImagePath {  get; set; }
        public string VedeoPath { get; set; }
        public DateTime PublishTime { get; set; }
        public bool IsImportant { get; set; }
        public virtual List<TeamNews> TeamNews { get; set; }
        public virtual Competaition? Competaition { get; set; }


    }
}
