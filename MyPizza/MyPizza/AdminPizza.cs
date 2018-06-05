using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Newtonsoft.Json;
using Controlador;
using System.Net;



namespace Vista
{
    public partial class AdminPizza : Form
    {

        private ControladorProductos cp;
        private ControladorServicio cs;

        private List<CheckBox> listCheckbox;

        private Pizza p;
        private long idPizza;

        Boolean connection;
        

        public AdminPizza()
        {
            cp = new ControladorProductos();
            cs = new ControladorServicio();

            listCheckbox = new List<CheckBox>();             
            InitializeComponent();

            connection = cs.getPing();

            if (connection != false)
            {
                cargarListViewPizzas();
                cargarCheckBoxesIngredientes();

            }else
            {
                ErrorServicio es = new ErrorServicio();
                es.ShowDialog();
            }
        }

        /// <summary>
        /// This method loads all pizzas in the listview
        /// </summary>
        private void cargarListViewPizzas()
        {

            List<Pizza> listaPizzas = cp.listarPizzas();

            foreach(Pizza p in listaPizzas)
            {
                ListViewPizzas.Items.Add(p.getNombre());
            }

        }

        /// <summary>
        /// This method loads all the ingredients from the server
        /// and dynamically generates the corresponding checkboxes with their information.
        /// </summary>
        private void cargarCheckBoxesIngredientes()
        {
            
            List<Ingrediente> listaIngredientes = cp.listarIngredientes();
            int j = 0;
            int x = 14;
            int y = 34;
            int x1 = 0;          

            for (int i = 0; i < listaIngredientes.Count; i++)            
            {                     
                CheckBox cb = new CheckBox();
                cb.Text = (listaIngredientes[i].getNombre().ToString());
                cb.Height= 21;
                cb.Width = 130;

                if (i % 4 == 0 && i != 0)
                {
                    y += 27;
                    j = 0;
                }

                x1 = x+(135*j);
                
                cb.Location = new Point(x1,y);
                
                listCheckbox.Add(cb);
                groupBoxIngredientes.Controls.Add(cb);
                j++;
            }

        }


        /// <summary>
        ///Method that opens an open file dialog to select an image and put it in the picture box.
        ///By default it opens the open file dialog in C:// and only lets select png or jpg files
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
        /// This method when you select an item from the list of pizzas puts the name in the corresponding text box and the price and selects the ingredients of the checkboxes that pertocan each pizza along with the image.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private async void ListViewPizzas_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ListViewPizzas.SelectedItems.Count > 0)
            {
                //select the name of the pizza (item listview)
                ListViewItem listItem = ListViewPizzas.SelectedItems[0];
                String nombrepizza = listItem.Text;
                txtNombrePizza.Text = nombrepizza;

                //take the price of the pizza and show it

                Pizza p = await cp.buscarPizzaPorNombre(nombrepizza);

                if (p != null)
                {
                    txtPrecio.Text = p.getPrecio().ToString();

                    //we call the method marcaIngredientes to select the ingredients that takes the pizza

                    idPizza = p.getIdPizza();
                    List<Ingrediente> listaIngredientes = cp.listarIngredientesPizza(idPizza.ToString());
                    marcarIngredientesPizza(listaIngredientes);

                    //load image to the picturebox
                    String pathImage = p.getImagen();
                    pictureBox1.ImageLocation = "http://provenapps.cat/~dam1804/Images/pizzas/" + pathImage;

                }
                else
                {
                    Alert("No se ha encontrado ninguna pizza.", "Error");
                }


            }

        }

        //boton modificar
        private void bModificar_Click(object sender, EventArgs e)
        {
            txtNombrePizza.Enabled = true;
            txtPrecio.Enabled = true;
            bAñadirImagen.Enabled = true;
            bAñadirImagen.Visible = true;
            groupBoxIngredientes.Enabled = true;
            

        }

        private void bNueva_Click(object sender, EventArgs e)
        {
           
            txtNombrePizza.Text = "";
            txtPrecio.Text = "";
            
        }

        private void bAdd_Click(object sender, EventArgs e)
        {

        }



        /// <summary>
        /// Este metodo marca los checkbox con los ingredientes que contiene la pizza seleccionada
        /// </summary>
        /// <param name="listaIngredientes">Lista de ingredientes que tiene la pizza</param>
        private void marcarIngredientesPizza(List<Ingrediente> listaIngredientes)
        {
            
            foreach (CheckBox cb in listCheckbox)
             {
                foreach (Ingrediente i in listaIngredientes)
                {
                    if (i.getNombre().Equals(cb.Text))
                    {
                        cb.Checked = true;
                        cb.ForeColor = Color.Red;
                        break;
                    }else
                    {
                        cb.ForeColor = Color.Black;
                        cb.Checked = false;
                    }
                }
            }

        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            txtNombrePizza.Enabled = false;
            txtPrecio.Enabled = false;
            bAñadirImagen.Enabled = false;
            bAñadirImagen.Visible = false;
            groupBoxIngredientes.Enabled = false;
           
            txtNombrePizza.Text = "";
            txtPrecio.Text = "";
        }

        private void bModificar_Click_1(object sender, EventArgs e)
        {
            bGuardar.Visible = true;
            bCancelar.Visible = true;
            bAñadirImagen.Visible = true;

            activarControles();

        }

        private void activarControles()
        {
            txtNombrePizza.Enabled = true;
            txtPrecio.Enabled = true;
            groupBoxIngredientes.Enabled = true;
        }

        private void desactivarControles()
        {
            txtNombrePizza.Enabled = false;
            txtPrecio.Enabled = false;
            groupBoxIngredientes.Enabled = false;
        }

        private void bNueva_Click_1(object sender, EventArgs e)
        {
            bGuardar.Visible = true;
            bCancelar.Visible = true;
            bAñadirImagen.Visible = true;
            resetControles();
            activarControles();

        }

        private void resetControles()
        {
            txtNombrePizza.Text = "";
            txtPrecio.Text = "";
            foreach(CheckBox cb in listCheckbox)
            {
                cb.ForeColor = Color.Black;
                cb.Checked = false;
            }
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            bGuardar.Visible = false;
            bCancelar.Visible = false;
            desactivarControles();
        }

        private void bCancelar_Click_1(object sender, EventArgs e)
        {
            bGuardar.Visible = false;
            bCancelar.Visible = false;
            desactivarControles();
        }

        public void Alert(String mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
