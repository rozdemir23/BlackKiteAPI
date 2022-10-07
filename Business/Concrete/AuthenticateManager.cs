using Entities.Concrete;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthenticateManager
    {
        public void Status(HttpClient client)
        {
            // GET -> api/v2/status 
            var statusApi = client.GetAsync("/api/v2/status").Result;
            var results = statusApi.Content.ReadAsStringAsync().Result;

            AuthenticateResponse authenticateResponse = new AuthenticateResponse();        

            authenticateResponse = JsonConvert.DeserializeObject<AuthenticateResponse>(results);
            Console.WriteLine(authenticateResponse.CurrentIp);
            Console.WriteLine("Isvalid :" + authenticateResponse.IsValid);
            Console.WriteLine("ClientId :" + authenticateResponse.ClientId);

            Console.WriteLine("----------------------------------------");

        }

        public int EcoId(HttpClient client)
        {
            //Capturing ecosystemId from API.
            var statusApi2 = client.GetAsync("/api/v2/ecosystems/").Result;
            var results2 = statusApi2.Content.ReadAsStringAsync().Result;
            string newResult = results2.Replace('[', ' ');
            string newResult2 = newResult.Replace(']', ' ');

            EcosystemID eco = new EcosystemID();

            eco = JsonConvert.DeserializeObject<EcosystemID>(newResult2);
            Console.WriteLine("EcoID : " + eco.EcosystemId);

            Console.WriteLine("----------------------------------------");

            return eco.EcosystemId;
        }
    }
}
