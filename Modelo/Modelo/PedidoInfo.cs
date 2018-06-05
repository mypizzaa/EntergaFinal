using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class PedidoInfo
    {
        public long id_pedido_info;
        public long id_estado;
        public String direccion;
        public PedidoInfo()
        {

        }
        public PedidoInfo(long id_pedido_info, long id_estado, String direccion)
        {
            this.id_pedido_info = id_pedido_info;
            this.id_estado = id_estado;
            this.direccion = direccion;
        }

        public PedidoInfo(String direccion, String dia_hora, long id_cliente)
        {
            this.direccion = direccion;
        }

        

        public PedidoInfo(long id_pedido)
        {
            this.id_pedido_info = id_pedido;
        }

        //--------------------------------------------------------------------------

        public long getId_pedido_info()
        {
            return id_pedido_info;
        }

        public void setId_pedido_info(long id_pedido_info)
        {
            this.id_pedido_info = id_pedido_info;
        }

        public long getId_estado()
        {
            return id_estado;
        }

        public void setId_estado(long id_estado)
        {
            this.id_estado = id_estado;
        }

        public String getDireccion()
        {
            return direccion;
        }

        public void setDireccion(String direccion)
        {
            this.direccion = direccion;
        }

        public String toString()
        {
            return "PedidoInfo{" + "id_pedido_info=" + id_pedido_info + ", id_estado=" + id_estado + ", direccion=" + direccion + '}';
        }
    }
}
