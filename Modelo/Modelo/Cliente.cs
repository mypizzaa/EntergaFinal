using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cliente : Usuario
    {
        public long id_cliente;
        public String telefono;
        public String primeraDireccion;
        public String segundaDireccion;
        public String poblacion;
        public String codigoPostal;

        public Cliente()
        {

        }
        public Cliente(long id_cliente,String telefono, String primeraDireccion, string segundaDireccion,String poblacion, String codigo_postal, long id_usuario, String dni, String nombre, String apellidos, String password, String imagen, String tipo_Usuario, String correo, int activo) : base(id_usuario, dni, nombre, apellidos, password, imagen, tipo_Usuario, correo, activo)
        {
            this.id_cliente = id_cliente;
            this.telefono = telefono;
            this.primeraDireccion = primeraDireccion;
            this.segundaDireccion = segundaDireccion;            
            this.poblacion = poblacion;
            this.codigoPostal = codigo_postal;
        }

        //getters
        public long getIdCliente()
        {
            return this.id_cliente;
        }

        public String getPrimeraDireccion()
        {
            return this.primeraDireccion;
        }

        public String getSegundaDireccion()
        {
            return this.segundaDireccion;
        }

        public String getTelefono()
        {
            return this.telefono;
        }

        public String getPoblacion()
        {
            return this.poblacion;
        }

        public String getCodigoPostal()
        {
            return this.codigoPostal;
        }

        //setters
        public void setIdCliente(long idcliente)
        {
            this.id_cliente = idcliente;
        }

        public void setPrimeraDireccion(String direccion)
        {
            this.primeraDireccion = direccion;
        }

        public void setSegundaDireccion(String direccion)
        {
            this.segundaDireccion = direccion;
        }

        public void setTelefono(String telefono)
        {
            this.telefono = telefono;
        }

        public void setPoblacion(String poblacion)
        {
            this.poblacion = poblacion;
        }

        public void setCodigoPostal(String codigop)
        {
            this.codigoPostal = codigop;
        }


        //toString
        public String toString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("id_cliente = " + id_cliente);
            sb.Append(" ,primeraDireccion =  " + primeraDireccion);
            sb.Append(" ,segundaDireccion = " + segundaDireccion);
            sb.Append(" ,telefono = " + telefono);
            sb.Append(" ,poblacion = " + poblacion);
            sb.Append(" ,codigo postal = "+codigoPostal);
            sb.Append(base.toString());

            return sb.ToString();
        }


    }
}
