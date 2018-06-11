using Modelo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    class HttpRequest
    {
        private String token;
        //private String servidor = "http://provenapps.cat:8080";
        private String servidor = "http://localhost:8080";

        public HttpRequest()
        {
            readToken();
        }

        public String readToken()
        {
            try
            {
                String token = "";

                using (StreamReader sr = new StreamReader("tokens.txt"))
                {
                    while ((token = sr.ReadLine()) != null)
                    {
                        this.token = token;
                    }
                }
            }
            catch (FileNotFoundException fnf)
            {
                
            }

            return token;

        }

        public String sendRequest(String url)
        {
            String json = "";

            using (WebClient wc = new WebClient())
            {
                wc.Headers.Add("X-API-KEY", this.token);
                wc.Encoding = System.Text.Encoding.UTF8;               
                json = wc.DownloadString(servidor+url);

            }

            return json;
        }

        public async Task<string> sendRequestPOST(String url, List<String> parametros, List<String> valores)
        {
            String json;

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-API-KEY", this.token); //Add the token to request

                var values = new Dictionary<String, String>();

                for (int i = 0; i < parametros.Count; i++)
                {
                    values.Add(parametros[i], valores[i]);
                }

                var content = new FormUrlEncodedContent(values);
                
                var response = await client.PostAsync(servidor+url,content);

                json = await response.Content.ReadAsStringAsync();

            }
            return json;
        }

    }
}
