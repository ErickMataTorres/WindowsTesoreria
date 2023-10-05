namespace WindowsTesoreria.Ventanas
{
    partial class Diezmo
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
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotalSalidas = new System.Windows.Forms.TextBox();
            this.txtTotalEntradas = new System.Windows.Forms.TextBox();
            this.lblTotalEntradas = new System.Windows.Forms.Label();
            this.dgvSalidas = new System.Windows.Forms.DataGridView();
            this.lblTotalSalidas = new System.Windows.Forms.Label();
            this.tabEntradas = new System.Windows.Forms.TabPage();
            this.dgvEntradas = new System.Windows.Forms.DataGridView();
            this.tabSalidas = new System.Windows.Forms.TabPage();
            this.lblDiezmo = new System.Windows.Forms.Label();
            this.tabTotales = new System.Windows.Forms.TabPage();
            this.tab = new System.Windows.Forms.TabControl();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtTabTotalEntradas = new System.Windows.Forms.TextBox();
            this.lblTabEntradasTotal = new System.Windows.Forms.Label();
            this.txtTabTotalSalidas = new System.Windows.Forms.TextBox();
            this.lblTabTotalSalidas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalidas)).BeginInit();
            this.tabEntradas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).BeginInit();
            this.tabSalidas.SuspendLayout();
            this.tabTotales.SuspendLayout();
            this.tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTotal
            // 
            this.txtTotal.ForeColor = System.Drawing.Color.Red;
            this.txtTotal.Location = new System.Drawing.Point(146, 132);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(145, 25);
            this.txtTotal.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(98, 135);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 17);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotalSalidas
            // 
            this.txtTotalSalidas.Location = new System.Drawing.Point(146, 81);
            this.txtTotalSalidas.Name = "txtTotalSalidas";
            this.txtTotalSalidas.ReadOnly = true;
            this.txtTotalSalidas.Size = new System.Drawing.Size(145, 25);
            this.txtTotalSalidas.TabIndex = 3;
            // 
            // txtTotalEntradas
            // 
            this.txtTotalEntradas.Location = new System.Drawing.Point(146, 36);
            this.txtTotalEntradas.Name = "txtTotalEntradas";
            this.txtTotalEntradas.ReadOnly = true;
            this.txtTotalEntradas.Size = new System.Drawing.Size(145, 25);
            this.txtTotalEntradas.TabIndex = 2;
            // 
            // lblTotalEntradas
            // 
            this.lblTotalEntradas.AutoSize = true;
            this.lblTotalEntradas.Location = new System.Drawing.Point(37, 39);
            this.lblTotalEntradas.Name = "lblTotalEntradas";
            this.lblTotalEntradas.Size = new System.Drawing.Size(103, 17);
            this.lblTotalEntradas.TabIndex = 0;
            this.lblTotalEntradas.Text = "Total entradas:";
            // 
            // dgvSalidas
            // 
            this.dgvSalidas.AllowUserToAddRows = false;
            this.dgvSalidas.AllowUserToDeleteRows = false;
            this.dgvSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalidas.Location = new System.Drawing.Point(0, 0);
            this.dgvSalidas.Name = "dgvSalidas";
            this.dgvSalidas.ReadOnly = true;
            this.dgvSalidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalidas.Size = new System.Drawing.Size(800, 349);
            this.dgvSalidas.TabIndex = 1;
            // 
            // lblTotalSalidas
            // 
            this.lblTotalSalidas.AutoSize = true;
            this.lblTotalSalidas.Location = new System.Drawing.Point(48, 84);
            this.lblTotalSalidas.Name = "lblTotalSalidas";
            this.lblTotalSalidas.Size = new System.Drawing.Size(92, 17);
            this.lblTotalSalidas.TabIndex = 1;
            this.lblTotalSalidas.Text = "Total salidas:";
            // 
            // tabEntradas
            // 
            this.tabEntradas.Controls.Add(this.txtTabTotalEntradas);
            this.tabEntradas.Controls.Add(this.lblTabEntradasTotal);
            this.tabEntradas.Controls.Add(this.dgvEntradas);
            this.tabEntradas.Location = new System.Drawing.Point(4, 26);
            this.tabEntradas.Name = "tabEntradas";
            this.tabEntradas.Padding = new System.Windows.Forms.Padding(3);
            this.tabEntradas.Size = new System.Drawing.Size(800, 388);
            this.tabEntradas.TabIndex = 0;
            this.tabEntradas.Text = "Entradas";
            this.tabEntradas.UseVisualStyleBackColor = true;
            // 
            // dgvEntradas
            // 
            this.dgvEntradas.AllowUserToAddRows = false;
            this.dgvEntradas.AllowUserToDeleteRows = false;
            this.dgvEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntradas.Location = new System.Drawing.Point(0, 0);
            this.dgvEntradas.Name = "dgvEntradas";
            this.dgvEntradas.ReadOnly = true;
            this.dgvEntradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntradas.Size = new System.Drawing.Size(800, 350);
            this.dgvEntradas.TabIndex = 0;
            // 
            // tabSalidas
            // 
            this.tabSalidas.Controls.Add(this.txtTabTotalSalidas);
            this.tabSalidas.Controls.Add(this.lblTabTotalSalidas);
            this.tabSalidas.Controls.Add(this.dgvSalidas);
            this.tabSalidas.Location = new System.Drawing.Point(4, 26);
            this.tabSalidas.Name = "tabSalidas";
            this.tabSalidas.Padding = new System.Windows.Forms.Padding(3);
            this.tabSalidas.Size = new System.Drawing.Size(800, 388);
            this.tabSalidas.TabIndex = 1;
            this.tabSalidas.Text = "Salidas";
            this.tabSalidas.UseVisualStyleBackColor = true;
            // 
            // lblDiezmo
            // 
            this.lblDiezmo.AutoSize = true;
            this.lblDiezmo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiezmo.Location = new System.Drawing.Point(364, 18);
            this.lblDiezmo.Name = "lblDiezmo";
            this.lblDiezmo.Size = new System.Drawing.Size(79, 22);
            this.lblDiezmo.TabIndex = 17;
            this.lblDiezmo.Text = "Diezmo";
            // 
            // tabTotales
            // 
            this.tabTotales.Controls.Add(this.txtTotal);
            this.tabTotales.Controls.Add(this.lblTotal);
            this.tabTotales.Controls.Add(this.txtTotalSalidas);
            this.tabTotales.Controls.Add(this.txtTotalEntradas);
            this.tabTotales.Controls.Add(this.lblTotalSalidas);
            this.tabTotales.Controls.Add(this.lblTotalEntradas);
            this.tabTotales.Location = new System.Drawing.Point(4, 26);
            this.tabTotales.Name = "tabTotales";
            this.tabTotales.Size = new System.Drawing.Size(800, 388);
            this.tabTotales.TabIndex = 2;
            this.tabTotales.Text = "Totales";
            this.tabTotales.UseVisualStyleBackColor = true;
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabEntradas);
            this.tab.Controls.Add(this.tabSalidas);
            this.tab.Controls.Add(this.tabTotales);
            this.tab.Location = new System.Drawing.Point(12, 66);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(808, 418);
            this.tab.TabIndex = 18;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(324, 490);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(98, 43);
            this.btnRegresar.TabIndex = 16;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(116, 490);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(98, 43);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(220, 490);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(98, 43);
            this.btnBorrar.TabIndex = 14;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 490);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(98, 43);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtTabTotalEntradas
            // 
            this.txtTabTotalEntradas.Location = new System.Drawing.Point(238, 356);
            this.txtTabTotalEntradas.Name = "txtTabTotalEntradas";
            this.txtTabTotalEntradas.ReadOnly = true;
            this.txtTabTotalEntradas.Size = new System.Drawing.Size(113, 25);
            this.txtTabTotalEntradas.TabIndex = 4;
            // 
            // lblTabEntradasTotal
            // 
            this.lblTabEntradasTotal.AutoSize = true;
            this.lblTabEntradasTotal.Location = new System.Drawing.Point(129, 359);
            this.lblTabEntradasTotal.Name = "lblTabEntradasTotal";
            this.lblTabEntradasTotal.Size = new System.Drawing.Size(103, 17);
            this.lblTabEntradasTotal.TabIndex = 3;
            this.lblTabEntradasTotal.Text = "Total entradas:";
            // 
            // txtTabTotalSalidas
            // 
            this.txtTabTotalSalidas.Location = new System.Drawing.Point(228, 355);
            this.txtTabTotalSalidas.Name = "txtTabTotalSalidas";
            this.txtTabTotalSalidas.ReadOnly = true;
            this.txtTabTotalSalidas.Size = new System.Drawing.Size(113, 25);
            this.txtTabTotalSalidas.TabIndex = 6;
            // 
            // lblTabTotalSalidas
            // 
            this.lblTabTotalSalidas.AutoSize = true;
            this.lblTabTotalSalidas.Location = new System.Drawing.Point(130, 358);
            this.lblTabTotalSalidas.Name = "lblTabTotalSalidas";
            this.lblTabTotalSalidas.Size = new System.Drawing.Size(92, 17);
            this.lblTabTotalSalidas.TabIndex = 5;
            this.lblTabTotalSalidas.Text = "Total salidas:";
            // 
            // Diezmo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 539);
            this.Controls.Add(this.lblDiezmo);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnNuevo);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Diezmo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OfrendaDiezmo";
            this.Load += new System.EventHandler(this.Diezmo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalidas)).EndInit();
            this.tabEntradas.ResumeLayout(false);
            this.tabEntradas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).EndInit();
            this.tabSalidas.ResumeLayout(false);
            this.tabSalidas.PerformLayout();
            this.tabTotales.ResumeLayout(false);
            this.tabTotales.PerformLayout();
            this.tab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotalSalidas;
        private System.Windows.Forms.TextBox txtTotalEntradas;
        private System.Windows.Forms.Label lblTotalEntradas;
        private System.Windows.Forms.DataGridView dgvSalidas;
        private System.Windows.Forms.Label lblTotalSalidas;
        private System.Windows.Forms.TabPage tabEntradas;
        private System.Windows.Forms.DataGridView dgvEntradas;
        private System.Windows.Forms.TabPage tabSalidas;
        private System.Windows.Forms.Label lblDiezmo;
        private System.Windows.Forms.TabPage tabTotales;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtTabTotalEntradas;
        private System.Windows.Forms.Label lblTabEntradasTotal;
        private System.Windows.Forms.TextBox txtTabTotalSalidas;
        private System.Windows.Forms.Label lblTabTotalSalidas;
    }
}