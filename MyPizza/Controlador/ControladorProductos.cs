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
    public class ControladorProductos
    {

        private HttpRequest hreq;

        private List<String> listaParam = new List<String>();
        private List<String> listaValues = new List<String>();


        public ControladorProductos()
        {
            hreq = new HttpRequest();
        }

        //this method clear the lists param and values 
        public void limpiarListas()
        {
            this.listaParam.Clear();
            this.listaValues.Clear();
        }



        //--- PIZZAS --------------------------------------------------------------------//

        // this method call the service method listall and list all pizzas
        // return null if not found else return list of pizzas
        public List<Pizza> listarPizzas()
        {
            List<Pizza> listaPizzas = null;

            try
            {
                var json = hreq.sendRequest("/ServicioMyPizza/servicios/WSProducto/pizzas");
                listaPizzas = JsonConvert.DeserializeObject<List<Pizza>>(json);

            }
            catch (System.Net.WebException swe)
            {
                listaPizzas = null;
            }

            return listaPizzas;
        }

        public void agregarPizza(String nombre, List<Ingrediente> listaIngredientes)
        {

        }

        public void modificarPizza(Pizza p)
        {

        }

        public void eliminarPizza(Pizza p)
        {

        }

        public List<Ingrediente> listarIngredientesPizza(String idPizza)
        {
            List<Ingrediente> listaIngredientes;

            try
            {
                String json = hreq.sendRequest("/ServicioMyPizza/servicios/WSProducto/ingredientespizza/" + idPizza);
                listaIngredientes = JsonConvert.DeserializeObject<List<Ingrediente>>(json);

            }
            catch (System.Net.WebException swe)
            {
                listaIngredientes = null;
            }

            return listaIngredientes;
        }

        /// <summary>
        /// This method search a pizza by name
        /// </summary>
        /// <param name="nombrePizza"></param>
        /// <returns>a pizza if was found or return null if don't exist</returns>
        public async Task<Pizza> buscarPizzaPorNombre(String nombrePizza)
        {
            Pizza pizza = null;

            try
            {
                limpiarListas();
                listaParam.Add("name");
                listaValues.Add(nombrePizza);

                String json = await hreq.sendRequestPOST("/ServicioMyPizza/servicios/WSProducto/buscarpizza", listaParam, listaValues);
                pizza = JsonConvert.DeserializeObject<Pizza>(json);

            }
            catch (System.Net.WebException swe)
            {
                pizza = null;
            }
            return pizza;
        }


        //--- INGREDIENTES ----------------------------------------------------------------//

        //this method call the service method listall and lista all ingredients
        //return null if not found else return list of ingredients      
        public List<Ingrediente> listarIngredientes()
        {

            List<Ingrediente> listaIngredientes;

            try
            {

                String json = hreq.sendRequest("/ServicioMyPizza/servicios/WSProducto/ingredientes");
                listaIngredientes = JsonConvert.DeserializeObject<List<Ingrediente>>(json);

            }
            catch (System.Net.WebException swe)
            {
                listaIngredientes = null;
            }

            return listaIngredientes;
        }

        /// <summary>
        /// This method add a new ingredient in database
        /// </summary>
        /// <param name="i"></param>
        /// <returns>0 if ingredient is not added succesfully or return 1 if ingredient is added succesfully</returns>
        public async Task<int> agregarIngrediente(Ingrediente i)
        {
            int agregado = 0;
            try
            {
                limpiarListas();
                listaParam.Add("name");
                listaParam.Add("price");
                listaParam.Add("image");

                listaValues.Add(i.getNombre());
                listaValues.Add(i.getPrecio().ToString());
                listaValues.Add(i.getImagen());


                String json = await hreq.sendRequestPOST("/ServicioMyPizza/servicios/WSProducto/addingrediente", listaParam, listaValues);
                agregado = JsonConvert.DeserializeObject<int>(json);

            }
            catch (System.Net.WebException swe)
            {
                agregado = 0;
            }
            return agregado;
        }

        public async Task<int> modificarIngrediente(Ingrediente i)
        {
            int modificado = 0;
            try
            {
                limpiarListas();
                listaParam.Add("id_product");
                listaParam.Add("name");
                listaParam.Add("price");
                listaParam.Add("image");

                listaValues.Add(i.getIdProducto().ToString());
                listaValues.Add(i.getNombre());
                listaValues.Add(i.getPrecio().ToString());
                listaValues.Add(i.getImagen());



                String json = await hreq.sendRequestPOST("/ServicioMyPizza/servicios/WSProducto/modificarproducto", listaParam, listaValues);
                modificado = JsonConvert.DeserializeObject<int>(json);

            }
            catch (System.Net.WebException swe)
            {
                modificado = 0;
            }
            return modificado;
        }

        public async Task<int> eliminarIngrediente(Ingrediente i)
        {
            int eliminado = 0;
            try
            {
                limpiarListas();
                listaParam.Add("id_ingredient");

                listaValues.Add(i.getIdIngrediente().ToString());



                String json = await hreq.sendRequestPOST("/ServicioMyPizza/servicios/WSProducto/eliminaringredient", listaParam, listaValues);
                eliminado = JsonConvert.DeserializeObject<int>(json);

            }
            catch (System.Net.WebException swe)
            {
                eliminado = 0;
            }
            return eliminado;
        }

        public async Task<Ingrediente> buscarIngredientePorNombre(String nombre)
        {
            Ingrediente i = null;

            try
            {
                limpiarListas();
                listaParam.Add("name");
                listaValues.Add(nombre);

                String json = await hreq.sendRequestPOST("/ServicioMyPizza/servicios/WSProducto/buscaringrediente", listaParam, listaValues);
                i = JsonConvert.DeserializeObject<Ingrediente>(json);

            }
            catch (System.Net.WebException swe)
            {
                i = null;
            }
            return i;
        }


        //--- BEBIDAS --------------------------------------------------------------------//

        //Lista all drinks
        //return null if not found else return list of drinks
        public List<Refresco> listarRefrescos()
        {
            List<Refresco> listaBebidas;

            try
            {
                String json = hreq.sendRequest("/ServicioMyPizza/servicios/WSProducto/bebidas");
                listaBebidas = JsonConvert.DeserializeObject<List<Refresco>>(json);

            }
            catch (System.Net.WebException swe)
            {
                listaBebidas = null;
            }

            return listaBebidas;
        }

        /// <summary>
        /// This method add a new refresh in database if something fall, return 0
        /// </summary>
        /// <param name="r"></param>
        /// <returns> 0 if refresh is not added succesfully or return 1 if refresh is added succesfully</returns>
        public async Task<int> agregarBebida(Refresco r)
        {
            int agregado = 0;
            try
            {
                limpiarListas();
                listaParam.Add("name");
                listaParam.Add("price");
                listaParam.Add("image");

                listaValues.Add(r.getNombre());
                listaValues.Add(r.getPrecio().ToString());
                listaValues.Add(r.getImagen());


                String json = await hreq.sendRequestPOST("/ServicioMyPizza/servicios/WSProducto/addbebida", listaParam, listaValues);
                agregado = JsonConvert.DeserializeObject<int>(json);

            }
            catch (System.Net.WebException swe)
            {
                agregado = 0;
            }
            return agregado;
        }

        public void modificarBebida(Refresco r)
        {

        }

        public void eliminarBebida(Refresco r)
        {

        }

        /// <summary>
        /// this method assigns the received parameter to a list and sends it by post, and that information
        /// is collected in a string, that string is serialized to a refresh, if the refresh has not been found, it
        /// returns null, if it does not return the refresh
        /// </summary>
        /// <param name="nombreRefresco"></param>
        /// <returns></returns>
        public async Task<Refresco> buscarRefrescoPorNombre(String nombreRefresco)
        {
            Refresco r = null;
            try
            {
                limpiarListas();
                listaParam.Add("name");
                listaValues.Add(nombreRefresco);

                String json = await hreq.sendRequestPOST("/ServicioMyPizza/servicios/WSProducto/buscarbebida", listaParam, listaValues);
                r = JsonConvert.DeserializeObject<Refresco>(json);

            }
            catch (System.Net.WebException swe)
            {
                r = null;
            }
            return r;
        }

    }
}