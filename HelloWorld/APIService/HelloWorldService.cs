using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Configuration;
using HelloWorldUtility;
using HelloWorldUtility.Services;

namespace HelloWorld.APIService
{
    class HelloWorldService
    {
        private string uriAddress;

        /// <summary>
           /// To get the message from WebAPI
        /// </summary>
        public void Message()
        {
            HttpClient client = new HttpClient();
            ConfigurationAppSettings configSettings = new ConfigurationAppSettings();
            uriAddress=configSettings.GetName("HelloWorldAPI");
            client.BaseAddress = new Uri(uriAddress);

            GetAction action = new GetAction();
            action.ActionName = "/GetMessage";
            // data response.
            HttpResponseMessage response = client.GetAsync(uriAddress+action.ActionName).Result;
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("{0}", response.Content.ReadAsStringAsync().Result);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

        }
    }
}
