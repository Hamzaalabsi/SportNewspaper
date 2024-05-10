using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SportNewspeper_core.Enums.SportNewsPaperEnums;

namespace SportNewspeper_core.Models.SharedProperty
{
    public class PerantEntity
    {
        public Continent continent { get; set; }
        public Sports sports { get; set; }
        public Countries countries { get; set; }
    }
}
