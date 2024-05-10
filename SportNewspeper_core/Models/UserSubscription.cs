using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNewspeper_core.Models
{
    public class UserSubscription
    {
       public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public virtual User User { get; set; }
        public virtual Subscription Subscription { get; set; }
    }
}
