using Modelo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControladorEmpleados
    {
        private HttpRequest hreq;
        private List<String> listParam = new List<String>();
        private List<String> listValues = new List<String>();

        public ControladorEmpleados()
        {
            hreq = new HttpRequest();
        }

            
        /// <summary>
        /// Clean the list param and list values
        /// </summary>
        public void clearLists()
        {
            this.listParam.Clear();
            this.listValues.Clear();
        }

        /// <summary>
        /// This method list all employees
        /// </summary>
        /// <returns>List employees if found or null if not</returns>
        public List<Empleado> listAllEmployees()
        {
            List<Empleado> listEmployee;
            try
            {
                String json = hreq.sendRequest("/ServicioMyPizza/servicios/WSEmpleado/listall");
                listEmployee = JsonConvert.DeserializeObject<List<Empleado>>(json);
            }
            catch (System.Net.WebException swe)
            {
                listEmployee = null;
            }
            return listEmployee;

        }

        /// <summary>
        /// This method search a employee that has the same dni as the parameter
        /// </summary>
        /// <param name="dni">String dni</param>
        /// <returns>Employe if found if not null</returns>
        public async Task<Empleado> searchEmployeeByDni(String dni)
        {
            Empleado e = null;
            try
            {
                clearLists();
                this.listParam.Add("dni");
                this.listValues.Add(dni);

                var json = await hreq.sendRequestPOST("/ServicioMyPizza/servicios/WSEmpleado/search/", listParam, listValues);

                e = JsonConvert.DeserializeObject<Empleado>(json);
            }
            catch (System.Net.WebException swe)
            {
                e = null;
            }

            return e;

        }

   
        /// <summary>
        /// This method search the employe that has the same dni that parameter and change the value alta by 1.
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        public async Task<Empleado> registerEmployee(String dni)
        {
            Empleado e = null;
            try
            {
                e = await searchEmployeeByDni(dni);
                if (e == null)
                {
                    clearLists();
                    this.listParam.Add("dni");
                    this.listValues.Add(dni);

                    var json = await hreq.sendRequestPOST("/ServicioMyPizza/servicios/WSEmpleado/search/", listParam, listValues);

                    e = JsonConvert.DeserializeObject<Empleado>(json);
                }

            }
            catch (System.Net.WebException swe)
            {
                e = null;
            }
            return e;
        }


        /// <summary>
        /// This method unsubscribe an employee
        /// </summary>
        public void unsubscribeEmployee()
        {
            
        }

        /**
        * Receive an employee and assign the parameters for the post method with your requests
        * if it returns a 2, it is that the changes have gone well, if it is different that the pet is not well
         */
        public async Task<Boolean> modificarEmpleadoAsync(Empleado emp)
        {
            Boolean b = false;
            try
            {
                clearLists();
                this.listParam.Add("id"); this.listValues.Add(emp.getIdEmpleado().ToString());

                String horaEntrada = emp.getHoraEntrada().ToString();
                String[] substrings = horaEntrada.Split(' ');

                this.listParam.Add("in_hour"); this.listValues.Add(substrings[1]);

                String horaSalida = emp.getHoraEntrada().ToString();
                String[] substrings2 = horaSalida.Split(' ');


                this.listParam.Add("out_hour"); this.listValues.Add(substrings2[1]);
                this.listParam.Add("week_hours"); this.listValues.Add(emp.getHorasSemanales().ToString());
                this.listParam.Add("salary"); this.listValues.Add(emp.getSalario().ToString());
                this.listParam.Add("dni"); this.listValues.Add(emp.getDni());
                this.listParam.Add("name"); this.listValues.Add(emp.getNombre());
                this.listParam.Add("surname"); this.listValues.Add(emp.getApellidos());
                this.listParam.Add("password"); this.listValues.Add(emp.getPassword());
                this.listParam.Add("image"); this.listValues.Add(emp.getImagen());
                this.listParam.Add("type_user"); this.listValues.Add(emp.getTipoUsuario());
                this.listParam.Add("email"); this.listValues.Add(emp.getCorreo());


                var json = await hreq.sendRequestPOST("/ServicioMyPizza/servicios/WSEmpleado/update/", this.listParam, this.listValues);
                if (json.ToString().Equals("2"))
                {
                    b = true;
                }
            }
            catch (System.Net.WebException swe)
            {
                b = false;
            }
            return b;
        }


    }
}