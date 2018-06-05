using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{

    public class Ingrediente : Producto
    {
        public long id_ingrediente;
    
        //constructor
        public Ingrediente(long id_prod, string nombre, double precio, string img, long id_tip, long id_ingrediente) : base(id_prod, nombre, precio, img, id_tip)
        {
            this.id_ingrediente = id_ingrediente;
        }

        public Ingrediente(long id_prod, string nombre, double precio, string img) : base(id_prod, nombre, precio, img)
        {
            this.id_ingrediente = id_ingrediente;
        }

        public Ingrediente() { }

        public Ingrediente(long id_ingrediente) {
            this.id_ingrediente = id_ingrediente;
        }

        //Getters
        public long getIdIngrediente()
        {
            return this.id_ingrediente;
        }

        public Ingrediente(String nombre, double precio, String imagen)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.imagen = imagen;
        }

        //Setter
        public void setIdIngrediente(long idIngrediente)
        {
            this.id_ingrediente = idIngrediente;
        }

       //toString
       public String toString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("id_ingrediente = " + id_ingrediente);
            sb.Append(base.toString());

            return sb.ToString();
        }


    }
}
