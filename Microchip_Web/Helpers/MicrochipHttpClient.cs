using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace Microchip_Web.Helpers
{

    public class MicrochipHttpClient
    {
        HttpClient client;
        public MicrochipHttpClient() : base()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["API"].ToString());
            client.DefaultRequestHeaders.Add("ORIGIN", "Trusted Client");
        }

        public T Get<T>(string url)
        {
            //client.BaseAddress = new Uri(ConfigurationManager.AppSettings["API"].ToString());
            var response = client.GetStringAsync(url).ContinueWith(x =>
             {
                 try
                 {
                     return x.Result;
                 }
                 catch (Exception ex)
                 {
                     Debug.Print(ex.Message);
                     throw ex;
                 }
             });

            var finalResponse = JsonConvert.DeserializeObject<T>(response.Result);
            return finalResponse;
        }
    }
}