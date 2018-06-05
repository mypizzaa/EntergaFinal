namespace Vista
{
    partial class SelectorPizzas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectorPizzas));
            this.listViewIngredientes = new System.Windows.Forms.ListView();
            this.treeViewPedido = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOCALIZARPEDIDOSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verEstadoPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panelPizzas = new System.Windows.Forms.Panel();
            this.bRealizarPedido = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bObservaciones = new System.Windows.Forms.Button();
            this.bQuitar = new System.Windows.Forms.Button();
            this.panelBebidas = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.lbleur = new System.Windows.Forms.Label();
            this.iconoCerrar = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewIngredientes
            // 
            this.listViewIngredientes.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.listViewIngredientes.Location = new System.Drawing.Point(267, 587);
            this.listViewIngredientes.Name = "listViewIngredientes";
            this.listViewIngredientes.Size = new System.Drawing.Size(845, 150);
            this.listViewIngredientes.TabIndex = 15;
            this.listViewIngredientes.UseCompatibleStateImageBehavior = false;
            this.listViewIngredientes.View = System.Windows.Forms.View.Tile;
            this.listViewIngredientes.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // treeViewPedido
            // 
            this.treeViewPedido.Location = new System.Drawing.Point(39, 58);
            this.treeViewPedido.Name = "treeViewPedido";
            this.treeViewPedido.Size = new System.Drawing.Size(189, 477);
            this.treeViewPedido.TabIndex = 24;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraciónToolStripMenuItem,
            this.pedidosToolStripMenuItem,
            this.lOCALIZARPEDIDOSToolStripMenuItem1,
            this.verEstadoPedidosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSessionToolStripMenuItem});
            this.configuraciónToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.configuraciónToolStripMenuItem.Text = "Salir";
            // 
            // cerrarSessionToolStripMenuItem
            // 
            this.cerrarSessionToolStripMenuItem.Name = "cerrarSessionToolStripMenuItem";
            this.cerrarSessionToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.cerrarSessionToolStripMenuItem.Text = "Cerrar sesión";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarClienteToolStripMenuItem});
            this.pedidosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.pedidosToolStripMenuItem.Text = "Buscar";
            // 
            // buscarClienteToolStripMenuItem
            // 
            this.buscarClienteToolStripMenuItem.Name = "buscarClienteToolStripMenuItem";
            this.buscarClienteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.buscarClienteToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.buscarClienteToolStripMenuItem.Text = "Buscar cliente";
            this.buscarClienteToolStripMenuItem.Click += new System.EventHandler(this.buscarClienteToolStripMenuItem_Click);
            // 
            // lOCALIZARPEDIDOSToolStripMenuItem1
            // 
            this.lOCALIZARPEDIDOSToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.lOCALIZARPEDIDOSToolStripMenuItem1.Name = "lOCALIZARPEDIDOSToolStripMenuItem1";
            this.lOCALIZARPEDIDOSToolStripMenuItem1.Size = new System.Drawing.Size(110, 20);
            this.lOCALIZARPEDIDOSToolStripMenuItem1.Text = "Localizar pedidos";
            this.lOCALIZARPEDIDOSToolStripMenuItem1.Click += new System.EventHandler(this.lOCALIZARPEDIDOSToolStripMenuItem1_Click);
            // 
            // verEstadoPedidosToolStripMenuItem
            // 
            this.verEstadoPedidosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.verEstadoPedidosToolStripMenuItem.Name = "verEstadoPedidosToolStripMenuItem";
            this.verEstadoPedidosToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.verEstadoPedidosToolStripMenuItem.Text = "Ver estado pedidos";
            this.verEstadoPedidosToolStripMenuItem.Click += new System.EventHandler(this.verEstadoPedidosToolStripMenuItem_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(38, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 20);
            this.label12.TabIndex = 35;
            this.label12.Text = "PEDIDO:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(263, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 20);
            this.label13.TabIndex = 36;
            this.label13.Text = "PIZZAS :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1140, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 20);
            this.label14.TabIndex = 37;
            this.label14.Text = "BEBIDAS :";
            // 
            // panelPizzas
            // 
            this.panelPizzas.AutoScroll = true;
            this.panelPizzas.BackColor = System.Drawing.Color.CadetBlue;
            this.panelPizzas.Location = new System.Drawing.Point(267, 58);
            this.panelPizzas.Name = "panelPizzas";
            this.panelPizzas.Size = new System.Drawing.Size(845, 477);
            this.panelPizzas.TabIndex = 38;
            // 
            // bRealizarPedido
            // 
            this.bRealizarPedido.BackColor = System.Drawing.Color.Black;
            this.bRealizarPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.bRealizarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bRealizarPedido.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bRealizarPedido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bRealizarPedido.Location = new System.Drawing.Point(1144, 583);
            this.bRealizarPedido.Name = "bRealizarPedido";
            this.bRealizarPedido.Size = new System.Drawing.Size(192, 67);
            this.bRealizarPedido.TabIndex = 39;
            this.bRealizarPedido.Text = "Realizar pedido";
            this.bRealizarPedido.UseVisualStyleBackColor = true;
            this.bRealizarPedido.Click += new System.EventHandler(this.bRealizarPedido_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1144, 669);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 67);
            this.button1.TabIndex = 40;
            this.button1.Text = "Cancelar pedido";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // bObservaciones
            // 
            this.bObservaciones.BackColor = System.Drawing.Color.Black;
            this.bObservaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.bObservaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bObservaciones.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bObservaciones.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bObservaciones.Location = new System.Drawing.Point(39, 587);
            this.bObservaciones.Name = "bObservaciones";
            this.bObservaciones.Size = new System.Drawing.Size(192, 67);
            this.bObservaciones.TabIndex = 41;
            this.bObservaciones.Text = "Observaciones";
            this.bObservaciones.UseVisualStyleBackColor = false;
            this.bObservaciones.Click += new System.EventHandler(this.bObservaciones_Click);
            // 
            // bQuitar
            // 
            this.bQuitar.BackColor = System.Drawing.Color.Black;
            this.bQuitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.bQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bQuitar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bQuitar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bQuitar.Location = new System.Drawing.Point(39, 670);
            this.bQuitar.Name = "bQuitar";
            this.bQuitar.Size = new System.Drawing.Size(192, 67);
            this.bQuitar.TabIndex = 42;
            this.bQuitar.Text = "Quitar";
            this.bQuitar.UseVisualStyleBackColor = false;
            this.bQuitar.Click += new System.EventHandler(this.bQuitar_Click);
            // 
            // panelBebidas
            // 
            this.panelBebidas.AutoScroll = true;
            this.panelBebidas.BackColor = System.Drawing.Color.White;
            this.panelBebidas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBebidas.Location = new System.Drawing.Point(1144, 58);
            this.panelBebidas.Name = "panelBebidas";
            this.panelBebidas.Size = new System.Drawing.Size(192, 477);
            this.panelBebidas.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 564);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "INGREDIENTES :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 551);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "TOTAL :";
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Location = new System.Drawing.Point(122, 556);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(0, 13);
            this.txtTotal.TabIndex = 47;
            // 
            // lbleur
            // 
            this.lbleur.AutoSize = true;
            this.lbleur.Location = new System.Drawing.Point(173, 556);
            this.lbleur.Name = "lbleur";
            this.lbleur.Size = new System.Drawing.Size(13, 13);
            this.lbleur.TabIndex = 0;
            this.lbleur.Text = "€";
            // 
            // iconoCerrar
            // 
            this.iconoCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconoCerrar.BackColor = System.Drawing.Color.Black;
            this.iconoCerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconoCerrar.Image")));
            this.iconoCerrar.Location = new System.Drawing.Point(1342, 0);
            this.iconoCerrar.Name = "iconoCerrar";
            this.iconoCerrar.Size = new System.Drawing.Size(28, 24);
            this.iconoCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconoCerrar.TabIndex = 45;
            this.iconoCerrar.TabStop = false;
            this.iconoCerrar.Click += new System.EventHandler(this.iconoCerrar_Click);
            // 
            // SelectorPizzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.lbleur);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iconoCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelBebidas);
            this.Controls.Add(this.bQuitar);
            this.Controls.Add(this.bObservaciones);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bRealizarPedido);
            this.Controls.Add(this.panelPizzas);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.treeViewPedido);
            this.Controls.Add(this.listViewIngredientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SelectorPizzas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectorPizzas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewIngredientes;
        private System.Windows.Forms.TreeView treeViewPedido;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarClienteToolStripMenuItem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panelPizzas;
        private System.Windows.Forms.Button bRealizarPedido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bObservaciones;
        private System.Windows.Forms.Button bQuitar;
        private System.Windows.Forms.Panel panelBebidas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem lOCALIZARPEDIDOSToolStripMenuItem1;
        private System.Windows.Forms.PictureBox iconoCerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Label lbleur;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verEstadoPedidosToolStripMenuItem;
    }
}