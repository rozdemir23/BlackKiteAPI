using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class AuthenticateParameters
    {//The class to which we assign the client_id and cliend_secret.
        public string client_id = "b2adb8b80a33420ca34626f344fa0674";
        public string client_secret = "d113ba5ad7c54bac8d8253b0810343ec";
    }
    public class Token
    {
        public string access_token { get; set; }
    }
}
