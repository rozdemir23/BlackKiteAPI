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
    public class AddCompany
    {
        public int Domain(HttpClient client)
        {
          
            AuthenticateManager aut = new AuthenticateManager();
            int ecoId = aut.EcoId(client);
            Companies companies = new Companies()
            {
                MainDomainValue = "iWillAchive.com",
                CompanyName = "I Will Achieve",
                EcosystemId = ecoId,
                LicenseType = "ok",
                IsSubsidiary = false,
                IsCloudProvider = true,

            };

            var serializeProduct = System.Text.Json.JsonSerializer.Serialize(companies);

            StringContent stringContent = new StringContent(serializeProduct, Encoding.UTF8, "application/json");

            CompanyResponse companyResponse = new CompanyResponse();

            var result = client.PostAsync("api/v2/companies", stringContent).Result;
            var results2 = result.Content.ReadAsStringAsync().Result;
            companyResponse = JsonConvert.DeserializeObject<CompanyResponse>(results2);

            Console.WriteLine(results2);

            if (result.IsSuccessStatusCode)
                Console.WriteLine($"Company Added. {result.StatusCode}");

            else
                Console.WriteLine($"The company could not be added --> Hata Kodu: {result.StatusCode}");

            return companyResponse.CompanyId;
        }

    }
}
