using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Factura
    {
        private long id_factura;
        private DateTime fecha;
        private long id_cliente;
        private long id_metodoPago;
        private Boolean cobrado;

        //Constructor
        public Factura(long id_factura, DateTime fecha, long id_cliente, long id_metodoPago, Boolean cobrado)
        {
            this.id_factura = id_factura;
            this.fecha = fecha;
            this.id_cliente = id_cliente;
            this.id_metodoPago = id_metodoPago;
            this.cobrado = cobrado;
        }

        //Getters
        public long getIdFactura()
        {
            return this.id_factura;
        }
        public DateTime getFecha()
        {
            return this.fecha;
        }
        public long getIdCliente()
        {
            return this.id_cliente;
        }
        public long getIdMetodoPago()
        {
            return this.id_metodoPago;
        }
        public Boolean getCobrado()
        {
            return this.cobrado;
        }

        //Setters
        public void setIdFactura(long idfactura)
        {
            this.id_factura = idfactura;
        }
        public void setFecha(DateTime fecha)
        {
            this.fecha = fecha;
        }

        public void setIdCliente(long idcliente)
        {
            this.id_cliente = idcliente;
        }

        public void setIdMetodoPago(long idMetodo)
        {
            this.id_metodoPago = idMetodo;
        }
        
        public void setCobrado(Boolean cobrado)
        {
            this.cobrado = cobrado;
        }

        //toString

        public String toString()
        {
            return "";
        }




    }
}
