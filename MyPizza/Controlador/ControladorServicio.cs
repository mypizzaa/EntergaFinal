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
        private String servidor = "provenapps.cat"; 
              
        private Boolean ping;
        private Boolean conn;

        public ControladorServicio()
        {
            ping = false;
            conn = false;
        }
        
        /// <summary>
        /// this method send a ping to the server provenapps.cat to check the connection 
        /// </summary>
        /// <returns>true if the connection is ok or false if the conection fail</returns>
        public Boolean getPing()
        {
            
            Ping p = new Ping();
            String status = p.Send(this.servidor).Status.ToString();
            
            if(status != null)
            {
                this.ping = true;
            }

            return this.ping;
        }


        public Boolean getConnection()
        {

            // llamar al metodo publico getconn

            return this.conn;
        }





    }
}
