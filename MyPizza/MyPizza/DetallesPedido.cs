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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class DetallesPedido : Form
    {
        private ControladorPago cp;
        private List<MetodoPago> mpList = null;

        String linea;

        public DetallesPedido()
        {
            cp = new ControladorPago();
            InitializeComponent();
            cargarDatosCliente();
            loadPayMethods();
            txtDetalles.Enabled = false;
           
        }

        private void loadPayMethods()
        {
            mpList = cp.listarMetodos();
            foreach (MetodoPago mp in mpList)
            {
                cbPago.Items.Add(mp.getNombre());
            }

        }

        public void cargarDatosCliente()
        {
            try
            {
                String linea = "";

                using (StreamReader sr = new StreamReader("datosCliente.txt"))
                {
                    while ((linea = sr.ReadLine()) != null)
                    {
                        this.linea = linea;
                    }
                }
            }
            catch (FileNotFoundException fnf)
            {
                MessageBox.Show("No se pudo cargar los datos del cliente","Error");
            }

            String []datos = linea.Split(';');

            txtNombre.Text = datos[0];
            txtApellidos.Text = datos[1];
            txtDireccion1.Text = datos[2];
            txtDireccion2.Text = datos[3];
            txtTelefono.Text = datos[4];
            txtCodigoPostal.Text = datos[5];

            DateTime localDate = DateTime.Now;
            txtDiaHora.Text = localDate.ToString();

        }


        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DetallesPedido_Load(object sender, EventArgs e)
        {

        }

        private void cbPago_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtDetalles.Text = mpList[cbPago.SelectedIndex].getDetalles();
            MessageBox.Show(mpList[cbPago.SelectedIndex].getDetalles());

        }

        private void bAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
