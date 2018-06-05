using Modelo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControladorCliente
    {
        private List<String> listParam = new List<String>();
        private List<String> listValues = new List<String>();

        private HttpRequest hreq;

        public ControladorCliente()
        {
           hreq = new HttpRequest();
        }


        /// <summary>
        /// Clear the list param and list values
        /// </summary>
        public void ClearLists()
        {
            this.listParam.Clear();
            this.listValues.Clear();
        }

        /// <summary>
        /// This method searcha client by phone
        /// </summary>
        /// <param name="telefono">String telf</param>
        /// <returns>client if found or null if not</returns>
        public async Task<Cliente> searchClientByPhone(String telefono)
        {
            Cliente c = null;
             
            try
            {
                ClearLists();
                listParam.Add("phone");
                listValues.Add(telefono);
                
                String json = await hreq.sendRequestPOST("/ServicioMyPizza/servicios/WSCliente/searchphone", listParam, listValues);               
                c = JsonConvert.DeserializeObject<Cliente>(json);

            }
            catch (System.Net.WebException swe)
            {
                c = null;    
            }
        

            return c;
        }

    }
}
