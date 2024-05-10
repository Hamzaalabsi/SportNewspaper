using SportNewspeper_core.DTO.Team;
using static SportNewspeper_core.Enums.SportNewsPaperEnums;

namespace SportNewspeper_core.DTO.Match
{
    public class MatchDetalsDTO
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public string StadiumName { get; set; }
        public string RefereeName { get; set; }
        public Continent continent { get; set; }
        public Sports sports { get; set; }
        public Countries countries { get; set; }
        public List<TeamDetalsDTO> TeamDetals { get; set; }
    }
}
