using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class AdminBebidas : Form
    {

        private ControladorProductos cp;
        private ControladorServicio cs;

        Boolean service;

        String nombreBoton= "";

        private String nombreBebida;
        private String precio;
        private String imagen;

        /// <summary>
        /// Constructor
        /// </summary>
        public AdminBebidas()
        {
            cp = new ControladorProductos();
            cs = new ControladorServicio();

            InitializeComponent();

            service = cs.getPing();

            if (service != false)
            {
                cargarBebidas();

            }else
            {
                ErrorServicio es = new ErrorServicio();
                es.ShowDialog();
            }

        }

        /// <summary>
        /// This method load all drinks to the listViewBebidas
        /// </summary>
        public void cargarBebidas()
        {
            List<Refresco> listaBebidas = cp.listarRefrescos();

            foreach (Refresco r in listaBebidas)
            {
                listViewBebidas.Items.Add(r.getNombre());
            }
            
        }


        /// <summary>
        /// Este metodo abre un open file dialog para seleccionar una imagen y ponerla en le picture box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bAñadirImagen_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "png(*.png)|*.png|jpg(*.jpg)|*.jpg";
            openFileDialog1.FileName = "";

            //Abre el openfile y comprueba que se ha cerrado.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }


        /// <summary>
        /// This method save the select item from listview and put the name, image and price in the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void listViewBebidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBebidas.SelectedItems.Count > 0)
            {
                ListViewItem listItem = listViewBebidas.SelectedItems[0];
                String nombreBebida = listItem.Text;
                txtBebida.Text = nombreBebida;


                Refresco r= await cp.buscarRefrescoPorNombre(nombreBebida);
                
                txtPrecio.Text = r.getPrecio().ToString();

                String pathImage = r.getImagen();
                pictureBox1.ImageLocation = "http://provenapps.cat/~dam1804/Images/bebidas/" + pathImage;

            }
        }


        //boton guardar
        private async void bGuardar_Click(object sender, EventArgs e)
        {
            if (nombreBoton != null)
            {
                switch (this.nombreBoton)
                {
                    case "bNuevo":

                        int answ = await guardarBebida(this.nombreBebida, this.precio, this.imagen);

                        if (answ != 0)
                        {
                            ShowMessage("Se ha añadido correctamente el refresco", "Correcto");
                        }
                        else
                        {
                            Alert("Ha habido un problema al añadir el refresco", "Error");
                        }

                        break;

                    case "bModificar":


                        break;

                    case "bEliminar":


                        break;
                }
            }else
            {
                Alert("Nombre del boton vacio","Error");
            }

            bGuardar.Visible = false;
            bCancelar.Visible = false;

            resetearCampos();
            desactivarCampos();
            mostrarBotones();

        }



        /// <summary>
        /// This method put reset the form and put the button guardar visible and the buton nuevo not visible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void bNuevo_Click(object sender, EventArgs e)
        {
            activarCampos();
            ocultarBotones();
            resetearCampos();

            this.nombreBoton = bNuevo.Name;

            bCancelar.Visible = true;
            bGuardar.Visible = true;

            this.nombreBebida = txtBebida.Text;
            this.precio = txtPrecio.Text;
            this.imagen = null;
            
           
        }
              

        //boton modificar
        private void bModificar_Click(object sender, EventArgs e)
        {
            activarCampos();
        }

        //boton eliminar
        private void bEliminar_Click(object sender, EventArgs e)
        {

        }
             

        //boton cancelar
        private void bCancelar_Click(object sender, EventArgs e)
        {
            desactivarCampos();
            bCancelar.Visible = false;
        }
        
        /// <summary>
        /// Active components
        /// </summary>
        public void activarCampos()
        {
            pictureBox1.Enabled = true;
            txtBebida.Enabled = true;
            txtPrecio.Enabled = true;
            bAñadirImagen.Visible = true;
        }
        /// <summary>
        /// Deactivate components
        /// </summary>
        public void desactivarCampos()
        {
            pictureBox1.Enabled = false;
            txtBebida.Enabled = false;
            txtPrecio.Enabled = false;
            bAñadirImagen.Visible = false;
        }

        /// <summary>
        /// Reset components
        /// </summary>
        public void resetearCampos()
        {
            pictureBox1.Image = null;
            txtBebida.Text = "";
            txtPrecio.Text = "";
        }

        /// <summary>
        /// Hide buttons
        /// </summary>
        public void ocultarBotones()
        {
            bModificar.Visible = false;
            bEliminar.Visible = false;
            bNuevo.Visible = false;
        }

        /// <summary>
        /// Show buttons
        /// </summary>
        public void mostrarBotones()
        {
            bModificar.Visible = true;
            bEliminar.Visible = true;
            bGuardar.Visible = true;
        }

        /// <summary>
        /// Alert for user
        /// </summary>
        /// <param name="mensaje">Message of the alert</param>
        /// <param name="titulo">Title of the alert</param>
        public void Alert(String mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Show message to user
        /// </summary>
        /// <param name="mensaje">Message of the message box</param>
        /// <param name="titulo">Title of the message box</param>
        public void ShowMessage(String mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //Metodo guardar bebida
        private async Task<int> guardarBebida(String nombreBebida, String precio, String imagen)
        {
            int answ = 0;
            MessageBox.Show(nombreBebida+precio+imagen);

            if (nombreBebida != "" && precio != "")
            {
                Refresco r = new Refresco(nombreBebida, Double.Parse(precio), imagen);
                answ = await cp.agregarBebida(r);

            }
            else
            {
                Alert("Porfavor rellene los campos", "Campos vacios");
            }

            return answ;
        }

    }

}
