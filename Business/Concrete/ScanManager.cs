using Entities.Concrete;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ScanManager
    {
        public void StatusScan(HttpClient client)
        {
            //ADD A NEW COMPANY
            AddCompany add = new AddCompany();
            int companyId = add.Domain(client);


            IsScanStatus isScan = new IsScanStatus();

            while (true)
            {
                Thread.Sleep(5000);

                var statusApi = client.GetAsync("/api/v2/companies/" + companyId).Result;
                var results = statusApi.Content.ReadAsStringAsync().Result;
              
                isScan = JsonConvert.DeserializeObject<IsScanStatus>(results);

                Console.WriteLine("----------------------------------------");          
                Console.WriteLine(isScan.ScanStatus);
                Console.WriteLine("----------------------------------------");

                if (isScan.ScanStatus == "Extended Results Ready" || isScan.ScanStatus == "Extended Rescan Results Ready")
                {
                    Console.WriteLine(jsonWrite(results));
                    break;
                }

            }           

        }

        public JObject jsonWrite(string results)
        {
            JObject json = JObject.Parse(results);
            return json;
        }
    }
}
