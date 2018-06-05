using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class BuscarCliente : Form
    {
        private ControladorCliente cc;

        public BuscarCliente()
        {
            cc = new ControladorCliente();
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            string telefono = txtTelefono.Text;

            if(telefono != null)
            {
                if (telefono.Count() == 9)
                {

                    Boolean sonNumeros = IsNumber(telefono);
                    if (sonNumeros)
                    {
                        this.buscarCliente(telefono);

                    }else
                    {
                        Alert("Poravor introduzca valores numericos.", "Error formato ");
                    }

                }else
                {
                    Alert("Porfavor inserte un numero de 9 digitos.", "Error numero ");
                }

            }else
            {
                Alert("Porfavor inserte un numero de telefono.", "Error formato");
            }
            
        }

        //Metodo que comprueba que el textbox no contenga letras
        public Boolean IsNumber(string txtTelefono)
        {
            int ejem = 0;
            Boolean sonNumeros = false;

            if (int.TryParse(txtTelefono, out ejem))
            {
                sonNumeros = true;
            }

            return sonNumeros;
        }
        
        public void Alert(String mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public async void buscarCliente(String telefono)
        {
            
            Cliente c = await cc.searchClientByPhone(telefono);
            if (c != null)
            {
                MessageBox.Show("Cliente encontrado, los datos se guardaran en el pedido.","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                escribirDatosCliente(c);
            }else
            {
                Alert("No se ha encontrado el cliente","No se encontró");
            }
            
        }

        private void escribirDatosCliente(Cliente c)
        {
            using (StreamWriter sw = new StreamWriter("datosCliente.txt"))
            {
                sw.WriteLine(c.getNombre()+";"+c.getApellidos()+";"+c.getPrimeraDireccion()+";"+c.getTelefono()+";"+c.getCodigoPostal());
            }
        }
    }
}
