using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Producto
    {
        public long id_producto;
        public String nombre;
        public double precio;
        public String imagen;
        public long id_tipo;
        

        public Producto()
        {

        }
        //Constructores
        public Producto(long id_prod, String nombre, double precio, String img, long id_tip)
        {
            this.id_producto = id_prod;
            this.nombre = nombre;
            this.precio = precio;
            this.imagen = img;
            this.id_tipo = id_tip;
        }

        public Producto(String nombre)
        {
            this.nombre = nombre;
        }

        public Producto(long id_producto, string nombre, double precio, string imagen)
        {
            this.id_producto = id_producto;
            this.nombre = nombre;
            this.precio = precio;
            this.imagen = imagen;
        }

        //Getters
        public long getIdProducto()
        {
            return this.id_producto;
        }

        public String getNombre()
        {
            return this.nombre;
        }

        public double getPrecio()
        {
            return this.precio;
        }

        public String getImagen()
        {
            return this.imagen;
        }

        public long getIdTipo()
        {
            return this.id_tipo;
        }

        //Setters
        public void setIdProduct(long idProd)
        {
            this.id_producto = idProd;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public void setPrecio(double precio)
        {
            this.precio = precio;
        }

        public void setImagen(String img)
        {
            this.imagen = img;
        }

        public void setIdTipo(long idTipo)
        {
            this.id_tipo = idTipo;
        }


        //ToString
        public String toString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Producto [");
            sb.Append(" id_producto = "+id_producto);
            sb.Append(", nombre = "+nombre);
            sb.Append(", precio = "+precio);
            sb.Append(", imagen = "+imagen);
            sb.Append(", id_tipo = "+id_tipo);
            sb.Append(" ]");

            return sb.ToString();
        }




    }
}
