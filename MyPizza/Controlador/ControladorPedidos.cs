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


        public async Task<int> crearPedido(string direccion, long client_id, long paymethod_id, double total, String datetime)
        {
            int id_pedido_info = 0;

            try
            {

                clearLists();
                listParam.Add("address");
                listParam.Add("client_id");
                listParam.Add("payMethod_id");
                listParam.Add("total_price");
                listParam.Add("date_time");
                
                listValues.Add(direccion);
                listValues.Add(client_id.ToString());
                listValues.Add(paymethod_id.ToString());
                listValues.Add(total.ToString());
                listValues.Add(datetime);
                

                String json = await hreq.sendRequestPOST("/ServicioMyPizza/servicios/WSPedido/createorder", listParam, listValues);
                id_pedido_info = JsonConvert.DeserializeObject<int>(json);
            }
            catch (System.Net.WebException swe)
            {
                id_pedido_info = 0;
            }

            return id_pedido_info;




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
