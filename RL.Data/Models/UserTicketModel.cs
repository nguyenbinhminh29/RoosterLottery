using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RL.Data.Models
{
    public class UserTicketModel
    {
        public int TicketNumber { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string LotteryPeriod { get; set; }

        public string PhoneNo { get; set; }
        public string Winned { get; set; }
    }
}
