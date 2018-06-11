using Modelo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Controlador
{
    public class ControladorPedidos
    {
        private HttpRequest hreq;

        private double total = 0;

        private List<String> listParam = new List<String>();
        private List<String> listValues = new List<String>();

        public ControladorPedidos()
        {
            hreq = new HttpRequest();
        }

        public void clearLists()
        {
            this.listParam.Clear();
            this.listValues.Clear();
        }


        /// <summary>
        /// This method lista all orders
        /// </summary>
        /// <returns>list of orders info if found, if not return null</returns>
        public List<PedidoInfo> listOrders()
        {
            List<PedidoInfo> listPedidosInfo = new List<PedidoInfo>();

            try
            {

                String json = hreq.sendRequest("/ServicioMyPizza/servicios/WSPedido/listall");
                listPedidosInfo = JsonConvert.DeserializeObject<List<PedidoInfo>>(json);
            }
            catch (System.Net.WebException swe)
            {
                listPedidosInfo = null;
            }                       
            
            return listPedidosInfo;

        }

        //public List<PedidoInfo> buscarPedido(String id)
        //{

        //    //PedidoInfo pi;

        //    //using (WebClient wc = new WebClient())
        //    //{
        //    //    wc.Encoding = System.Text.Encoding.UTF8;
        //    //    String json = wc.DownloadString("http://localhost:8080/ServicioMyPizza/servicios/WSPedido/buscar/"+id);
        //    //    pi = JsonConvert.DeserializeObject<PedidoInfo>(json);

        //    //}

        //    //return pi;
        //}
        
        public void crearPedido()
        {
            //todo
        }

        public void eliminarPedido()
        {
            //todo
        }
        

        public double sumTotal(double num)
        {
            this.total = total + num;
            return this.total; 
        }

        public double resTotal(double num)
        {
            this.total = total - num;
            return this.total;
        }



    }
}
