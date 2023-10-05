namespace WindowsTesoreria.Ventanas
{
    partial class GuardarMovimiento
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
            this.lblMovimiento = new System.Windows.Forms.Label();
            this.txtDinero = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblDinero = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNumeroOperacion = new System.Windows.Forms.Label();
            this.lblAdjuntarTicket = new System.Windows.Forms.Label();
            this.sfdAdjuntarTicket = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // dtpFechaModificado
            // 
            this.dtpFechaModificado.Location = new System.Drawing.Point(163, 329);
            this.dtpFechaModificado.Name = "dtpFechaModificado";
            this.dtpFechaModificado.Size = new System.Drawing.Size(205, 25);
            this.dtpFechaModificado.TabIndex = 35;
            // 
            // dtpFechaAhorrado
            // 
            this.dtpFechaAhorrado.Location = new System.Drawing.Point(163, 285);
            this.dtpFechaAhorrado.Name = "dtpFechaAhorrado";
            this.dtpFechaAhorrado.Size = new System.Drawing.Size(205, 25);
            this.dtpFechaAhorrado.TabIndex = 34;
            // 
            // lblFechaModificado
            // 
            this.lblFechaModificado.AutoSize = true;
            this.lblFechaModificado.Location = new System.Drawing.Point(29, 335);
            this.lblFechaModificado.Name = "lblFechaModificado";
            this.lblFechaModificado.Size = new System.Drawing.Size(128, 17);
            this.lblFechaModificado.TabIndex = 33;
            this.lblFechaModificado.Text = "Fecha modificado:";
            // 
            // lblFechaAhorrado
            // 
            this.lblFechaAhorrado.AutoSize = true;
            this.lblFechaAhorrado.Location = new System.Drawing.Point(42, 291);
            this.lblFechaAhorrado.Name = "lblFechaAhorrado";
            this.lblFechaAhorrado.Size = new System.Drawing.Size(115, 17);
            this.lblFechaAhorrado.TabIndex = 32;
            this.lblFechaAhorrado.Text = "Fecha ahorrado:";
            // 
            // cbUsuarios
            // 
            this.cbUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsuarios.FormattingEnabled = true;
            this.cbUsuarios.Location = new System.Drawing.Point(163, 416);
            this.cbUsuarios.Name = "cbUsuarios";
            this.cbUsuarios.Size = new System.Drawing.Size(205, 25);
            this.cbUsuarios.TabIndex = 31;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(95, 419);
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
            this.cbConcepto.Location = new System.Drawing.Point(163, 372);
            this.cbConcepto.Name = "cbConcepto";
            this.cbConcepto.Size = new System.Drawing.Size(205, 25);
            this.cbConcepto.TabIndex = 29;
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.Location = new System.Drawing.Point(82, 375);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(75, 17);
            this.lblConcepto.TabIndex = 28;
            this.lblConcepto.Text = "Concepto:";
            // 
            // lblMovimiento
            // 
            this.lblMovimiento.AutoSize = true;
            this.lblMovimiento.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovimiento.Location = new System.Drawing.Point(143, 9);
            this.lblMovimiento.Name = "lblMovimiento";
            this.lblMovimiento.Size = new System.Drawing.Size(118, 22);
            this.lblMovimiento.TabIndex = 27;
            this.lblMovimiento.Text = "Movimiento";
            // 
            // txtDinero
            // 
            this.txtDinero.Location = new System.Drawing.Point(163, 149);
            this.txtDinero.Name = "txtDinero";
            this.txtDinero.Size = new System.Drawing.Size(205, 25);
            this.txtDinero.TabIndex = 26;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(163, 102);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(205, 25);
            this.txtDescripcion.TabIndex = 25;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(163, 53);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(205, 25);
            this.txtId.TabIndex = 24;
            // 
            // lblDinero
            // 
            this.lblDinero.AutoSize = true;
            this.lblDinero.Location = new System.Drawing.Point(102, 152);
            this.lblDinero.Name = "lblDinero";
            this.lblDinero.Size = new System.Drawing.Size(55, 17);
            this.lblDinero.TabIndex = 23;
            this.lblDinero.Text = "Dinero:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(67, 105);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(90, 17);
            this.lblDescripcion.TabIndex = 22;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(134, 56);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 17);
            this.lblId.TabIndex = 21;
            this.lblId.Text = "Id:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(258, 458);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 46);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(57, 458);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(97, 46);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 198);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 25);
            this.textBox1.TabIndex = 37;
            // 
            // lblNumeroOperacion
            // 
            this.lblNumeroOperacion.AutoSize = true;
            this.lblNumeroOperacion.Location = new System.Drawing.Point(5, 201);
            this.lblNumeroOperacion.Name = "lblNumeroOperacion";
            this.lblNumeroOperacion.Size = new System.Drawing.Size(152, 17);
            this.lblNumeroOperacion.TabIndex = 36;
            this.lblNumeroOperacion.Text = "Número de operación:";
            // 
            // lblAdjuntarTicket
            // 
            this.lblAdjuntarTicket.AutoSize = true;
            this.lblAdjuntarTicket.Location = new System.Drawing.Point(54, 246);
            this.lblAdjuntarTicket.Name = "lblAdjuntarTicket";
            this.lblAdjuntarTicket.Size = new System.Drawing.Size(103, 17);
            this.lblAdjuntarTicket.TabIndex = 38;
            this.lblAdjuntarTicket.Text = "Adjuntar ticket:";
            // 
            // GuardarMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 520);
            this.Controls.Add(this.lblAdjuntarTicket);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNumeroOperacion);
            this.Controls.Add(this.dtpFechaModificado);
            this.Controls.Add(this.dtpFechaAhorrado);
            this.Controls.Add(this.lblFechaModificado);
            this.Controls.Add(this.lblFechaAhorrado);
            this.Controls.Add(this.cbUsuarios);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.cbConcepto);
            this.Controls.Add(this.lblConcepto);
            this.Controls.Add(this.lblMovimiento);
            this.Controls.Add(this.txtDinero);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblDinero);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GuardarMovimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuardarMovimiento";
            this.Load += new System.EventHandler(this.GuardarMovimiento_Load);
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
        private System.Windows.Forms.Label lblMovimiento;
        private System.Windows.Forms.TextBox txtDinero;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblDinero;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNumeroOperacion;
        private System.Windows.Forms.Label lblAdjuntarTicket;
        private System.Windows.Forms.SaveFileDialog sfdAdjuntarTicket;
    }
}