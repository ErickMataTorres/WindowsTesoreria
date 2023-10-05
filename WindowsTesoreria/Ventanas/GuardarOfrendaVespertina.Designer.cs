namespace WindowsTesoreria.Ventanas
{
    partial class GuardarOfrendaVespertina
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
            this.dtpFechaModificado = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaAhorrado = new System.Windows.Forms.DateTimePicker();
            this.lblFechaModificado = new System.Windows.Forms.Label();
            this.lblFechaAhorrado = new System.Windows.Forms.Label();
            this.cbUsuarios = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cbConcepto = new System.Windows.Forms.ComboBox();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.lblOfrendaVespertina = new System.Windows.Forms.Label();
            this.txtDinero = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblDinero = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpFechaModificado
            // 
            this.dtpFechaModificado.Location = new System.Drawing.Point(148, 234);
            this.dtpFechaModificado.Name = "dtpFechaModificado";
            this.dtpFechaModificado.Size = new System.Drawing.Size(205, 25);
            this.dtpFechaModificado.TabIndex = 35;
            // 
            // dtpFechaAhorrado
            // 
            this.dtpFechaAhorrado.Location = new System.Drawing.Point(148, 190);
            this.dtpFechaAhorrado.Name = "dtpFechaAhorrado";
            this.dtpFechaAhorrado.Size = new System.Drawing.Size(205, 25);
            this.dtpFechaAhorrado.TabIndex = 34;
            // 
            // lblFechaModificado
            // 
            this.lblFechaModificado.AutoSize = true;
            this.lblFechaModificado.Location = new System.Drawing.Point(14, 240);
            this.lblFechaModificado.Name = "lblFechaModificado";
            this.lblFechaModificado.Size = new System.Drawing.Size(128, 17);
            this.lblFechaModificado.TabIndex = 33;
            this.lblFechaModificado.Text = "Fecha modificado:";
            // 
            // lblFechaAhorrado
            // 
            this.lblFechaAhorrado.AutoSize = true;
            this.lblFechaAhorrado.Location = new System.Drawing.Point(27, 196);
            this.lblFechaAhorrado.Name = "lblFechaAhorrado";
            this.lblFechaAhorrado.Size = new System.Drawing.Size(115, 17);
            this.lblFechaAhorrado.TabIndex = 32;
            this.lblFechaAhorrado.Text = "Fecha ahorrado:";
            // 
            // cbUsuarios
            // 
            this.cbUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsuarios.FormattingEnabled = true;
            this.cbUsuarios.Location = new System.Drawing.Point(148, 322);
            this.cbUsuarios.Name = "cbUsuarios";
            this.cbUsuarios.Size = new System.Drawing.Size(205, 25);
            this.cbUsuarios.TabIndex = 31;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(80, 325);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(62, 17);
            this.lblUsuario.TabIndex = 30;
            this.lblUsuario.Text = "Usuario:";
            // 
            // cbConcepto
            // 
            this.cbConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConcepto.FormattingEnabled = true;
            this.cbConcepto.Items.AddRange(new object[] {
            "Entrada",
            "Salida"});
            this.cbConcepto.Location = new System.Drawing.Point(148, 278);
            this.cbConcepto.Name = "cbConcepto";
            this.cbConcepto.Size = new System.Drawing.Size(205, 25);
            this.cbConcepto.TabIndex = 29;
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.Location = new System.Drawing.Point(67, 281);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(75, 17);
            this.lblConcepto.TabIndex = 28;
            this.lblConcepto.Text = "Concepto:";
            // 
            // lblOfrendaVespertina
            // 
            this.lblOfrendaVespertina.AutoSize = true;
            this.lblOfrendaVespertina.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfrendaVespertina.Location = new System.Drawing.Point(97, 9);
            this.lblOfrendaVespertina.Name = "lblOfrendaVespertina";
            this.lblOfrendaVespertina.Size = new System.Drawing.Size(189, 22);
            this.lblOfrendaVespertina.TabIndex = 27;
            this.lblOfrendaVespertina.Text = "Ofrenda Vespertina";
            // 
            // txtDinero
            // 
            this.txtDinero.Location = new System.Drawing.Point(148, 146);
            this.txtDinero.Name = "txtDinero";
            this.txtDinero.Size = new System.Drawing.Size(205, 25);
            this.txtDinero.TabIndex = 26;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(148, 101);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(205, 25);
            this.txtDescripcion.TabIndex = 25;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(148, 52);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(205, 25);
            this.txtId.TabIndex = 24;
            // 
            // lblDinero
            // 
            this.lblDinero.AutoSize = true;
            this.lblDinero.Location = new System.Drawing.Point(87, 149);
            this.lblDinero.Name = "lblDinero";
            this.lblDinero.Size = new System.Drawing.Size(55, 17);
            this.lblDinero.TabIndex = 23;
            this.lblDinero.Text = "Dinero:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(52, 104);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(90, 17);
            this.lblDescripcion.TabIndex = 22;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(119, 55);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 17);
            this.lblId.TabIndex = 21;
            this.lblId.Text = "Id:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(243, 364);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 46);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(42, 364);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(97, 46);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // GuardarOfrendaVespertina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 428);
            this.Controls.Add(this.dtpFechaModificado);
            this.Controls.Add(this.dtpFechaAhorrado);
            this.Controls.Add(this.lblFechaModificado);
            this.Controls.Add(this.lblFechaAhorrado);
            this.Controls.Add(this.cbUsuarios);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.cbConcepto);
            this.Controls.Add(this.lblConcepto);
            this.Controls.Add(this.lblOfrendaVespertina);
            this.Controls.Add(this.txtDinero);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblDinero);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GuardarOfrendaVespertina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuardarOfrendaVespertina";
            this.Load += new System.EventHandler(this.GuardarOfrendaVespertina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaModificado;
        private System.Windows.Forms.DateTimePicker dtpFechaAhorrado;
        private System.Windows.Forms.Label lblFechaModificado;
        private System.Windows.Forms.Label lblFechaAhorrado;
        private System.Windows.Forms.ComboBox cbUsuarios;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cbConcepto;
        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.Label lblOfrendaVespertina;
        private System.Windows.Forms.TextBox txtDinero;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblDinero;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
    }
}