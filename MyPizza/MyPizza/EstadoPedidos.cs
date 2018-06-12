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
    public partial class EstadoPedidos : Form
    {

        private List<PedidoInfo> listaPedidos;
        private ControladorPedidos cp;

        public EstadoPedidos()
        {
            cp = new ControladorPedidos();
            InitializeComponent();
            cargarPedidos();
        }

        public EstadoPedidos(PedidoInfo pedido)
        {

        }

        private void cargarPedidos()
        {
            listaPedidos = cp.listOrders();

            if (listaPedidos != null)
            {
                foreach (PedidoInfo p in listaPedidos)
                {
                    ListViewItem lista = new ListViewItem(p.getId_pedido_info().ToString());
                    lista.SubItems.Add(knowState(p.getId_estado()));
                    lista.SubItems.Add(p.getDireccion());
                    listViewPedidos.Items.Add(lista);
                }
            }
            else{
                Alert("No hay pedidos disponibles.","Lista vacía");
            }

        }

        private string knowState(long id_estado)
        {
            String estado = null;

            switch (id_estado)
            {
                case 1:
                    estado = "Recibido";
                    break;
                case 2:
                    estado = "Cocinando";
                    break;
                case 3:
                    estado = "Listo";
                    break;
                case 4:
                    estado = "En reparto";
                    break;
                
            }

            return estado;
        }



        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            BuscarPedido bp = new BuscarPedido();
            bp.Show();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
