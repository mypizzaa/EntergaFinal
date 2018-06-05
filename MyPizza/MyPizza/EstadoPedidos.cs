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
    public partial class EstadoPedidos : Form
    {
        public EstadoPedidos()
        {
            InitializeComponent();
        }
                
        //Buscar pedido
        private void buscarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            BuscarPedido bp = new BuscarPedido();
            bp.Show();

        }
    }
}
