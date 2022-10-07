using Business.Concrete;
using Entities.Concrete;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace WorkAround
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                //AUTHOURİZE
                HttpClientInitial httpClientInitial = new HttpClientInitial();
                HttpClient client = httpClientInitial.Initial();
                AuthenticateParameters login = new AuthenticateParameters();

                var serilaze = new StringContent(JsonConvert.SerializeObject(login),
                    Encoding.UTF8, "application/json");

                HttpResponseMessage httpResponseMessage = client.PostAsync("/api/v2/oauth/token",
                    serilaze).Result;

                var token = httpResponseMessage.Content.ReadAsStringAsync().Result;
                var t = JsonConvert.DeserializeObject<Token>(token);

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", t.access_token);

                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    ////GET STATUS     
                    AuthenticateManager authenticateManager = new AuthenticateManager();
                    authenticateManager.Status(client);

                    ////////--------------------------------------

                    //POLL İŞLEMİ
                    ScanManager scanManager = new ScanManager();
                    scanManager.StatusScan(client);

                }
                else
                {
                    Console.WriteLine("Please check client_id and client_secret." );
                }

            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", Environment.UserName);
                File.AppendAllText("log.txt", Environment.NewLine);
                File.AppendAllText("log.txt", DateTime.Now.ToString("dd.MM.yyyy HH:mm"));
                File.AppendAllText("log.txt", "\r\n");
                File.AppendAllText("log.txt", ex.Message);
                File.AppendAllText("log.txt", "@");
                File.AppendAllText("log.txt", ex.StackTrace);
                File.AppendAllText("log.txt", Environment.NewLine + "**********" + Environment.NewLine);

            }
        }

    }
}

