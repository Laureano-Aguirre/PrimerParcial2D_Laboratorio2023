namespace Form_Login
{
    partial class FormVendedorVender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVendedorVender));
            this.lb_VenderVendedorCliente = new System.Windows.Forms.Label();
            this.rtb_VendedorVenderClientes = new System.Windows.Forms.RichTextBox();
            this.btn_VendedorVenderCancelar = new System.Windows.Forms.Button();
            this.btn_VendedorVender = new System.Windows.Forms.Button();
            this.lb_lb_VenderVendedorSeleccionarCliente = new System.Windows.Forms.Label();
            this.cmb_VenderSeleccionarCliente = new System.Windows.Forms.ComboBox();
            this.cmb_VenderSeleccionarCorte = new System.Windows.Forms.ComboBox();
            this.rtb_VenderMostrarCompra = new System.Windows.Forms.RichTextBox();
            this.nud_VenderKilos = new System.Windows.Forms.NumericUpDown();
            this.gb_VenderSeleccionanrCorte = new System.Windows.Forms.GroupBox();
            this.gb_VenderKilos = new System.Windows.Forms.GroupBox();
            this.gb_VenderMetodoPago = new System.Windows.Forms.GroupBox();
            this.btn_VenderEfectivo = new System.Windows.Forms.Button();
            this.gpb_VenderPrecioPorKilo = new System.Windows.Forms.GroupBox();
            this.lb_VenderPrecioPorKilo = new System.Windows.Forms.Label();
            this.rtb_VenderPrecioPorKilo = new System.Windows.Forms.RichTextBox();
            this.lb_VenderCostoParcial = new System.Windows.Forms.Label();
            this.lb_VenderSignoPesoParcial = new System.Windows.Forms.Label();
            this.lb_VenderEnZocaloCostoParcial = new System.Windows.Forms.Label();
            this.rtb_VenderCostoTotal = new System.Windows.Forms.RichTextBox();
            this.btn_VenderAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_VenderKilos)).BeginInit();
            this.gb_VenderSeleccionanrCorte.SuspendLayout();
            this.gb_VenderKilos.SuspendLayout();
            this.gb_VenderMetodoPago.SuspendLayout();
            this.gpb_VenderPrecioPorKilo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_VenderVendedorCliente
            // 
            this.lb_VenderVendedorCliente.AutoSize = true;
            this.lb_VenderVendedorCliente.BackColor = System.Drawing.Color.Transparent;
            this.lb_VenderVendedorCliente.Location = new System.Drawing.Point(12, 21);
            this.lb_VenderVendedorCliente.Name = "lb_VenderVendedorCliente";
            this.lb_VenderVendedorCliente.Size = new System.Drawing.Size(49, 15);
            this.lb_VenderVendedorCliente.TabIndex = 0;
            this.lb_VenderVendedorCliente.Text = "Clientes";
            // 
            // rtb_VendedorVenderClientes
            // 
            this.rtb_VendedorVenderClientes.Location = new System.Drawing.Point(12, 39);
            this.rtb_VendedorVenderClientes.Name = "rtb_VendedorVenderClientes";
            this.rtb_VendedorVenderClientes.ReadOnly = true;
            this.rtb_VendedorVenderClientes.Size = new System.Drawing.Size(263, 84);
            this.rtb_VendedorVenderClientes.TabIndex = 1;
            this.rtb_VendedorVenderClientes.Text = "";
            // 
            // btn_VendedorVenderCancelar
            // 
            this.btn_VendedorVenderCancelar.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_VendedorVenderCancelar.Location = new System.Drawing.Point(12, 475);
            this.btn_VendedorVenderCancelar.Name = "btn_VendedorVenderCancelar";
            this.btn_VendedorVenderCancelar.Size = new System.Drawing.Size(101, 39);
            this.btn_VendedorVenderCancelar.TabIndex = 2;
            this.btn_VendedorVenderCancelar.Text = "Cancelar";
            this.btn_VendedorVenderCancelar.UseVisualStyleBackColor = false;
            this.btn_VendedorVenderCancelar.Click += new System.EventHandler(this.btn_VendedorVenderCancelar_Click);
            // 
            // btn_VendedorVender
            // 
            this.btn_VendedorVender.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_VendedorVender.Location = new System.Drawing.Point(528, 475);
            this.btn_VendedorVender.Name = "btn_VendedorVender";
            this.btn_VendedorVender.Size = new System.Drawing.Size(101, 39);
            this.btn_VendedorVender.TabIndex = 3;
            this.btn_VendedorVender.Text = "Vender";
            this.btn_VendedorVender.UseVisualStyleBackColor = false;
            this.btn_VendedorVender.Click += new System.EventHandler(this.btn_VendedorVender_Click);
            // 
            // lb_lb_VenderVendedorSeleccionarCliente
            // 
            this.lb_lb_VenderVendedorSeleccionarCliente.AutoSize = true;
            this.lb_lb_VenderVendedorSeleccionarCliente.BackColor = System.Drawing.Color.Transparent;
            this.lb_lb_VenderVendedorSeleccionarCliente.Location = new System.Drawing.Point(437, 21);
            this.lb_lb_VenderVendedorSeleccionarCliente.Name = "lb_lb_VenderVendedorSeleccionarCliente";
            this.lb_lb_VenderVendedorSeleccionarCliente.Size = new System.Drawing.Size(118, 15);
            this.lb_lb_VenderVendedorSeleccionarCliente.TabIndex = 4;
            this.lb_lb_VenderVendedorSeleccionarCliente.Text = "Seleccione un cliente";
            // 
            // cmb_VenderSeleccionarCliente
            // 
            this.cmb_VenderSeleccionarCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_VenderSeleccionarCliente.FormattingEnabled = true;
            this.cmb_VenderSeleccionarCliente.Location = new System.Drawing.Point(437, 39);
            this.cmb_VenderSeleccionarCliente.Name = "cmb_VenderSeleccionarCliente";
            this.cmb_VenderSeleccionarCliente.Size = new System.Drawing.Size(192, 23);
            this.cmb_VenderSeleccionarCliente.TabIndex = 5;
            this.cmb_VenderSeleccionarCliente.SelectedValueChanged += new System.EventHandler(this.cmb_VenderSeleccionarCliente_SelectedValueChanged);
            // 
            // cmb_VenderSeleccionarCorte
            // 
            this.cmb_VenderSeleccionarCorte.FormattingEnabled = true;
            this.cmb_VenderSeleccionarCorte.Location = new System.Drawing.Point(6, 22);
            this.cmb_VenderSeleccionarCorte.Name = "cmb_VenderSeleccionarCorte";
            this.cmb_VenderSeleccionarCorte.Size = new System.Drawing.Size(156, 23);
            this.cmb_VenderSeleccionarCorte.TabIndex = 7;
            this.cmb_VenderSeleccionarCorte.SelectedValueChanged += new System.EventHandler(this.cmb_VenderSeleccionarCorte_SelectedValueChanged);
            // 
            // rtb_VenderMostrarCompra
            // 
            this.rtb_VenderMostrarCompra.Location = new System.Drawing.Point(437, 142);
            this.rtb_VenderMostrarCompra.Name = "rtb_VenderMostrarCompra";
            this.rtb_VenderMostrarCompra.ReadOnly = true;
            this.rtb_VenderMostrarCompra.Size = new System.Drawing.Size(192, 200);
            this.rtb_VenderMostrarCompra.TabIndex = 8;
            this.rtb_VenderMostrarCompra.Text = "";
            // 
            // nud_VenderKilos
            // 
            this.nud_VenderKilos.DecimalPlaces = 1;
            this.nud_VenderKilos.Location = new System.Drawing.Point(6, 22);
            this.nud_VenderKilos.Name = "nud_VenderKilos";
            this.nud_VenderKilos.Size = new System.Drawing.Size(78, 23);
            this.nud_VenderKilos.TabIndex = 10;
            this.nud_VenderKilos.ValueChanged += new System.EventHandler(this.nud_VenderKilos_ValueChanged);
            // 
            // gb_VenderSeleccionanrCorte
            // 
            this.gb_VenderSeleccionanrCorte.BackColor = System.Drawing.Color.Transparent;
            this.gb_VenderSeleccionanrCorte.Controls.Add(this.cmb_VenderSeleccionarCorte);
            this.gb_VenderSeleccionanrCorte.Location = new System.Drawing.Point(12, 145);
            this.gb_VenderSeleccionanrCorte.Name = "gb_VenderSeleccionanrCorte";
            this.gb_VenderSeleccionanrCorte.Size = new System.Drawing.Size(200, 63);
            this.gb_VenderSeleccionanrCorte.TabIndex = 11;
            this.gb_VenderSeleccionanrCorte.TabStop = false;
            this.gb_VenderSeleccionanrCorte.Text = "Seleccionar corte";
            // 
            // gb_VenderKilos
            // 
            this.gb_VenderKilos.BackColor = System.Drawing.Color.Transparent;
            this.gb_VenderKilos.Controls.Add(this.nud_VenderKilos);
            this.gb_VenderKilos.Location = new System.Drawing.Point(12, 297);
            this.gb_VenderKilos.Name = "gb_VenderKilos";
            this.gb_VenderKilos.Size = new System.Drawing.Size(105, 65);
            this.gb_VenderKilos.TabIndex = 12;
            this.gb_VenderKilos.TabStop = false;
            this.gb_VenderKilos.Text = "Kilo/s";
            // 
            // gb_VenderMetodoPago
            // 
            this.gb_VenderMetodoPago.BackColor = System.Drawing.Color.Transparent;
            this.gb_VenderMetodoPago.Controls.Add(this.btn_VenderEfectivo);
            this.gb_VenderMetodoPago.Location = new System.Drawing.Point(12, 368);
            this.gb_VenderMetodoPago.Name = "gb_VenderMetodoPago";
            this.gb_VenderMetodoPago.Size = new System.Drawing.Size(131, 59);
            this.gb_VenderMetodoPago.TabIndex = 13;
            this.gb_VenderMetodoPago.TabStop = false;
            this.gb_VenderMetodoPago.Text = "Metodo de pago";
            // 
            // btn_VenderEfectivo
            // 
            this.btn_VenderEfectivo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_VenderEfectivo.Location = new System.Drawing.Point(26, 21);
            this.btn_VenderEfectivo.Name = "btn_VenderEfectivo";
            this.btn_VenderEfectivo.Size = new System.Drawing.Size(75, 32);
            this.btn_VenderEfectivo.TabIndex = 0;
            this.btn_VenderEfectivo.Text = "Efectivo";
            this.btn_VenderEfectivo.UseVisualStyleBackColor = false;
            this.btn_VenderEfectivo.Click += new System.EventHandler(this.btn_VenderEfectivo_Click);
            // 
            // gpb_VenderPrecioPorKilo
            // 
            this.gpb_VenderPrecioPorKilo.BackColor = System.Drawing.Color.Transparent;
            this.gpb_VenderPrecioPorKilo.Controls.Add(this.lb_VenderPrecioPorKilo);
            this.gpb_VenderPrecioPorKilo.Controls.Add(this.rtb_VenderPrecioPorKilo);
            this.gpb_VenderPrecioPorKilo.Location = new System.Drawing.Point(12, 228);
            this.gpb_VenderPrecioPorKilo.Name = "gpb_VenderPrecioPorKilo";
            this.gpb_VenderPrecioPorKilo.Size = new System.Drawing.Size(136, 63);
            this.gpb_VenderPrecioPorKilo.TabIndex = 14;
            this.gpb_VenderPrecioPorKilo.TabStop = false;
            this.gpb_VenderPrecioPorKilo.Text = "Precio por kilo";
            // 
            // lb_VenderPrecioPorKilo
            // 
            this.lb_VenderPrecioPorKilo.AutoSize = true;
            this.lb_VenderPrecioPorKilo.BackColor = System.Drawing.Color.White;
            this.lb_VenderPrecioPorKilo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_VenderPrecioPorKilo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_VenderPrecioPorKilo.Location = new System.Drawing.Point(43, 25);
            this.lb_VenderPrecioPorKilo.Name = "lb_VenderPrecioPorKilo";
            this.lb_VenderPrecioPorKilo.Size = new System.Drawing.Size(45, 19);
            this.lb_VenderPrecioPorKilo.TabIndex = 12;
            this.lb_VenderPrecioPorKilo.Text = "label1";
            // 
            // rtb_VenderPrecioPorKilo
            // 
            this.rtb_VenderPrecioPorKilo.BackColor = System.Drawing.Color.White;
            this.rtb_VenderPrecioPorKilo.Location = new System.Drawing.Point(15, 22);
            this.rtb_VenderPrecioPorKilo.Name = "rtb_VenderPrecioPorKilo";
            this.rtb_VenderPrecioPorKilo.ReadOnly = true;
            this.rtb_VenderPrecioPorKilo.Size = new System.Drawing.Size(97, 24);
            this.rtb_VenderPrecioPorKilo.TabIndex = 8;
            this.rtb_VenderPrecioPorKilo.Text = "";
            // 
            // lb_VenderCostoParcial
            // 
            this.lb_VenderCostoParcial.AutoSize = true;
            this.lb_VenderCostoParcial.BackColor = System.Drawing.Color.Transparent;
            this.lb_VenderCostoParcial.Location = new System.Drawing.Point(292, 464);
            this.lb_VenderCostoParcial.Name = "lb_VenderCostoParcial";
            this.lb_VenderCostoParcial.Size = new System.Drawing.Size(76, 15);
            this.lb_VenderCostoParcial.TabIndex = 30;
            this.lb_VenderCostoParcial.Text = "Costo parcial";
            // 
            // lb_VenderSignoPesoParcial
            // 
            this.lb_VenderSignoPesoParcial.AutoSize = true;
            this.lb_VenderSignoPesoParcial.BackColor = System.Drawing.Color.Transparent;
            this.lb_VenderSignoPesoParcial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_VenderSignoPesoParcial.Location = new System.Drawing.Point(256, 437);
            this.lb_VenderSignoPesoParcial.Name = "lb_VenderSignoPesoParcial";
            this.lb_VenderSignoPesoParcial.Size = new System.Drawing.Size(19, 21);
            this.lb_VenderSignoPesoParcial.TabIndex = 29;
            this.lb_VenderSignoPesoParcial.Text = "$";
            // 
            // lb_VenderEnZocaloCostoParcial
            // 
            this.lb_VenderEnZocaloCostoParcial.AutoSize = true;
            this.lb_VenderEnZocaloCostoParcial.BackColor = System.Drawing.Color.White;
            this.lb_VenderEnZocaloCostoParcial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_VenderEnZocaloCostoParcial.Location = new System.Drawing.Point(306, 437);
            this.lb_VenderEnZocaloCostoParcial.Name = "lb_VenderEnZocaloCostoParcial";
            this.lb_VenderEnZocaloCostoParcial.Size = new System.Drawing.Size(52, 21);
            this.lb_VenderEnZocaloCostoParcial.TabIndex = 28;
            this.lb_VenderEnZocaloCostoParcial.Text = "label1";
            // 
            // rtb_VenderCostoTotal
            // 
            this.rtb_VenderCostoTotal.BackColor = System.Drawing.Color.White;
            this.rtb_VenderCostoTotal.Location = new System.Drawing.Point(281, 434);
            this.rtb_VenderCostoTotal.Name = "rtb_VenderCostoTotal";
            this.rtb_VenderCostoTotal.ReadOnly = true;
            this.rtb_VenderCostoTotal.Size = new System.Drawing.Size(100, 27);
            this.rtb_VenderCostoTotal.TabIndex = 27;
            this.rtb_VenderCostoTotal.Text = "";
            // 
            // btn_VenderAgregar
            // 
            this.btn_VenderAgregar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_VenderAgregar.Location = new System.Drawing.Point(140, 319);
            this.btn_VenderAgregar.Name = "btn_VenderAgregar";
            this.btn_VenderAgregar.Size = new System.Drawing.Size(60, 34);
            this.btn_VenderAgregar.TabIndex = 31;
            this.btn_VenderAgregar.Text = "Agregar";
            this.btn_VenderAgregar.UseVisualStyleBackColor = false;
            this.btn_VenderAgregar.Click += new System.EventHandler(this.btn_VenderAgregar_Click);
            // 
            // FormVendedorVender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 526);
            this.Controls.Add(this.btn_VenderAgregar);
            this.Controls.Add(this.lb_VenderCostoParcial);
            this.Controls.Add(this.lb_VenderSignoPesoParcial);
            this.Controls.Add(this.lb_VenderEnZocaloCostoParcial);
            this.Controls.Add(this.rtb_VenderCostoTotal);
            this.Controls.Add(this.gpb_VenderPrecioPorKilo);
            this.Controls.Add(this.gb_VenderMetodoPago);
            this.Controls.Add(this.gb_VenderKilos);
            this.Controls.Add(this.gb_VenderSeleccionanrCorte);
            this.Controls.Add(this.rtb_VenderMostrarCompra);
            this.Controls.Add(this.cmb_VenderSeleccionarCliente);
            this.Controls.Add(this.lb_lb_VenderVendedorSeleccionarCliente);
            this.Controls.Add(this.btn_VendedorVender);
            this.Controls.Add(this.btn_VendedorVenderCancelar);
            this.Controls.Add(this.rtb_VendedorVenderClientes);
            this.Controls.Add(this.lb_VenderVendedorCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVendedorVender";
            this.Text = "Vender";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVendedorVender_FormClosing);
            this.Load += new System.EventHandler(this.FormVendedorVender_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_VenderKilos)).EndInit();
            this.gb_VenderSeleccionanrCorte.ResumeLayout(false);
            this.gb_VenderKilos.ResumeLayout(false);
            this.gb_VenderMetodoPago.ResumeLayout(false);
            this.gpb_VenderPrecioPorKilo.ResumeLayout(false);
            this.gpb_VenderPrecioPorKilo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_VenderVendedorCliente;
        private RichTextBox rtb_VendedorVenderClientes;
        private Button btn_VendedorVenderCancelar;
        private Button btn_VendedorVender;
        private Label lb_lb_VenderVendedorSeleccionarCliente;
        private ComboBox cmb_VenderSeleccionarCliente;
        private ComboBox cmb_VenderSeleccionarCorte;
        private RichTextBox rtb_VenderMostrarCompra;
        private NumericUpDown nud_VenderKilos;
        private GroupBox gb_VenderSeleccionanrCorte;
        private GroupBox gb_VenderKilos;
        private GroupBox gb_VenderMetodoPago;
        private Button btn_VenderEfectivo;
        private GroupBox gpb_VenderPrecioPorKilo;
        private Label lb_VenderPrecioPorKilo;
        private RichTextBox rtb_VenderPrecioPorKilo;
        private Label lb_VenderCostoParcial;
        private Label lb_VenderSignoPesoParcial;
        private Label lb_VenderEnZocaloCostoParcial;
        private RichTextBox rtb_VenderCostoTotal;
        private Button btn_VenderAgregar;
    }
}