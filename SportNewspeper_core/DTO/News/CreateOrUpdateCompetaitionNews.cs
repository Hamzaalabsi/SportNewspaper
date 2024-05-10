using SportNewspeper_core.Models;
using static SportNewspeper_core.Enums.SportNewsPaperEnums;

namespace SportNewspeper_core.DTO.News
{
    public class CreateOrUpdateCompetaitionNews
    {
        public int? CompaitionId { get; set; }
        public int? TeamId { get; set; }

       
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string ImagePath { get; set; }
        public string VedeoPath { get; set; }
        public DateTime PublishTime { get; set; }
        public Continent continent { get; set; }
        public Sports sports { get; set; }
        public Countries countries { get; set; }
        public bool IsImportant { get; set; }
        //public virtual Competaition? Competaition { get; set; }
    }
}
