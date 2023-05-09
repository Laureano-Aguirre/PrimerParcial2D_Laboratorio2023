namespace Form_Login
{
    partial class FormModificarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificarProducto));
            this.cmb_ModificarSeleccionarCarne = new System.Windows.Forms.ComboBox();
            this.lb_ModificarSeleccionarCorte = new System.Windows.Forms.Label();
            this.chb_ModificarStock = new System.Windows.Forms.CheckBox();
            this.chb_ModificarPrecioXKilo = new System.Windows.Forms.CheckBox();
            this.gb_Modificar = new System.Windows.Forms.GroupBox();
            this.lb_ModificarStock = new System.Windows.Forms.Label();
            this.lb_ModificarPrecioXKilo = new System.Windows.Forms.Label();
            this.txb_ModificarStock = new System.Windows.Forms.TextBox();
            this.txb_ModificarPrecioXKilo = new System.Windows.Forms.TextBox();
            this.btn_ModificarCancelar = new System.Windows.Forms.Button();
            this.btn_ModificarModificar = new System.Windows.Forms.Button();
            this.gb_Modificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_ModificarSeleccionarCarne
            // 
            this.cmb_ModificarSeleccionarCarne.FormattingEnabled = true;
            this.cmb_ModificarSeleccionarCarne.Location = new System.Drawing.Point(12, 46);
            this.cmb_ModificarSeleccionarCarne.Name = "cmb_ModificarSeleccionarCarne";
            this.cmb_ModificarSeleccionarCarne.Size = new System.Drawing.Size(139, 23);
            this.cmb_ModificarSeleccionarCarne.TabIndex = 13;
            // 
            // lb_ModificarSeleccionarCorte
            // 
            this.lb_ModificarSeleccionarCorte.AutoSize = true;
            this.lb_ModificarSeleccionarCorte.Location = new System.Drawing.Point(12, 28);
            this.lb_ModificarSeleccionarCorte.Name = "lb_ModificarSeleccionarCorte";
            this.lb_ModificarSeleccionarCorte.Size = new System.Drawing.Size(134, 15);
            this.lb_ModificarSeleccionarCorte.TabIndex = 12;
            this.lb_ModificarSeleccionarCorte.Text = "Seleccione aquí el corte:";
            // 
            // chb_ModificarStock
            // 
            this.chb_ModificarStock.AutoSize = true;
            this.chb_ModificarStock.Location = new System.Drawing.Point(6, 45);
            this.chb_ModificarStock.Name = "chb_ModificarStock";
            this.chb_ModificarStock.Size = new System.Drawing.Size(55, 19);
            this.chb_ModificarStock.TabIndex = 15;
            this.chb_ModificarStock.Text = "Stock";
            this.chb_ModificarStock.UseVisualStyleBackColor = true;
            // 
            // chb_ModificarPrecioXKilo
            // 
            this.chb_ModificarPrecioXKilo.AutoSize = true;
            this.chb_ModificarPrecioXKilo.Location = new System.Drawing.Point(101, 45);
            this.chb_ModificarPrecioXKilo.Name = "chb_ModificarPrecioXKilo";
            this.chb_ModificarPrecioXKilo.Size = new System.Drawing.Size(102, 19);
            this.chb_ModificarPrecioXKilo.TabIndex = 16;
            this.chb_ModificarPrecioXKilo.Text = "Precio por kilo";
            this.chb_ModificarPrecioXKilo.UseVisualStyleBackColor = true;
            // 
            // gb_Modificar
            // 
            this.gb_Modificar.Controls.Add(this.chb_ModificarStock);
            this.gb_Modificar.Controls.Add(this.chb_ModificarPrecioXKilo);
            this.gb_Modificar.Location = new System.Drawing.Point(12, 124);
            this.gb_Modificar.Name = "gb_Modificar";
            this.gb_Modificar.Size = new System.Drawing.Size(209, 100);
            this.gb_Modificar.TabIndex = 17;
            this.gb_Modificar.TabStop = false;
            this.gb_Modificar.Text = "Modificar";
            // 
            // lb_ModificarStock
            // 
            this.lb_ModificarStock.AutoSize = true;
            this.lb_ModificarStock.Location = new System.Drawing.Point(57, 258);
            this.lb_ModificarStock.Name = "lb_ModificarStock";
            this.lb_ModificarStock.Size = new System.Drawing.Size(36, 15);
            this.lb_ModificarStock.TabIndex = 18;
            this.lb_ModificarStock.Text = "Stock";
            // 
            // lb_ModificarPrecioXKilo
            // 
            this.lb_ModificarPrecioXKilo.AutoSize = true;
            this.lb_ModificarPrecioXKilo.Location = new System.Drawing.Point(227, 258);
            this.lb_ModificarPrecioXKilo.Name = "lb_ModificarPrecioXKilo";
            this.lb_ModificarPrecioXKilo.Size = new System.Drawing.Size(83, 15);
            this.lb_ModificarPrecioXKilo.TabIndex = 19;
            this.lb_ModificarPrecioXKilo.Text = "Precio por kilo";
            // 
            // txb_ModificarStock
            // 
            this.txb_ModificarStock.Location = new System.Drawing.Point(28, 285);
            this.txb_ModificarStock.Name = "txb_ModificarStock";
            this.txb_ModificarStock.Size = new System.Drawing.Size(100, 23);
            this.txb_ModificarStock.TabIndex = 20;
            // 
            // txb_ModificarPrecioXKilo
            // 
            this.txb_ModificarPrecioXKilo.Location = new System.Drawing.Point(220, 285);
            this.txb_ModificarPrecioXKilo.Name = "txb_ModificarPrecioXKilo";
            this.txb_ModificarPrecioXKilo.Size = new System.Drawing.Size(100, 23);
            this.txb_ModificarPrecioXKilo.TabIndex = 21;
            // 
            // btn_ModificarCancelar
            // 
            this.btn_ModificarCancelar.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_ModificarCancelar.Location = new System.Drawing.Point(12, 344);
            this.btn_ModificarCancelar.Name = "btn_ModificarCancelar";
            this.btn_ModificarCancelar.Size = new System.Drawing.Size(81, 39);
            this.btn_ModificarCancelar.TabIndex = 22;
            this.btn_ModificarCancelar.Text = "Cancelar";
            this.btn_ModificarCancelar.UseVisualStyleBackColor = false;
            this.btn_ModificarCancelar.Click += new System.EventHandler(this.btn_ModificarCancelar_Click);
            // 
            // btn_ModificarModificar
            // 
            this.btn_ModificarModificar.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_ModificarModificar.Location = new System.Drawing.Point(262, 344);
            this.btn_ModificarModificar.Name = "btn_ModificarModificar";
            this.btn_ModificarModificar.Size = new System.Drawing.Size(81, 39);
            this.btn_ModificarModificar.TabIndex = 23;
            this.btn_ModificarModificar.Text = "Modificar";
            this.btn_ModificarModificar.UseVisualStyleBackColor = false;
            this.btn_ModificarModificar.Click += new System.EventHandler(this.btn_ModificarModificar_Click);
            // 
            // FormModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(355, 395);
            this.Controls.Add(this.btn_ModificarModificar);
            this.Controls.Add(this.btn_ModificarCancelar);
            this.Controls.Add(this.txb_ModificarPrecioXKilo);
            this.Controls.Add(this.txb_ModificarStock);
            this.Controls.Add(this.lb_ModificarPrecioXKilo);
            this.Controls.Add(this.lb_ModificarStock);
            this.Controls.Add(this.gb_Modificar);
            this.Controls.Add(this.cmb_ModificarSeleccionarCarne);
            this.Controls.Add(this.lb_ModificarSeleccionarCorte);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormModificarProducto";
            this.Text = "Modificar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormModificarProducto_FormClosing);
            this.Load += new System.EventHandler(this.FormModificarProducto_Load);
            this.gb_Modificar.ResumeLayout(false);
            this.gb_Modificar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmb_ModificarSeleccionarCarne;
        private Label lb_ModificarSeleccionarCorte;
        private CheckBox chb_ModificarStock;
        private CheckBox chb_ModificarPrecioXKilo;
        private GroupBox gb_Modificar;
        private Label lb_ModificarStock;
        private Label lb_ModificarPrecioXKilo;
        private TextBox txb_ModificarStock;
        private TextBox txb_ModificarPrecioXKilo;
        private Button btn_ModificarCancelar;
        private Button btn_ModificarModificar;
    }
}