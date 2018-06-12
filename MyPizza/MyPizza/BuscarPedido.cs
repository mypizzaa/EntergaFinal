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
    public partial class BuscarPedido : Form
    {
       

        public BuscarPedido()
        {
            InitializeComponent();
          
        }
               

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void bBuscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta opcion esta en desarollo.","En desarollo");
            this.Close();
        }
    }
}
