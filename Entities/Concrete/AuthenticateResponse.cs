using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthenticateResponse
    {
        //The variables we created for authorization.
        public bool IsValid { get; set; }
        public string ClientId { get; set; }
        public bool CanStartScan { get; set; }
        public string CurrentIp { get; set; }
        public DateTime ExpirationDateOfClientCredential { get; set; }
        public DateTime ExpirationDateOfToken { get; set; }
        public object IpWhiteList { get; set; }
        public string Role { get; set; }
    }
}
