namespace WindowsTesoreria
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOfrendaMatutina = new System.Windows.Forms.Button();
            this.btnDiezmo = new System.Windows.Forms.Button();
            this.btnOfrendaVespertina = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTesoreria = new System.Windows.Forms.Label();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnTotales = new System.Windows.Forms.Button();
            this.btnMovimientos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOfrendaMatutina
            // 
            this.btnOfrendaMatutina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnOfrendaMatutina.Location = new System.Drawing.Point(13, 75);
            this.btnOfrendaMatutina.Margin = new System.Windows.Forms.Padding(4);
            this.btnOfrendaMatutina.Name = "btnOfrendaMatutina";
            this.btnOfrendaMatutina.Size = new System.Drawing.Size(144, 124);
            this.btnOfrendaMatutina.TabIndex = 0;
            this.btnOfrendaMatutina.Text = "Ofrenda matutina";
            this.btnOfrendaMatutina.UseVisualStyleBackColor = false;
            this.btnOfrendaMatutina.Click += new System.EventHandler(this.BtnOfrendaMatutina_Click);
            // 
            // btnDiezmo
            // 
            this.btnDiezmo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDiezmo.Location = new System.Drawing.Point(542, 75);
            this.btnDiezmo.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiezmo.Name = "btnDiezmo";
            this.btnDiezmo.Size = new System.Drawing.Size(144, 124);
            this.btnDiezmo.TabIndex = 1;
            this.btnDiezmo.Text = "Diezmo";
            this.btnDiezmo.UseVisualStyleBackColor = false;
            this.btnDiezmo.Click += new System.EventHandler(this.BtnDiezmo_Click);
            // 
            // btnOfrendaVespertina
            // 
            this.btnOfrendaVespertina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOfrendaVespertina.Location = new System.Drawing.Point(274, 75);
            this.btnOfrendaVespertina.Margin = new System.Windows.Forms.Padding(4);
            this.btnOfrendaVespertina.Name = "btnOfrendaVespertina";
            this.btnOfrendaVespertina.Size = new System.Drawing.Size(144, 124);
            this.btnOfrendaVespertina.TabIndex = 2;
            this.btnOfrendaVespertina.Text = "Ofrenda vespertina";
            this.btnOfrendaVespertina.UseVisualStyleBackColor = false;
            this.btnOfrendaVespertina.Click += new System.EventHandler(this.BtnOfrendaVespertina_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSalir.Location = new System.Drawing.Point(274, 470);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(144, 51);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // lblTesoreria
            // 
            this.lblTesoreria.AutoSize = true;
            this.lblTesoreria.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTesoreria.Location = new System.Drawing.Point(293, 9);
            this.lblTesoreria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTesoreria.Name = "lblTesoreria";
            this.lblTesoreria.Size = new System.Drawing.Size(99, 22);
            this.lblTesoreria.TabIndex = 4;
            this.lblTesoreria.Text = "Tesorería";
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUsuario.Location = new System.Drawing.Point(274, 332);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(144, 124);
            this.btnUsuario.TabIndex = 5;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.BtnUsuario_Click);
            // 
            // btnTotales
            // 
            this.btnTotales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTotales.Location = new System.Drawing.Point(274, 276);
            this.btnTotales.Margin = new System.Windows.Forms.Padding(4);
            this.btnTotales.Name = "btnTotales";
            this.btnTotales.Size = new System.Drawing.Size(144, 40);
            this.btnTotales.TabIndex = 6;
            this.btnTotales.Text = "Totales";
            this.btnTotales.UseVisualStyleBackColor = false;
            this.btnTotales.Click += new System.EventHandler(this.btnTotales_Click);
            // 
            // btnMovimientos
            // 
            this.btnMovimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMovimientos.Location = new System.Drawing.Point(274, 217);
            this.btnMovimientos.Margin = new System.Windows.Forms.Padding(4);
            this.btnMovimientos.Name = "btnMovimientos";
            this.btnMovimientos.Size = new System.Drawing.Size(144, 40);
            this.btnMovimientos.TabIndex = 7;
            this.btnMovimientos.Text = "Movimientos";
            this.btnMovimientos.UseVisualStyleBackColor = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 534);
            this.Controls.Add(this.btnMovimientos);
            this.Controls.Add(this.btnTotales);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.lblTesoreria);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnOfrendaVespertina);
            this.Controls.Add(this.btnDiezmo);
            this.Controls.Add(this.btnOfrendaMatutina);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOfrendaMatutina;
        private System.Windows.Forms.Button btnDiezmo;
        private System.Windows.Forms.Button btnOfrendaVespertina;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblTesoreria;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnTotales;
        private System.Windows.Forms.Button btnMovimientos;
    }
}

