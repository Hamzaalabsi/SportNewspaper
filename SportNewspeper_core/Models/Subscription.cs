using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SportNewspeper_core.Enums.SportNewsPaperEnums;

namespace SportNewspeper_core.Models
{
    public class Subscription
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public SubscriptionType subscriptionType { get; set; }
        public float Price { get; set; }
        public virtual List<UserSubscription>? Subscriptions { get; set; }

    }
}
