using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysticPartyTracker.Models
{
    public class Response
    {
        public int Count { get; set; }

        public List<Result> Results { get; set; }
    }
}
