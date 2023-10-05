namespace WindowsTesoreria.Ventanas
{
    partial class GuardarOfrendaMatutina
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblDinero = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtDinero = new System.Windows.Forms.TextBox();
            this.lblOfrendaMatutina = new System.Windows.Forms.Label();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.cbConcepto = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cbUsuarios = new System.Windows.Forms.ComboBox();
            this.lblFechaAhorrado = new System.Windows.Forms.Label();
            this.lblFechaModificado = new System.Windows.Forms.Label();
            this.dtpFechaAhorrado = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaModificado = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(37, 375);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(97, 46);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(238, 375);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 46);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(114, 66);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 17);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Id:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(47, 115);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(90, 17);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblDinero
            // 
            this.lblDinero.AutoSize = true;
            this.lblDinero.Location = new System.Drawing.Point(82, 160);
            this.lblDinero.Name = "lblDinero";
            this.lblDinero.Size = new System.Drawing.Size(55, 17);
            this.lblDinero.TabIndex = 4;
            this.lblDinero.Text = "Dinero:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(143, 63);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(205, 25);
            this.txtId.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(143, 112);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(205, 25);
            this.txtDescripcion.TabIndex = 7;
            // 
            // txtDinero
            // 
            this.txtDinero.Location = new System.Drawing.Point(143, 157);
            this.txtDinero.Name = "txtDinero";
            this.txtDinero.Size = new System.Drawing.Size(205, 25);
            this.txtDinero.TabIndex = 8;
            // 
            // lblOfrendaMatutina
            // 
            this.lblOfrendaMatutina.AutoSize = true;
            this.lblOfrendaMatutina.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfrendaMatutina.Location = new System.Drawing.Point(102, 19);
            this.lblOfrendaMatutina.Name = "lblOfrendaMatutina";
            this.lblOfrendaMatutina.Size = new System.Drawing.Size(170, 22);
            this.lblOfrendaMatutina.TabIndex = 10;
            this.lblOfrendaMatutina.Text = "Ofrenda Matutina";
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.Location = new System.Drawing.Point(62, 292);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(75, 17);
            this.lblConcepto.TabIndex = 11;
            this.lblConcepto.Text = "Concepto:";
            // 
            // cbConcepto
            // 
            this.cbConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConcepto.FormattingEnabled = true;
            this.cbConcepto.Items.AddRange(new object[] {
            "Entrada",
            "Salida"});
            this.cbConcepto.Location = new System.Drawing.Point(143, 289);
            this.cbConcepto.Name = "cbConcepto";
            this.cbConcepto.Size = new System.Drawing.Size(205, 25);
            this.cbConcepto.TabIndex = 12;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(75, 336);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(62, 17);
            this.lblUsuario.TabIndex = 13;
            this.lblUsuario.Text = "Usuario:";
            // 
            // cbUsuarios
            // 
            this.cbUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsuarios.FormattingEnabled = true;
            this.cbUsuarios.Location = new System.Drawing.Point(143, 333);
            this.cbUsuarios.Name = "cbUsuarios";
            this.cbUsuarios.Size = new System.Drawing.Size(205, 25);
            this.cbUsuarios.TabIndex = 14;
            // 
            // lblFechaAhorrado
            // 
            this.lblFechaAhorrado.AutoSize = true;
            this.lblFechaAhorrado.Location = new System.Drawing.Point(22, 207);
            this.lblFechaAhorrado.Name = "lblFechaAhorrado";
            this.lblFechaAhorrado.Size = new System.Drawing.Size(115, 17);
            this.lblFechaAhorrado.TabIndex = 15;
            this.lblFechaAhorrado.Text = "Fecha ahorrado:";
            // 
            // lblFechaModificado
            // 
            this.lblFechaModificado.AutoSize = true;
            this.lblFechaModificado.Location = new System.Drawing.Point(9, 251);
            this.lblFechaModificado.Name = "lblFechaModificado";
            this.lblFechaModificado.Size = new System.Drawing.Size(128, 17);
            this.lblFechaModificado.TabIndex = 16;
            this.lblFechaModificado.Text = "Fecha modificado:";
            // 
            // dtpFechaAhorrado
            // 
            this.dtpFechaAhorrado.Location = new System.Drawing.Point(143, 201);
            this.dtpFechaAhorrado.Name = "dtpFechaAhorrado";
            this.dtpFechaAhorrado.Size = new System.Drawing.Size(205, 25);
            this.dtpFechaAhorrado.TabIndex = 17;
            // 
            // dtpFechaModificado
            // 
            this.dtpFechaModificado.Location = new System.Drawing.Point(143, 245);
            this.dtpFechaModificado.Name = "dtpFechaModificado";
            this.dtpFechaModificado.Size = new System.Drawing.Size(205, 25);
            this.dtpFechaModificado.TabIndex = 18;
            // 
            // GuardarOfrendaMatutina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 435);
            this.Controls.Add(this.dtpFechaModificado);
            this.Controls.Add(this.dtpFechaAhorrado);
            this.Controls.Add(this.lblFechaModificado);
            this.Controls.Add(this.lblFechaAhorrado);
            this.Controls.Add(this.cbUsuarios);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.cbConcepto);
            this.Controls.Add(this.lblConcepto);
            this.Controls.Add(this.lblOfrendaMatutina);
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
            this.Name = "GuardarOfrendaMatutina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevaOfrendaMatutina";
            this.Load += new System.EventHandler(this.GuardarOfrendaMatutina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblDinero;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtDinero;
        private System.Windows.Forms.Label lblOfrendaMatutina;
        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.ComboBox cbConcepto;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cbUsuarios;
        private System.Windows.Forms.Label lblFechaAhorrado;
        private System.Windows.Forms.Label lblFechaModificado;
        private System.Windows.Forms.DateTimePicker dtpFechaAhorrado;
        private System.Windows.Forms.DateTimePicker dtpFechaModificado;
    }
}