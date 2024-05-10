using static SportNewspeper_core.Enums.SportNewsPaperEnums;

namespace SportNewspeper_core.DTO.Subscription
{
    public class CreateOrUpdateSupscriptionDTO
    {
        public int? Id { get; set; }
        public string Description { get; set; }
        public SubscriptionType subscriptionType { get; set; }
        public float Price { get; set; }
    }
}

