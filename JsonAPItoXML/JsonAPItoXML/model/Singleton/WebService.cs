using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JsonAPItoXML.model.Singleton
{
    internal class WebService
    {
        private static readonly HttpClient client = new HttpClient();
        private static WebService instance;
        private WebService() {}

        public static WebService GetInstance()
        {
            if (instance == null)
            {
                instance = new WebService();
                client.BaseAddress = new Uri("http://localhost:3000/");
            }
            return instance;
        }

        public HttpClient GetClient()
        {
            return client;
        }
    }
}

