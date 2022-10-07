using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class HttpClientInitial
    { 
        //The class to which we assign the API URL.
        public HttpClient Initial()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://seam.riskscore.cards/");

            return client;
        }

    }
}

