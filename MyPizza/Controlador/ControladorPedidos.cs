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

        private List<String> listaParam = new List<String>();
        private List<String> listaValues = new List<String>();

        public ControladorPedidos()
        {
            hreq = new HttpRequest();
        }

        public void limpiarListas()
        {
            this.listaParam.Clear();
            this.listaValues.Clear();
        }


        //--- PEDIDO -------------------------------------------------//


        //this method call the service method listall
        //return null if not found or list pedidoInfo
        public List<PedidoInfo> listarPedidos()
        {
            List<PedidoInfo> listaPedidosInfo = new List<PedidoInfo>();

            try
            {

                String json = hreq.sendRequest("/ServicioMyPizza/servicios/WSPedido/listall");
                listaPedidosInfo = JsonConvert.DeserializeObject<List<PedidoInfo>>(json);
            }
            catch (System.Net.WebException swe)
            {
                listaPedidosInfo = null;
            }                       
            
            return listaPedidosInfo;

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
        

        public double sumarTotal(double num)
        {
            this.total = total + num;
            return this.total; 
        }

        public double restarTotal(double num)
        {
            this.total = total - num;
            return this.total;
        }

        //------------------------------------------------------------//

    }
}
