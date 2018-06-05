namespace Vista
{
    partial class AdminEmpleados
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listViewEmpleados = new System.Windows.Forms.ListView();
            this.Id_Prod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bAdd = new System.Windows.Forms.Button();
            this.bBaja = new System.Windows.Forms.Button();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHorasSemanales = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bAñadirImagen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bModificar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(137, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(133, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "ADMINISTRAR EMPLEADOS";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Enabled = false;
            this.txtApellidos.Location = new System.Drawing.Point(342, 187);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(221, 20);
            this.txtApellidos.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Apellidos :";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(342, 128);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(221, 20);
            this.txtNombre.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nombre :";
            // 
            // txtDni
            // 
            this.txtDni.Enabled = false;
            this.txtDni.Location = new System.Drawing.Point(342, 247);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(221, 20);
            this.txtDni.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "DNI :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.Location = new System.Drawing.Point(133, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 19);
            this.label5.TabIndex = 31;
            this.label5.Text = "EMPLEADOS :";
            // 
            // listViewEmpleados
            // 
            this.listViewEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.listViewEmpleados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id_Prod,
            this.columnHeader1});
            this.listViewEmpleados.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewEmpleados.GridLines = true;
            this.listViewEmpleados.Location = new System.Drawing.Point(137, 343);
            this.listViewEmpleados.Name = "listViewEmpleados";
            this.listViewEmpleados.Size = new System.Drawing.Size(817, 187);
            this.listViewEmpleados.TabIndex = 30;
            this.listViewEmpleados.UseCompatibleStateImageBehavior = false;
            this.listViewEmpleados.View = System.Windows.Forms.View.Tile;
            this.listViewEmpleados.SelectedIndexChanged += new System.EventHandler(this.listViewEmpleados_SelectedIndexChanged);
            // 
            // Id_Prod
            // 
            this.Id_Prod.Width = 127;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 183;
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.Black;
            this.bAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bAdd.Location = new System.Drawing.Point(296, 562);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(120, 48);
            this.bAdd.TabIndex = 33;
            this.bAdd.Text = "NUEVO EMPLEADO";
            this.bAdd.UseVisualStyleBackColor = false;
            // 
            // bBaja
            // 
            this.bBaja.BackColor = System.Drawing.Color.Black;
            this.bBaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.bBaja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bBaja.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bBaja.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bBaja.Location = new System.Drawing.Point(432, 562);
            this.bBaja.Name = "bBaja";
            this.bBaja.Size = new System.Drawing.Size(120, 48);
            this.bBaja.TabIndex = 32;
            this.bBaja.Text = "DAR DE BAJA";
            this.bBaja.UseVisualStyleBackColor = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Enabled = false;
            this.txtCorreo.Location = new System.Drawing.Point(605, 128);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(221, 20);
            this.txtCorreo.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(605, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Correo :";
            // 
            // txtHorasSemanales
            // 
            this.txtHorasSemanales.Enabled = false;
            this.txtHorasSemanales.Location = new System.Drawing.Point(605, 187);
            this.txtHorasSemanales.Name = "txtHorasSemanales";
            this.txtHorasSemanales.Size = new System.Drawing.Size(221, 20);
            this.txtHorasSemanales.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(605, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Horas semanales  :";
            // 
            // bAñadirImagen
            // 
            this.bAñadirImagen.BackColor = System.Drawing.Color.Black;
            this.bAñadirImagen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.bAñadirImagen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAñadirImagen.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bAñadirImagen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bAñadirImagen.Location = new System.Drawing.Point(605, 237);
            this.bAñadirImagen.Name = "bAñadirImagen";
            this.bAñadirImagen.Size = new System.Drawing.Size(221, 30);
            this.bAñadirImagen.TabIndex = 38;
            this.bAñadirImagen.Text = "Añadir imagen";
            this.bAñadirImagen.UseVisualStyleBackColor = false;
            this.bAñadirImagen.Visible = false;
            this.bAñadirImagen.Click += new System.EventHandler(this.bAñadirImagen_Click);
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
            this.bModificar.Location = new System.Drawing.Point(161, 562);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(120, 48);
            this.bModificar.TabIndex = 39;
            this.bModificar.Text = "MODIFICAR";
            this.bModificar.UseVisualStyleBackColor = false;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.BackColor = System.Drawing.Color.Black;
            this.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bCancelar.Location = new System.Drawing.Point(688, 562);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(120, 48);
            this.bCancelar.TabIndex = 41;
            this.bCancelar.Text = "CANCELAR";
            this.bCancelar.UseVisualStyleBackColor = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.BackColor = System.Drawing.Color.Black;
            this.bGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.bGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bGuardar.Location = new System.Drawing.Point(824, 562);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(120, 48);
            this.bGuardar.TabIndex = 40;
            this.bGuardar.Text = "GUARDAR";
            this.bGuardar.UseVisualStyleBackColor = false;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_ClickAsync);
            // 
            // AdminEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1104, 660);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bAñadirImagen);
            this.Controls.Add(this.txtHorasSemanales);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bBaja);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listViewEmpleados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminEmpleados";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listViewEmpleados;
        private System.Windows.Forms.ColumnHeader Id_Prod;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bBaja;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHorasSemanales;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bAñadirImagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bGuardar;
    }
}