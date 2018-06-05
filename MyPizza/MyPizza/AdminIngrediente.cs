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
    public partial class AdminIngrediente : Form
    {

        private ControladorProductos cp;
        private ControladorServicio cs;

        Boolean service;

        string buttonText = null;
        long id_ingrediente = 0;
        long id_producto = 0;

        /// <summary>
        /// Constructor
        /// </summary>
        public AdminIngrediente()
        {
            cp = new ControladorProductos();
            cs = new ControladorServicio();

            InitializeComponent();

            service = cs.getPing();

            if (service != false)
            {
                loadIngredientes();

            }
            else
            {
                ErrorServicio es = new ErrorServicio();
                es.ShowDialog();
            }
        }

        /// <summary>
        /// This method load all ingredients in listview 
        /// </summary>
        private void loadIngredientes()
        {
            listViewIngredientes.Clear();
            List<Ingrediente> listaIngredientes = cp.listarIngredientes();

            foreach (Ingrediente i in listaIngredientes)
            {
                listViewIngredientes.Items.Add(i.getNombre());
            }
        }

        /// <summary>
        /// Change components properties to modify
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bModificar_Click(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            buttonText = b.Text;
            
            bGuardar.Visible = true;
            bCancelar.Visible = true;

            bNuevo.Visible = false;
            bEliminar.Visible = false;
            bModificar.Visible = false;

            txtIngrediente.Enabled = true;
            txtPrecio.Enabled = true;

            pictureBox1.Enabled = true;

            listViewIngredientes.Enabled = false;
        }

        /// <summary>
        /// Add an image to picture box
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
        /// When user select an ingredient displays the information of the ingredient in text views
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void listViewIngredientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewIngredientes.SelectedItems.Count > 0)
            {
                ListViewItem listItem = listViewIngredientes.SelectedItems[0];
                String nombreIngrediente = listItem.Text;
                txtIngrediente.Text = nombreIngrediente;

                Ingrediente i = await cp.buscarIngredientePorNombre(nombreIngrediente);
                
                txtPrecio.Text = i.getPrecio().ToString();

                String pathImage = i.getImagen();
                pictureBox1.ImageLocation = "http://provenapps.cat/~dam1804/Images/ingredientes/" + pathImage;

                id_ingrediente = i.getIdIngrediente();
                id_producto = i.getIdProducto();

            }
        }

        /// <summary>
        /// Save a new ingredient or a modified ingredients, it depends on what user want to do
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void bGuardar_Click(object sender, EventArgs e)
        {
            string name = txtIngrediente.Text;
            string precio = txtPrecio.Text;
            string imagen = "";

            precio = precio.Replace(",", ".");

            if (!"".Equals(name) && !"".Equals(precio))
            {
                try
                {
                    if (!"MODIFICAR".Equals(buttonText))
                    {
                        Ingrediente i = new Ingrediente(name, double.Parse(precio), imagen);

                        int answ = await cp.agregarIngrediente(i);

                        if (answ != 0)
                        {
                            MessageBox.Show("Se ha añadido correctamente el ingrediente", "Correcto");
                            resetComponents();
                            loadIngredientes();
                        }
                        else
                        {
                            Alert("No se ha podido añadir el ingrediente", "Error!");
                        }
                    } else if (buttonText.Equals("MODIFICAR")) {
                        if (id_producto != 0)
                        {
                            Ingrediente i = new Ingrediente(id_producto, name, double.Parse(precio), imagen);

                            int answ = await cp.modificarIngrediente(i);

                            if (answ != 0)
                            {
                                MessageBox.Show("Se ha modificado correctamente el ingrediente", "Correcto");
                                resetComponents();
                                loadIngredientes();
                            }
                            else
                            {
                                Alert("No se ha podido modificar el ingrediente", "Error!");
                            }
                        }
                        else {
                            Alert("Ingrediente no seleccionado", "Error!");
                        }
                    }
                }
                catch (FormatException fe)
                {
                    Alert("El campo precio es incorrecto", "Campos no validos");
                }
            }
            else
            {
                Alert("El campo nombre y precio no pueden estar vacíos", "Campos no validos");
            }
        }

        /// <summary>
        /// Change components properties to add a new ingredient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bNuevo_Click(object sender, EventArgs e)
        {
            txtIngrediente.Text = "";
            txtPrecio.Text = "";
            pictureBox1.Image = null;


            Button b = (Button)sender;
            buttonText = b.Text;
            bNuevo.Visible = false;
            bGuardar.Visible = true;
            bCancelar.Visible = true;

            bEliminar.Visible = false;
            bModificar.Visible = false;

            txtIngrediente.Enabled = true;
            txtPrecio.Enabled = true;

            pictureBox1.Enabled = true;

            listViewIngredientes.Enabled = false;

        }

        /// <summary>
        /// Reset components to the default format
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bCancelar_Click(object sender, EventArgs e)
        {
            resetComponents();
        }

        /// <summary>
        /// Reset components
        /// </summary>
        private void resetComponents()
        {
            txtIngrediente.Text = "";
            txtPrecio.Text = "";
            pictureBox1.Image = null;            
            bCancelar.Visible = false;
            bGuardar.Visible = false;

            bNuevo.Visible = true;
            bEliminar.Visible = true;
            bModificar.Visible = true;

            txtIngrediente.Enabled = false;
            txtPrecio.Enabled = false;

            pictureBox1.Enabled = false;

            listViewIngredientes.Enabled = true;

            id_ingrediente = 0;
            id_producto = 0;
            buttonText = "";
        }

        /// <summary>
        /// Show an alert for user
        /// </summary>
        /// <param name="mensaje">Message of the alert</param>
        /// <param name="titulo">Title of the alert</param>
        public void Alert(String mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Delete an ingredient according on what ingredient is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void bEliminar_Click(object sender, EventArgs e)
        {
            if (id_ingrediente > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Estas seguro que quieres eliminar el ingrediente \""+txtIngrediente.Text + "\"?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    int answ = await cp.eliminarIngrediente(new Ingrediente(id_ingrediente));

                    if (answ != 0)
                    {
                        MessageBox.Show("Se ha eliminado correctamente el ingrediente", "Correcto");
                        resetComponents();
                        loadIngredientes();
                    }
                    else
                    {
                        Alert("No se ha podido eliminar el ingrediente", "Error!");
                    }
                }
            }
            else
            {
                Alert("No has seleccionado ningun ingrediente", "Error!");
            }
        }
    }
}
