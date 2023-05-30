namespace Form_Login
{
    partial class FormAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregar));
            this.label1 = new System.Windows.Forms.Label();
            this.rdb_AgregarTipoDeCorte = new System.Windows.Forms.RadioButton();
            this.rdb_AgregarStock = new System.Windows.Forms.RadioButton();
            this.txb_AgregarTipoDeCorte = new System.Windows.Forms.TextBox();
            this.lb_AgregarTipoDeCorte = new System.Windows.Forms.Label();
            this.nud_AgregarStock = new System.Windows.Forms.NumericUpDown();
            this.lb_AgregarStock = new System.Windows.Forms.Label();
            this.lb_AgregarSeleccionarCorte = new System.Windows.Forms.Label();
            this.btn_AgregarAgregar = new System.Windows.Forms.Button();
            this.btn_AgregarCancelar = new System.Windows.Forms.Button();
            this.txb_AgregarStockNuevoCorte = new System.Windows.Forms.TextBox();
            this.lb_AgregarStockNuevoCorte = new System.Windows.Forms.Label();
            this.txb_AgregarPrecioXKiloCorte = new System.Windows.Forms.TextBox();
            this.lb_AgregarPrecioXKiloCorte = new System.Windows.Forms.Label();
            this.cmb_AgregarSeleccionarCorte = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_AgregarStock)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Que desea agregar?";
            // 
            // rdb_AgregarTipoDeCorte
            // 
            this.rdb_AgregarTipoDeCorte.AutoSize = true;
            this.rdb_AgregarTipoDeCorte.Location = new System.Drawing.Point(22, 63);
            this.rdb_AgregarTipoDeCorte.Name = "rdb_AgregarTipoDeCorte";
            this.rdb_AgregarTipoDeCorte.Size = new System.Drawing.Size(94, 19);
            this.rdb_AgregarTipoDeCorte.TabIndex = 1;
            this.rdb_AgregarTipoDeCorte.Text = "Tipo de corte";
            this.rdb_AgregarTipoDeCorte.UseVisualStyleBackColor = true;
            this.rdb_AgregarTipoDeCorte.CheckedChanged += new System.EventHandler(this.rdb_AgregarTipoDeCorte_CheckedChanged_1);
            // 
            // rdb_AgregarStock
            // 
            this.rdb_AgregarStock.AutoSize = true;
            this.rdb_AgregarStock.Location = new System.Drawing.Point(243, 63);
            this.rdb_AgregarStock.Name = "rdb_AgregarStock";
            this.rdb_AgregarStock.Size = new System.Drawing.Size(54, 19);
            this.rdb_AgregarStock.TabIndex = 2;
            this.rdb_AgregarStock.Text = "Stock";
            this.rdb_AgregarStock.UseVisualStyleBackColor = true;
            this.rdb_AgregarStock.CheckedChanged += new System.EventHandler(this.rdb_AgregarStock_CheckedChanged_1);
            // 
            // txb_AgregarTipoDeCorte
            // 
            this.txb_AgregarTipoDeCorte.Location = new System.Drawing.Point(12, 138);
            this.txb_AgregarTipoDeCorte.Name = "txb_AgregarTipoDeCorte";
            this.txb_AgregarTipoDeCorte.PlaceholderText = "Ingrese aqui";
            this.txb_AgregarTipoDeCorte.Size = new System.Drawing.Size(139, 23);
            this.txb_AgregarTipoDeCorte.TabIndex = 3;
            // 
            // lb_AgregarTipoDeCorte
            // 
            this.lb_AgregarTipoDeCorte.AutoSize = true;
            this.lb_AgregarTipoDeCorte.Location = new System.Drawing.Point(12, 120);
            this.lb_AgregarTipoDeCorte.Name = "lb_AgregarTipoDeCorte";
            this.lb_AgregarTipoDeCorte.Size = new System.Drawing.Size(159, 15);
            this.lb_AgregarTipoDeCorte.TabIndex = 4;
            this.lb_AgregarTipoDeCorte.Text = "Agregue aquí el nuevo corte:";
            // 
            // nud_AgregarStock
            // 
            this.nud_AgregarStock.DecimalPlaces = 1;
            this.nud_AgregarStock.Location = new System.Drawing.Point(68, 299);
            this.nud_AgregarStock.Name = "nud_AgregarStock";
            this.nud_AgregarStock.Size = new System.Drawing.Size(68, 23);
            this.nud_AgregarStock.TabIndex = 5;
            // 
            // lb_AgregarStock
            // 
            this.lb_AgregarStock.AutoSize = true;
            this.lb_AgregarStock.Location = new System.Drawing.Point(12, 281);
            this.lb_AgregarStock.Name = "lb_AgregarStock";
            this.lb_AgregarStock.Size = new System.Drawing.Size(182, 15);
            this.lb_AgregarStock.TabIndex = 6;
            this.lb_AgregarStock.Text = "Agregue aquí para reponer stock:";
            // 
            // lb_AgregarSeleccionarCorte
            // 
            this.lb_AgregarSeleccionarCorte.AutoSize = true;
            this.lb_AgregarSeleccionarCorte.Location = new System.Drawing.Point(12, 200);
            this.lb_AgregarSeleccionarCorte.Name = "lb_AgregarSeleccionarCorte";
            this.lb_AgregarSeleccionarCorte.Size = new System.Drawing.Size(134, 15);
            this.lb_AgregarSeleccionarCorte.TabIndex = 8;
            this.lb_AgregarSeleccionarCorte.Text = "Seleccione aquí el corte:";
            // 
            // btn_AgregarAgregar
            // 
            this.btn_AgregarAgregar.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_AgregarAgregar.Location = new System.Drawing.Point(310, 365);
            this.btn_AgregarAgregar.Name = "btn_AgregarAgregar";
            this.btn_AgregarAgregar.Size = new System.Drawing.Size(81, 36);
            this.btn_AgregarAgregar.TabIndex = 9;
            this.btn_AgregarAgregar.Text = "Agregar";
            this.btn_AgregarAgregar.UseVisualStyleBackColor = false;
            this.btn_AgregarAgregar.Click += new System.EventHandler(this.btn_AgregarAgregar_Click_1);
            // 
            // btn_AgregarCancelar
            // 
            this.btn_AgregarCancelar.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_AgregarCancelar.Location = new System.Drawing.Point(12, 365);
            this.btn_AgregarCancelar.Name = "btn_AgregarCancelar";
            this.btn_AgregarCancelar.Size = new System.Drawing.Size(81, 36);
            this.btn_AgregarCancelar.TabIndex = 10;
            this.btn_AgregarCancelar.Text = "Cancelar";
            this.btn_AgregarCancelar.UseVisualStyleBackColor = false;
            this.btn_AgregarCancelar.Click += new System.EventHandler(this.btn_AgregarCancelar_Click_1);
            // 
            // txb_AgregarStockNuevoCorte
            // 
            this.txb_AgregarStockNuevoCorte.Location = new System.Drawing.Point(230, 138);
            this.txb_AgregarStockNuevoCorte.Name = "txb_AgregarStockNuevoCorte";
            this.txb_AgregarStockNuevoCorte.PlaceholderText = "Ingrese aqui";
            this.txb_AgregarStockNuevoCorte.Size = new System.Drawing.Size(100, 23);
            this.txb_AgregarStockNuevoCorte.TabIndex = 12;
            // 
            // lb_AgregarStockNuevoCorte
            // 
            this.lb_AgregarStockNuevoCorte.AutoSize = true;
            this.lb_AgregarStockNuevoCorte.Location = new System.Drawing.Point(230, 120);
            this.lb_AgregarStockNuevoCorte.Name = "lb_AgregarStockNuevoCorte";
            this.lb_AgregarStockNuevoCorte.Size = new System.Drawing.Size(124, 15);
            this.lb_AgregarStockNuevoCorte.TabIndex = 13;
            this.lb_AgregarStockNuevoCorte.Text = "Agregue aquí el stock:";
            // 
            // txb_AgregarPrecioXKiloCorte
            // 
            this.txb_AgregarPrecioXKiloCorte.Location = new System.Drawing.Point(230, 218);
            this.txb_AgregarPrecioXKiloCorte.Name = "txb_AgregarPrecioXKiloCorte";
            this.txb_AgregarPrecioXKiloCorte.PlaceholderText = "Ingrese aqui";
            this.txb_AgregarPrecioXKiloCorte.Size = new System.Drawing.Size(100, 23);
            this.txb_AgregarPrecioXKiloCorte.TabIndex = 14;
            // 
            // lb_AgregarPrecioXKiloCorte
            // 
            this.lb_AgregarPrecioXKiloCorte.AutoSize = true;
            this.lb_AgregarPrecioXKiloCorte.Location = new System.Drawing.Point(230, 200);
            this.lb_AgregarPrecioXKiloCorte.Name = "lb_AgregarPrecioXKiloCorte";
            this.lb_AgregarPrecioXKiloCorte.Size = new System.Drawing.Size(172, 15);
            this.lb_AgregarPrecioXKiloCorte.TabIndex = 15;
            this.lb_AgregarPrecioXKiloCorte.Text = "Agregue aquí el precio por kilo:";
            // 
            // cmb_AgregarSeleccionarCorte
            // 
            this.cmb_AgregarSeleccionarCorte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_AgregarSeleccionarCorte.FormattingEnabled = true;
            this.cmb_AgregarSeleccionarCorte.Location = new System.Drawing.Point(12, 218);
            this.cmb_AgregarSeleccionarCorte.Name = "cmb_AgregarSeleccionarCorte";
            this.cmb_AgregarSeleccionarCorte.Size = new System.Drawing.Size(139, 23);
            this.cmb_AgregarSeleccionarCorte.TabIndex = 16;
            // 
            // FormAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(403, 413);
            this.Controls.Add(this.cmb_AgregarSeleccionarCorte);
            this.Controls.Add(this.lb_AgregarPrecioXKiloCorte);
            this.Controls.Add(this.txb_AgregarPrecioXKiloCorte);
            this.Controls.Add(this.lb_AgregarStockNuevoCorte);
            this.Controls.Add(this.txb_AgregarStockNuevoCorte);
            this.Controls.Add(this.btn_AgregarCancelar);
            this.Controls.Add(this.btn_AgregarAgregar);
            this.Controls.Add(this.lb_AgregarSeleccionarCorte);
            this.Controls.Add(this.lb_AgregarStock);
            this.Controls.Add(this.nud_AgregarStock);
            this.Controls.Add(this.lb_AgregarTipoDeCorte);
            this.Controls.Add(this.txb_AgregarTipoDeCorte);
            this.Controls.Add(this.rdb_AgregarStock);
            this.Controls.Add(this.rdb_AgregarTipoDeCorte);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAgregar";
            this.Text = "Agregar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAgregar_FormClosing_1);
            this.Load += new System.EventHandler(this.FormAgregar_Load_1);
            this.Shown += new System.EventHandler(this.FormAgregar_Shown_1);
            ((System.ComponentModel.ISupportInitialize)(this.nud_AgregarStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RadioButton rdb_AgregarTipoDeCorte;
        private RadioButton rdb_AgregarStock;
        private TextBox txb_AgregarTipoDeCorte;
        private Label lb_AgregarTipoDeCorte;
        private NumericUpDown nud_AgregarStock;
        private Label lb_AgregarStock;
        private Label lb_AgregarSeleccionarCorte;
        private Button btn_AgregarAgregar;
        private Button btn_AgregarCancelar;
        private TextBox txb_AgregarStockNuevoCorte;
        private Label lb_AgregarStockNuevoCorte;
        private TextBox txb_AgregarPrecioXKiloCorte;
        private Label lb_AgregarPrecioXKiloCorte;
        private ComboBox cmb_AgregarSeleccionarCorte;
    }
}