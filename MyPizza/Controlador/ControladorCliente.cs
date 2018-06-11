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
        public void clearLists()
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
                clearLists();
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


        /// <summary>
        /// this method add a client
        /// </summary>
        /// <param name="c">Client</param>
        /// <returns></returns>
        public async Task<int> addClient(Cliente c)
        {
            int answ;
                     
            try
            {
                clearLists();
                listParam.Add("dni");
                listParam.Add("name");
                listParam.Add("surname");
                listParam.Add("password");
                listParam.Add("image");
                listParam.Add("email");
                listParam.Add("phone");
                listParam.Add("address1");
                listParam.Add("address2");
                listParam.Add("city");
                listParam.Add("postal_code");

                listValues.Add(c.getDni());
                listValues.Add(c.getNombre());
                listValues.Add(c.getApellidos());
                listValues.Add(c.getPassword());
                listValues.Add(c.getImagen());
                listValues.Add(c.getCorreo());
                listValues.Add(c.getTelefono());
                listValues.Add(c.getPrimeraDireccion());
                listValues.Add(c.getSegundaDireccion());
                listValues.Add(c.getPoblacion());
                listValues.Add(c.getCodigoPostal());

                String json = await hreq.sendRequestPOST("/ServicioMyPizza/servicios/WSCliente/add", listParam, listValues);
                answ = JsonConvert.DeserializeObject<int>(json);


            }
            catch (System.Net.WebException swe)
            {
                answ = 0;
            }
            
            return answ;
        }
    }
}
