using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControladorServicio
    {
        //private String servidor = "provenapps.cat";
        private String ip = "127.0.0.1";
        private String servidor = "http://localhost:8084";

        private Boolean ping;
        private Boolean conn;

        public ControladorServicio()
        {
            ping = false;
            conn = false;
        }
        
        /// <summary>
        /// this method send a ping to the server to check the connection 
        /// </summary>
        /// <returns>true if the connection is ok or false if the conection fail</returns>
        public Boolean getPing()
        {
            
            Ping p = new Ping();
            String status = p.Send(this.ip).Status.ToString();
            
            if(status != null)
            {
                this.ping = true;
            }

            return this.ping;
        }

        /// <summary>
        /// call a method of the service that returns 1
        /// </summary>
        /// <returns>if answ equals 1 have conection and return true if not return false</returns>
        public Boolean getConnection()
        {
            String json;
            try
            {
                using (WebClient wc = new WebClient())
                {

                    wc.Encoding = System.Text.Encoding.UTF8;
                    json = wc.DownloadString(this.servidor + "/ServicioMyPizza/servicios/Connection/test");

                    int answ = int.Parse(json);
                    if (answ == 1)
                        conn = true;

                }
            }
            catch (System.Net.WebException swe)
            {
                
            }

            return conn;

        }





    }
}
