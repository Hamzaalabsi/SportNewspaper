using static SportNewspeper_core.Enums.SportNewsPaperEnums;

namespace SportNewspeper_core.DTO.News
{
    public class NewsDetalsDTO
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string ImagePath { get; set; }
        public string VedeoPath { get; set; }
        public DateTime PublishTime { get; set; }
        public Continent continent { get; set; }
        public Sports sports { get; set; }
        public Countries countries { get; set; }
    }
}
