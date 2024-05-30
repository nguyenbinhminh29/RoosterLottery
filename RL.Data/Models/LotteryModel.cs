using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RL.Data.Models
{
    public class LotteryModel
    {
        public string Name { get; set; }
        public DateTime OpeningTime { get; set; }
        public int OpenedNumber { get; set; }
        public string OpeningPeriod { get; set; }
    }
}
