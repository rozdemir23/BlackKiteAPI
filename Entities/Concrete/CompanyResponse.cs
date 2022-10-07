using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CompanyResponse
    {
        public int CompanyId { get; set; }
        public string MainDomainValue { get; set; }
        public int LicenseId { get; set; }
    }
}
