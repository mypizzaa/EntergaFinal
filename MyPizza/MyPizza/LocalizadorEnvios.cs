﻿using Controlador;
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
    
    public partial class LocalizadorEnvios : Form
    {

        private List<PedidoInfo> listaPedidos;

        private ControladorPedidos cp;

        public LocalizadorEnvios()
        {
            cp = new ControladorPedidos();
            InitializeComponent();
            pictureBox1.ImageLocation = "http://provenapps.cat/~dam1804/Images/localizar.jpg";
            cargarPedidos();
        }


        /// <summary>
        /// Este metodo carga todos los pedidos en el listviewpedidos
        /// </summary>
        public void cargarPedidos()
        {
            listaPedidos = cp.listOrders();

            foreach (PedidoInfo p in listaPedidos)
            {
                if (p.getId_estado() == 3) //if estado equals listo(3)
                {
                    listViewPedidos.Items.Add(p.getId_pedido_info().ToString());
                }
            }

        }
        
        
        private void listViewPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPedidos.SelectedItems.Count > 0)
            {
                pictureBox1.Visible = false;
                ListViewItem listItem = listViewPedidos.SelectedItems[0];
                txtCodigoPedido.Text = listItem.Text;
                long id_pedido_info = long.Parse(listItem.Text);
                String direccion = "";

                foreach (PedidoInfo pi in listaPedidos)
                {
                    if(pi.getId_pedido_info() == id_pedido_info)
                    {
                        direccion = pi.getDireccion();
                    }
                }
                
                webBrowser1.Visible = true; 
                                            
                StringBuilder sb = new StringBuilder();
                sb.Append("http://maps.google.com/maps?q=");
                sb.Append(direccion);

                webBrowser1.Navigate(sb.ToString());

            }else
            {
                pictureBox1.Visible = true;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            bVerTodos.Visible = true;
            String codigoPedido = txtCodigoPedido.Text;

            if(codigoPedido != null)
            {
                try
                {
                    long codigo = long.Parse(codigoPedido);
                    PedidoInfo pi = buscarPedido(codigo);

                    listViewPedidos.Clear();
                    listViewPedidos.Items.Add(pi.getId_pedido_info().ToString());

                    if(txtCodigoPedido.Text == "")
                    {
                        cargarPedidos();
                    }

                }
                catch (FormatException fe)
                {
                    MessageBox.Show("Porfavor inserte un numero","Error formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
          
        }

        public PedidoInfo buscarPedido(long codigoPedido)
        {
            PedidoInfo pi = null;

            foreach (PedidoInfo p in listaPedidos)
            {
                if(p.getId_pedido_info() == codigoPedido)
                {
                    pi = p;
                }
            }
            
            return pi;
        }

        private void bVerTodos_Click(object sender, EventArgs e)
        {
            bVerTodos.Visible = false;
            listViewPedidos.Clear();
            cargarPedidos();
        }

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta opcion esta en desarollo","En desarollo");
        }
    }
}
