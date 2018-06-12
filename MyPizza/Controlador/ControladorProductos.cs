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

        private List<String> listParam = new List<String>();
        private List<String> listValues = new List<String>();


        public ControladorProductos()
        {
            hreq = new HttpRequest();
        }

        //this method clear the lists param and values 
        public void clearLists()
        {
            this.listParam.Clear();
            this.listValues.Clear();
        }



        //--- PIZZAS --------------------------------------------------------------------//

    
        /// <summary>
        /// This method list all pizzas
        /// </summary>
        /// <returns>list pizzas if found if not null</returns>
        public List<Pizza> listAllPizzas()
        {
            List<Pizza> listPizzas = null;

            try
            {
                var json = hreq.sendRequest("/ServicioMyPizza/servicios/WSProducto/pizzas");
                listPizzas = JsonConvert.DeserializeObject<List<Pizza>>(json);

            }
            catch (System.Net.WebException swe)
            {
                listPizzas = null;
            }

            return listPizzas;
        }


        public async Task<int> addPizza(Producto p, List<Ingrediente> iList)
        {
            int added = 0;
            try
            {
                clearLists();
                listParam.Add("name");
                listParam.Add("price");
                listParam.Add("image");
                foreach (Ingrediente i in iList)
                {
                    listParam.Add("idIngredient");
                }

                listValues.Add(p.getNombre());
                listValues.Add(p.getPrecio().ToString());
                listValues.Add(p.getImagen());
                foreach (Ingrediente i in iList)
                {
                    listValues.Add(i.getIdIngrediente().ToString());
                }


                String json = await hreq.sendRequestPOST("/ServicioMyPizza/servicios/WSProducto/addpizza", listParam, listValues);
                added = JsonConvert.DeserializeObject<int>(json);

            }
            catch (System.Net.WebException swe)
            {
                added = 0;
            }

            return added;
        }

        public async Task<int> modificarPizza(Producto p)
        {
            int modificated = 0;
            try
            {
                clearLists();
                listParam.Add("id_product");
                listParam.Add("name");
                listParam.Add("price");
                listParam.Add("image");

                listValues.Add(p.getIdProducto().ToString());
                listValues.Add(p.getNombre());
                listValues.Add(p.getPrecio().ToString());
                listValues.Add(p.getImagen());



                String json = await hreq.sendRequestPOST("/ServicioMyPizza/servicios/WSProducto/modificarproducto", listParam, listValues);
                modificated = JsonConvert.DeserializeObject<int>(json);

            }
            catch (System.Net.WebException swe)
            {
                modificated = 0;
            }

            return modificated;
        }

        public async Task<int> removeIngredientsFromPizza(Pizza p, List<Ingrediente> iList)
        {
            int modificated = 0;
            try
            {
                clearLists();
                listParam.Add("id_pizza");
                foreach (Ingrediente i in iList)
                {
                    listParam.Add("idIngredient");
                }

                listValues.Add(p.getIdPizza().ToString());
                foreach (Ingrediente i in iList)
                {
                    listValues.Add(i.getIdIngrediente().ToString());
                }
                String json = await hreq.sendRequestPOST("/ServicioMyPizza/servicios/WSProducto/eliminaringredientspizza", listParam, listValues);
                modificated = JsonConvert.DeserializeObject<int>(json);

            }
            catch (System.Net.WebException swe)
            {
                modificated = 0;
            }

            return modificated;
        }

        public async Task<int> addIngredientsToPizza(Pizza p, List<Ingrediente> iList)
        {
            int modificated = 0;
            try
            {
                clearLists();
                listParam.Add("id_pizza");
                foreach (Ingrediente i in iList)
                {
                    listParam.Add("idIngredient");
                }

                listValues.Add(p.getIdPizza().ToString());
                foreach (Ingrediente i in iList)
                {
                    listValues.Add(i.getIdIngrediente().ToString());
                }

                String json = await hreq.sendRequestPOST("/ServicioMyPizza/servicios/WSProducto/addingredientespizza", listParam, listValues);
                modificated = JsonConvert.DeserializeObject<int>(json);

            }
            catch (System.Net.WebException swe)
            {
                modificated = 0;
            }

            return modificated;
        }


        /// <summary>
        /// This method return the ingredients of the id pizza that recives by parameter
        /// </summary>
        /// <param name="idPizza">String idPizza</param>
        /// <returns>list ingredients if found if not null</returns>
        public List<Ingrediente> listIngredientsOfPizza(String idPizza)
        {
            List<Ingrediente> listIngredients;

            try
            {
                String json = hreq.sendRequest("/ServicioMyPizza/servicios/WSProducto/ingredientespizza/" + idPizza);
                listIngredients = JsonConvert.DeserializeObject<List<Ingrediente>>(json);

            }
            catch (System.Net.WebException swe)
            {
                listIngredients = null;
            }

            return listIngredients;
        }

        /// <summary>
        /// This method search a pizza by name
        /// </summary>
        /// <param name="namePizza">name of pizza</param>
        /// <returns>One pizza if was found or return null if don't exist</returns>
        public async Task<Pizza> searchPizzaByName(String namePizza)
        {
            Pizza pizza = null;

            try
            {
                clearLists();
                listParam.Add("name");
                listValues.Add(namePizza);

                String json = await hreq.sendRequestPOST("/ServicioMyPizza/servicios/WSProducto/buscarpizza", listParam, listValues);
                pizza = JsonConvert.DeserializeObject<Pizza>(json);

            }
            catch (System.Net.WebException swe)
            {
                pizza = null;
            }

            return pizza;
        }

        public async Task<int> eliminarPizza(Pizza p)
        {
            int eliminado = 0;
            try
            {
                clearLists();
                listParam.Add("id_pizza");
                listValues.Add(p.getIdPizza().ToString());



                String json = await hreq.sendRequestPOST("/ServicioMyPizza/servicios/WSProducto/eliminarpizza", listParam, listValues);
                eliminado = JsonConvert.DeserializeObject<int>(json);

            }
            catch (System.Net.WebException swe)
            {
                eliminado = 0;
            }

            return eliminado;
        }


        //--- INGREDIENTES ----------------------------------------------------------------//

        //this method call the service method listall and lista all ingredients
        //return null if not found else return list of ingredients      
        public List<Ingrediente> listAllIngredients()
        {

            List<Ingrediente> listIngredients;

            try
            {

                String json = hreq.sendRequest("/ServicioMyPizza/servicios/WSProducto/ingredientes");
                listIngredients = JsonConvert.DeserializeObject<List<Ingrediente>>(json);

            }
            catch (System.Net.WebException swe)
            {
                listIngredients = null;
            }

            return listIngredients;
        }

        /// <summary>
        /// This method add a new ingredient in database
        /// </summary>
        /// <param name="i"></param>
        /// <returns>0 if ingredient not added or 1 if ingredient added succesfully</returns>
        public async Task<int> addIngredient(Ingrediente i)
        {
            int added = 0;
            try
            {
                clearLists();
                listParam.Add("name");
                listParam.Add("price");
                listParam.Add("image");

                listValues.Add(i.getNombre());
                listValues.Add(i.getPrecio().ToString());
                listValues.Add(i.getImagen());


                String json = await hreq.sendRequestPOST("/ServicioMyPizza/servicios/WSProducto/addingrediente", listParam, listValues);
                added = JsonConvert.DeserializeObject<int>(json);

            }
            catch (System.Net.WebException swe)
            {
                added = 0;
            }
            return added;
        }

        /// <summary>
        /// this method modify a ingredient
        /// </summary>
        /// <param name="i">ingredient</param>
        /// <returns>0 if not modificated of 1 if modificated successfully</returns>
        public async Task<int> modificarIngrediente(Ingrediente i)
        {
            int modificated = 0;
            try
            {
                clearLists();
                listParam.Add("id_product");
                listParam.Add("name");
                listParam.Add("price");
                listParam.Add("image");

                listValues.Add(i.getIdProducto().ToString());
                listValues.Add(i.getNombre());
                listValues.Add(i.getPrecio().ToString());
                listValues.Add(i.getImagen());



                String json = await hreq.sendRequestPOST("/ServicioMyPizza/servicios/WSProducto/modificarproducto", listParam, listValues);
                modificated = JsonConvert.DeserializeObject<int>(json);

            }
            catch (System.Net.WebException swe)
            {
                modificated = 0;
            }

            return modificated;
        }



        public async Task<int> eliminarIngrediente(Ingrediente i)
        {
            int eliminado = 0;
            try
            {
                clearLists();
                listParam.Add("id_ingredient");

                listValues.Add(i.getIdIngrediente().ToString());



                String json = await hreq.sendRequestPOST("/ServicioMyPizza/servicios/WSProducto/eliminaringredient", listParam, listValues);
                eliminado = JsonConvert.DeserializeObject<int>(json);

            }
            catch (System.Net.WebException swe)
            {
                eliminado = 0;
            }
            return eliminado;
        }

        public async Task<Ingrediente> searchIngredientByName(String nombre)
        {
            Ingrediente i = null;

            try
            {
                clearLists();
                listParam.Add("name");
                listValues.Add(nombre);

                String json = await hreq.sendRequestPOST("/ServicioMyPizza/servicios/WSProducto/buscaringrediente", listParam, listValues);
                i = JsonConvert.DeserializeObject<Ingrediente>(json);

            }
            catch (System.Net.WebException swe)
            {
                i = null;
            }

            return i;
        }


        //--- BEBIDAS --------------------------------------------------------------------//

        /// <summary>
        /// this method lista all drinks
        /// </summary>
        /// <returns>list of drinks if found and null if not</returns>
        public List<Refresco> listAllDrinks()
        {
            List<Refresco> listDrinks;

            try
            {
                String json = hreq.sendRequest("/ServicioMyPizza/servicios/WSProducto/bebidas");
                listDrinks = JsonConvert.DeserializeObject<List<Refresco>>(json);

            }
            catch (System.Net.WebException swe)
            {
                listDrinks = null;
            }
 
            return listDrinks;
        }

        /// <summary>
        /// This method add a new refresh in database if something fall, return 0
        /// </summary>
        /// <param name="r"></param>
        /// <returns> 0 if refresh is not added succesfully or return 1 if refresh is added succesfully</returns>
        public async Task<int> addDrink(Refresco r)
        {
            int added = 0;
            try
            {
                clearLists();
                listParam.Add("name");
                listParam.Add("price");
                listParam.Add("image");

                listValues.Add(r.getNombre());
                listValues.Add(r.getPrecio().ToString());
                listValues.Add(r.getImagen());


                String json = await hreq.sendRequestPOST("/ServicioMyPizza/servicios/WSProducto/addbebida", listParam, listValues);
                added = JsonConvert.DeserializeObject<int>(json);

            }
            catch (System.Net.WebException swe)
            {
                added = 0;
            }

            return added;
        }

        public void modifyDrink(Refresco r)
        {

        }

        public void removeDrink(Refresco r)
        {

        }

        /// <summary>
        /// this method search a drink by name
        /// </summary>
        /// <param name="nombreRefresco">string name of drink</param>
        /// <returns>null if not found and a drink if found</returns>
        public async Task<Refresco> searchDrinkByName(String nombreRefresco)
        {
            Refresco r = null;
            try
            {
                clearLists();
                listParam.Add("name");
                listValues.Add(nombreRefresco);

                String json = await hreq.sendRequestPOST("/ServicioMyPizza/servicios/WSProducto/buscarbebida", listParam, listValues);
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