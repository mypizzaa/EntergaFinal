namespace Vista
{
    partial class AdminPizza
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
            this.label1 = new System.Windows.Forms.Label();
            this.ListViewPizzas = new System.Windows.Forms.ListView();
            this.Id_Prod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxIngredientes = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bAñadirImagen = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombrePizza = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bModificar = new System.Windows.Forms.Button();
            this.bNueva = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(133, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMINISTRAR PIZZAS";
            // 
            // ListViewPizzas
            // 
            this.ListViewPizzas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.ListViewPizzas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id_Prod,
            this.columnHeader1});
            this.ListViewPizzas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListViewPizzas.ForeColor = System.Drawing.SystemColors.Window;
            this.ListViewPizzas.GridLines = true;
            this.ListViewPizzas.Location = new System.Drawing.Point(850, 119);
            this.ListViewPizzas.Name = "ListViewPizzas";
            this.ListViewPizzas.Size = new System.Drawing.Size(228, 524);
            this.ListViewPizzas.TabIndex = 1;
            this.ListViewPizzas.UseCompatibleStateImageBehavior = false;
            this.ListViewPizzas.View = System.Windows.Forms.View.Tile;
            this.ListViewPizzas.SelectedIndexChanged += new System.EventHandler(this.ListViewPizzas_SelectedIndexChanged);
            // 
            // Id_Prod
            // 
            this.Id_Prod.Width = 266;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(846, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "PIZZAS:";
            // 
            // groupBoxIngredientes
            // 
            this.groupBoxIngredientes.Enabled = false;
            this.groupBoxIngredientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxIngredientes.Location = new System.Drawing.Point(137, 317);
            this.groupBoxIngredientes.Name = "groupBoxIngredientes";
            this.groupBoxIngredientes.Size = new System.Drawing.Size(554, 247);
            this.groupBoxIngredientes.TabIndex = 11;
            this.groupBoxIngredientes.TabStop = false;
            this.groupBoxIngredientes.Text = "INGREDIENTES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(137, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // bAñadirImagen
            // 
            this.bAñadirImagen.BackColor = System.Drawing.Color.Black;
            this.bAñadirImagen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.bAñadirImagen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAñadirImagen.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bAñadirImagen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bAñadirImagen.Location = new System.Drawing.Point(342, 237);
            this.bAñadirImagen.Name = "bAñadirImagen";
            this.bAñadirImagen.Size = new System.Drawing.Size(221, 30);
            this.bAñadirImagen.TabIndex = 28;
            this.bAñadirImagen.Text = "Añadir imagen";
            this.bAñadirImagen.UseVisualStyleBackColor = false;
            this.bAñadirImagen.Visible = false;
            this.bAñadirImagen.Click += new System.EventHandler(this.bAñadirImagen_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(342, 187);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(221, 20);
            this.txtPrecio.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(342, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Precio:";
            // 
            // txtNombrePizza
            // 
            this.txtNombrePizza.Enabled = false;
            this.txtNombrePizza.Location = new System.Drawing.Point(342, 128);
            this.txtNombrePizza.Name = "txtNombrePizza";
            this.txtNombrePizza.Size = new System.Drawing.Size(221, 20);
            this.txtNombrePizza.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nombre pizza :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bModificar
            // 
            this.bModificar.BackColor = System.Drawing.Color.Black;
            this.bModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.bModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bModificar.Location = new System.Drawing.Point(137, 603);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(90, 40);
            this.bModificar.TabIndex = 30;
            this.bModificar.Text = "MODIFICAR";
            this.bModificar.UseVisualStyleBackColor = false;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click_1);
            // 
            // bNueva
            // 
            this.bNueva.BackColor = System.Drawing.Color.Black;
            this.bNueva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.bNueva.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bNueva.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bNueva.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bNueva.Location = new System.Drawing.Point(233, 603);
            this.bNueva.Name = "bNueva";
            this.bNueva.Size = new System.Drawing.Size(106, 40);
            this.bNueva.TabIndex = 31;
            this.bNueva.Text = "NUEVA PIZZA";
            this.bNueva.UseVisualStyleBackColor = false;
            this.bNueva.Click += new System.EventHandler(this.bNueva_Click_1);
            // 
            // bEliminar
            // 
            this.bEliminar.BackColor = System.Drawing.Color.Black;
            this.bEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.bEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bEliminar.Location = new System.Drawing.Point(345, 603);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(90, 40);
            this.bEliminar.TabIndex = 32;
            this.bEliminar.Text = "ELIMINAR";
            this.bEliminar.UseVisualStyleBackColor = false;
            // 
            // bCancelar
            // 
            this.bCancelar.BackColor = System.Drawing.Color.Black;
            this.bCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bCancelar.Location = new System.Drawing.Point(505, 603);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(90, 40);
            this.bCancelar.TabIndex = 33;
            this.bCancelar.Text = "CANCELAR";
            this.bCancelar.UseVisualStyleBackColor = false;
            this.bCancelar.Visible = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click_1);
            // 
            // bGuardar
            // 
            this.bGuardar.BackColor = System.Drawing.Color.Black;
            this.bGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.bGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bGuardar.Location = new System.Drawing.Point(601, 603);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(90, 40);
            this.bGuardar.TabIndex = 34;
            this.bGuardar.Text = "GUARDAR";
            this.bGuardar.UseVisualStyleBackColor = false;
            this.bGuardar.Visible = false;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // AdminPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1136, 738);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bNueva);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bAñadirImagen);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombrePizza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBoxIngredientes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListViewPizzas);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPizza";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPizza";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ListViewPizzas;
        private System.Windows.Forms.ColumnHeader Id_Prod;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxIngredientes;
        private System.Windows.Forms.Button bAñadirImagen;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombrePizza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bNueva;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bGuardar;
    }
}