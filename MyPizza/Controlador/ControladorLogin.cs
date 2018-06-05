using Modelo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControladorLogin
    {

        private String servidor;
        
        public ControladorLogin()
        {
            servidor = "http://provenapps.cat:8080";
            //servidor = "62.83.228.129:8084";
        }


        /// <summary>
        /// Check if the user exists
        /// </summary>
        /// <param name="correo"></param>
        /// <param name="password"></param>
        /// <returns>if exists retruns a token else return null</returns>
        public async Task<Token> login(String correo, String password)
        {
            Token token = null;
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var values = new Dictionary<String, String>
                {
                    {"correo",correo },
                    {"password",password}
                };

                    var content = new FormUrlEncodedContent(values);

                    var response = await client.PostAsync(servidor + "/ServicioMyPizza/servicios/WSLogin/login", content);

                    var json = await response.Content.ReadAsStringAsync();

                    if (json != null)
                    {
                        token = JsonConvert.DeserializeObject<Token>(json);

                    }
                }
            }
            catch (HttpRequestException htre)
            {
                token = null;
            }

            return token;
        }
    }
}
