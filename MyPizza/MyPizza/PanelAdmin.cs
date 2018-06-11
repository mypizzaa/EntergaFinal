using Controlador;
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
    public partial class PanelAdmin : Form
    {

        ControladorServicio cs;

        public PanelAdmin()
        {
            cs = new ControladorServicio();
            InitializeComponent();

            if(cs.getPing() != false)
            {
                welcome();

            }else
            {
                ErrorServicio es = new ErrorServicio();
                es.ShowDialog();
            }            

        }

        /// <summary>
        /// Open welcome form
        /// </summary>
        public void welcome()
        {
            Welcome w = new Welcome();
            AbrirPanel(w);
        }


        /// <summary>
        /// expands the menu vertical or shrink menu  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (menuVertical.Width == 188)
            {
                menuVertical.Width = 40;
                pictureBox2.Visible = false;
                
            }else
            {
                menuVertical.Width = 188;
                pictureBox2.Visible = true;
            }
        }



        /// <summary>
        /// Close the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iconoCerrar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Estas seguro que deseas salir de la aplicación ?", "Salir aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
                Application.Exit();

        }


        //Icono de minimizar
        private void iconoMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Este metodo recibe como parametro un objeto que sera el formulario que se 
        /// quiere cargar en el panel contenedor.
        /// </summary>
        /// <param name="formhijo">formulario</param>
        private void AbrirPanel(object formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        //Menu vertical - PIZZA
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirPanel(new AdminPizza());
        }

        //Menu vertical - BEBIDAS
        private void button4_Click(object sender, EventArgs e)
        {
            AbrirPanel(new AdminBebidas());
        }

        //Menu vertical - EMPLEADOS
        private void button2_Click(object sender, EventArgs e)
        {
            AbrirPanel(new AdminEmpleados());
        }

        //Menu Vertical - VENTAS
        private void button5_Click(object sender, EventArgs e)
        {
            AbrirPanel(new AdminVentas());
            
        }

        //Menu vertical - Ingredientes
        private void button3_Click(object sender, EventArgs e)
        {
            AbrirPanel(new AdminIngrediente());
        }
    }
}
