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
        private List<String> listaParam = new List<String>();
        private List<String> listaValues = new List<String>();


        private HttpRequest hreq;

        public ControladorPago()
        {
            hreq = new HttpRequest();
        }

        public void limpiarListas()
        {
            this.listaParam.Clear();
            this.listaValues.Clear();
        }

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
