using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RL.Data.Models
{
    public class GenericResult
    {
        public int Code { get; set; }
        public object Data { get; set; }

        public bool Success { get; set; }

        public string Message { get; set; }
    }
}
