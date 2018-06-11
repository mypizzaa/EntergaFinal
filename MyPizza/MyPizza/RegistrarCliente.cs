using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class RegistrarCliente : Form
    {
        private String dni;
        private String name;
        private String surname;
        private String email;
        private String phone;
        private String addres1;
        private String addres2;
        private String city;
        private String code_postal;

        private string password;
        private string image;

        private ControladorCliente cc;

        public RegistrarCliente()
        {
            InitializeComponent();
            cc = new ControladorCliente();
        }
           

        /// <summary>
        /// get the data of the textbox
        /// </summary>
        public void getInputs()
        {
            dni = txtDni.Text;
            name = txtNombre.Text;
            surname = txtApellidos.Text;
            email = txtCorreo.Text;
            phone = txtTelefono.Text;
            addres1 = txtDireccion1.Text;
            addres2 = txtDireccion2.Text;
            city = txtCiudad.Text;
            code_postal = txtCodigoPostal.Text;
        }


        public void resetInputs()
        {
            dni = "";
            name = "";
            surname = "";
            email = "";
            phone = "";
            addres1 = "";
            addres2 = "";
            city = "";
            code_postal = "";
        }


        /// <summary>
        /// this method Check that the fields are not empty and if there are format errors
        /// </summary>
        /// <returns></returns>
        public Boolean checkInputs()
        {
            resetInputs();
            getInputs();
            Boolean flag = true;

            if (dni != "" && name != "" && surname != "" && email != "" && phone != "" && addres1 != "" && addres2 != "" && city != "" && code_postal != "")
            {
          
                Boolean inputDni = checkDNI(dni);
                Boolean inputName = IsNumber(name);
                Boolean inputSurname = IsNumber(surname);
                Boolean inputEmail = validarEmail(email);
                Boolean inputTelf = IsNumber(phone);
                Boolean inputCity = IsNumber(city);

            
                if (inputDni != true)
                {
                    Alert("El campo dni no es valido.", "Error");
                    flag = false;
                   
                }
                else if (inputName != false)
                {
                    Alert("El campo nombre no puede contener numeros.", "Error formato");
                    flag = false;
                    
                }
                else if (inputSurname != false)
                {
                    Alert("El campo apellidos no puede contener numeros", "Error formato");
                    flag = false;
                   
                }
                else if (inputEmail != true)
                {
                    Alert("El campo correo no es valido.", "Error correo");
                    flag = false;
                    
                }
                else if (inputTelf != true)
                {
                    Alert("El campo telefono no puede contener letras", "Error formato");
                    flag = false;
                   
                }
                else if (phone.Count() != 9)
                {
                    Alert("El campo telefono no contiene 9 digitos", "Error formato");
                    flag = false;
                  
                }
                else if (inputCity != false)
                {
                    Alert("El campo ciudad no puede contener numeros.", "Error formato");
                    flag = false;
                    
                }else if(code_postal.Count () != 5)
                {
                    Alert("El campo de codigo postal no contiene 5 digitos.","Error formato");
                    flag = false;
                }
            }
            else
            {
                Alert("Porfavor rellene todos los campos.","Campos vacíos");
                flag = false;                
            }
            
            return flag;
        }
        

        //method that chekc if the input text are a number or not
        //Return true if are or false if not.
        public Boolean IsNumber(string input)
        {
            int ejem = 0;
            Boolean sonNumeros = false;

            if (int.TryParse(input, out ejem))
            {
                sonNumeros = true;
            }
            return sonNumeros;
        }

        /// <summary>
        /// This method check if the parameter its a email or not
        /// return true if are if not return false
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        private Boolean validarEmail(string email)
        {
            Boolean valido = false;
            try
            {
                new MailAddress(email);
                valido = true;      
            }
            catch (FormatException) {

                valido = false;
            }
            return valido;
        }
  

        /// <summary>
        /// Method that validate the dni return true if the dni are okey or false if not.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private static bool checkDNI(string data)
        {
            if (data == String.Empty)
                return false;
            try
            {
                String letra;
                letra = data.Substring(data.Length - 1, 1);
                data = data.Substring(0, data.Length - 1);
                int nifNum = int.Parse(data);
                int resto = nifNum % 23;
                string tmp = getLetra(resto);
                if (tmp.ToLower() != letra.ToLower())
                    return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }


        /// <summary>
        /// this method take the letter of the dni
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private static string getLetra(int id)
        {
            Dictionary<int, String> letras = new Dictionary<int, string>();
            letras.Add(0, "T");
            letras.Add(1, "R");
            letras.Add(2, "W");
            letras.Add(3, "A");
            letras.Add(4, "G");
            letras.Add(5, "M");
            letras.Add(6, "Y");
            letras.Add(7, "F");
            letras.Add(8, "P");
            letras.Add(9, "D");
            letras.Add(10, "X");
            letras.Add(11, "B");
            letras.Add(12, "N");
            letras.Add(13, "J");
            letras.Add(14, "Z");
            letras.Add(15, "S");
            letras.Add(16, "Q");
            letras.Add(17, "V");
            letras.Add(18, "H");
            letras.Add(19, "L");
            letras.Add(20, "C");
            letras.Add(21, "K");
            letras.Add(22, "E");
            return letras[id];
        }


        /// <summary>
        /// Close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        /// <summary>
        /// this method register a client and send a message to the email client register with the password generated.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void bGuardar_Click(object sender, EventArgs e)
        {
            
            Boolean flag = checkInputs();

            if (flag == true)
            {
                this.password = CrearPassword(10);
                this.image = null;

                Cliente client = new Cliente(this.dni, this.name, this.surname, this.password, this.image, this.email, this.phone, this.addres1, this.addres2, this.city, this.code_postal);

                int answ = await cc.addClient(client);

                if (answ != -1)
                {
                    MessageBox.Show("Se ha añadido correctamente el cliente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Los datos se guardaran en el pedido.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sendEmailPassword(client);
                    escribirDatosCliente(client); //write the client in the text
                    this.Close();
                }
                else
                {
                    Alert("Hubo un problema al añadir el cliente.", "Error");
                }
            }
            
                        
        }

        /// <summary>
        /// This method send a message by mail to the client who has just registered with the randomly generated password
        /// </summary>
        /// <param name="c">Client</param>
        private void sendEmailPassword(Cliente c)
        {
            MailMessage msg = new MailMessage();
            msg.To.Add(c.getCorreo());
            msg.Subject = "Bienvenido a My pizza !";
            msg.SubjectEncoding = Encoding.UTF8;


            StringBuilder sb = new StringBuilder();
            sb.Append("Bienvenido a My pizza <b>"+c.getNombre()+"</b>, se ha generado una contraseña por defecto. Para utilizar nuestra app tendrás que acceder con la contraseña que te mostraremos a continuación: ");
            sb.Append("<p> Contraseña : <b>"+c.getPassword()+"</b></p>");
            sb.Append("<p>Una vez que haya accedido , podrá modificar su contraseña accediendo al menu superior derecho, en el apartado de configuración/cambiar contraseña.</p>");
            sb.Append("<p>Gracias por su atención.</p>");

            msg.Body = sb.ToString();
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;

            msg.From = new MailAddress("mypizzaspain@gmail.com");
            
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("mypizzaspain@gmail.com", "Atunconpan69");
            client.Port = 587;
            client.EnableSsl = true;
            client.Host = "smtp.gmail.com";

            try
            {
                client.Send(msg);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Alert("No se pudo enviar el correo con la contraseña.","Error");
            }
        }


        /// <summary>
        /// This method creates a random password
        /// </summary>
        /// <param name="longitud">size of the password</param>
        /// <returns>String password</returns>
        public string CrearPassword(int longitud)
        {
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < longitud--)
            {
                res.Append(caracteres[rnd.Next(caracteres.Length)]);
            }
            return res.ToString();
        }


        /// <summary>
        /// Method that shows a message alert
        /// </summary>
        /// <param name="mensaje">string message</param>
        /// <param name="titulo">string title of message</param>
        public void Alert(String mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        /// <summary>
        /// this method writes the client found int a file
        /// </summary>
        /// <param name="c">client</param>
        private void escribirDatosCliente(Cliente c)
        {
            using (StreamWriter sw = new StreamWriter("datosCliente.txt"))
            {
                sw.WriteLine(c.getNombre() + ";" + c.getApellidos() + ";" + c.getPrimeraDireccion() + ";" + c.getSegundaDireccion() + ";" + c.getTelefono() + ";" + c.getCodigoPostal());
            }
        }


    }
}
