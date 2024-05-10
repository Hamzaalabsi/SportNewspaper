namespace SportNewspeper_core.DTO.Match
{
    public class UpdateMatchDTO
    {
        public int Id { get; set; }



        public DateTime StartTime { get; set; }
        public string StadiumName { get; set; }
        public string RefereeName { get; set; }

        public bool IsImportant { get; set; }
    }
}
