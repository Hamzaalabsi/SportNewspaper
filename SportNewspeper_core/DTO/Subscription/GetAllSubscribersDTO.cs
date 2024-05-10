using static SportNewspeper_core.Enums.SportNewsPaperEnums;

namespace SportNewspeper_core.DTO.Subscription
{
    public class GetAllSubscribersDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public SubscriptionType subscriptionType { get; set; }

    }
}
