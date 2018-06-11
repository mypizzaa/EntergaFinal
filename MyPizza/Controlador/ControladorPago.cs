using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Modelo;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControladorPago
    {
        private List<String> listParam = new List<String>();
        private List<String> listValues = new List<String>();
        
        private HttpRequest hreq;

        public ControladorPago()
        {
            hreq = new HttpRequest();
        }

        public void clearList()
        {
            this.listParam.Clear();
            this.listValues.Clear();
        }

        /// <summary>
        /// This method list all method pays
        /// </summary>
        /// <returns>list of method to pay if found if not null</returns>
        public List<MetodoPago> listarMetodos()
        {
            List<MetodoPago> list = null;

            try
            {
                var json = hreq.sendRequest("/ServicioMyPizza/servicios/WSPayMethod/listall");
                list = JsonConvert.DeserializeObject<List<MetodoPago>>(json);

            }
            catch (System.Net.WebException swe)
            {
                list = null;
            }

            return list;
        }
    }
}
