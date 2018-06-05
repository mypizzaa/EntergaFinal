namespace Vista
{
    partial class AdminIngrediente
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
            this.bEliminar = new System.Windows.Forms.Button();
            this.bModificar = new System.Windows.Forms.Button();
            this.bAñadirImagen = new System.Windows.Forms.Button();
            this.bNuevo = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIngrediente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewIngredientes = new System.Windows.Forms.ListView();
            this.Id_Prod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bEliminar
            // 
            this.bEliminar.BackColor = System.Drawing.Color.Black;
            this.bEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.bEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bEliminar.Location = new System.Drawing.Point(234, 558);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(90, 40);
            this.bEliminar.TabIndex = 46;
            this.bEliminar.Text = "ELIMINAR";
            this.bEliminar.UseVisualStyleBackColor = false;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bModificar
            // 
            this.bModificar.BackColor = System.Drawing.Color.Black;
            this.bModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.bModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bModificar.Location = new System.Drawing.Point(138, 558);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(90, 40);
            this.bModificar.TabIndex = 45;
            this.bModificar.Text = "MODIFICAR";
            this.bModificar.UseVisualStyleBackColor = false;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bAñadirImagen
            // 
            this.bAñadirImagen.BackColor = System.Drawing.Color.Black;
            this.bAñadirImagen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.bAñadirImagen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAñadirImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bAñadirImagen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bAñadirImagen.Location = new System.Drawing.Point(342, 237);
            this.bAñadirImagen.Name = "bAñadirImagen";
            this.bAñadirImagen.Size = new System.Drawing.Size(221, 30);
            this.bAñadirImagen.TabIndex = 44;
            this.bAñadirImagen.Text = "Añadir imagen";
            this.bAñadirImagen.UseVisualStyleBackColor = false;
            this.bAñadirImagen.Visible = false;
            this.bAñadirImagen.Click += new System.EventHandler(this.bAñadirImagen_Click);
            // 
            // bNuevo
            // 
            this.bNuevo.BackColor = System.Drawing.Color.Black;
            this.bNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bNuevo.Location = new System.Drawing.Point(330, 558);
            this.bNuevo.Name = "bNuevo";
            this.bNuevo.Size = new System.Drawing.Size(159, 40);
            this.bNuevo.TabIndex = 43;
            this.bNuevo.Text = "NUEVO INGREDIENTE ";
            this.bNuevo.UseVisualStyleBackColor = false;
            this.bNuevo.Click += new System.EventHandler(this.bNuevo_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.BackColor = System.Drawing.Color.Black;
            this.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bCancelar.Location = new System.Drawing.Point(769, 558);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(90, 40);
            this.bCancelar.TabIndex = 42;
            this.bCancelar.Text = "CANCELAR";
            this.bCancelar.UseVisualStyleBackColor = false;
            this.bCancelar.Visible = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.BackColor = System.Drawing.Color.Black;
            this.bGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bGuardar.Location = new System.Drawing.Point(865, 558);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(90, 40);
            this.bGuardar.TabIndex = 41;
            this.bGuardar.Text = "GUARDAR";
            this.bGuardar.UseVisualStyleBackColor = false;
            this.bGuardar.Visible = false;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(342, 187);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(221, 20);
            this.txtPrecio.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(342, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Precio:";
            // 
            // txtIngrediente
            // 
            this.txtIngrediente.Enabled = false;
            this.txtIngrediente.Location = new System.Drawing.Point(342, 128);
            this.txtIngrediente.Name = "txtIngrediente";
            this.txtIngrediente.Size = new System.Drawing.Size(221, 20);
            this.txtIngrediente.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Nombre Ingrediente :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(137, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(134, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "INGREDIENTES:";
            // 
            // listViewIngredientes
            // 
            this.listViewIngredientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.listViewIngredientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id_Prod,
            this.columnHeader1});
            this.listViewIngredientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewIngredientes.GridLines = true;
            this.listViewIngredientes.Location = new System.Drawing.Point(138, 337);
            this.listViewIngredientes.Name = "listViewIngredientes";
            this.listViewIngredientes.Size = new System.Drawing.Size(817, 187);
            this.listViewIngredientes.TabIndex = 34;
            this.listViewIngredientes.UseCompatibleStateImageBehavior = false;
            this.listViewIngredientes.View = System.Windows.Forms.View.Tile;
            this.listViewIngredientes.SelectedIndexChanged += new System.EventHandler(this.listViewIngredientes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(133, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "ADMINISTRAR INGREDIENTES";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AdminIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1088, 621);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bAñadirImagen);
            this.Controls.Add(this.bNuevo);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIngrediente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewIngredientes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminIngrediente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminIngrediente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bAñadirImagen;
        private System.Windows.Forms.Button bNuevo;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIngrediente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewIngredientes;
        private System.Windows.Forms.ColumnHeader Id_Prod;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}