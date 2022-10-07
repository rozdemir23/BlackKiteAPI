using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class EcosystemID
    {
        public int EcosystemId { get; set; }
        public string EcosystemName { get; set; }
        public DateTime InsertDate { get; set; }
        public string InsertUser { get; set; }
    }
}
