namespace Form_Login
{
    partial class FormComprar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComprar));
            this.pb_BolsaCompras = new System.Windows.Forms.PictureBox();
            this.btn_CompraPagar = new System.Windows.Forms.Button();
            this.btn_ComprarCancelar = new System.Windows.Forms.Button();
            this.nud_CompraKilos = new System.Windows.Forms.NumericUpDown();
            this.rtb_CompraMonto = new System.Windows.Forms.RichTextBox();
            this.lb_CompraMonto = new System.Windows.Forms.Label();
            this.lb_CompraPeso = new System.Windows.Forms.Label();
            this.gb_CompraCortes = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_CompraCortes = new System.Windows.Forms.ComboBox();
            this.rtb_CompraPrecioPorKilo = new System.Windows.Forms.RichTextBox();
            this.gpb_CompraPrecioPorKilo = new System.Windows.Forms.GroupBox();
            this.lb_CompraPrecioPorKilo = new System.Windows.Forms.Label();
            this.gpb_CompraKilos = new System.Windows.Forms.GroupBox();
            this.gpb_CompraMetodosDePago = new System.Windows.Forms.GroupBox();
            this.pb_ComprarVisaDebito = new System.Windows.Forms.PictureBox();
            this.pb_CompraDebitoMastercard = new System.Windows.Forms.PictureBox();
            this.pb_CompraCreditoMastercard = new System.Windows.Forms.PictureBox();
            this.pb_CompraPagoVisa = new System.Windows.Forms.PictureBox();
            this.btn_CompraCredito = new System.Windows.Forms.Button();
            this.btn_CompraDebito = new System.Windows.Forms.Button();
            this.btn_CompraEfectivo = new System.Windows.Forms.Button();
            this.lb_CompraColitaDeCuadril = new System.Windows.Forms.Label();
            this.lb_CompraEntrania = new System.Windows.Forms.Label();
            this.lb_CompraTiraAsado = new System.Windows.Forms.Label();
            this.lb_CompraBolaLomo = new System.Windows.Forms.Label();
            this.lb_CompraOjoBife = new System.Windows.Forms.Label();
            this.lb_CompraBifeChorizo = new System.Windows.Forms.Label();
            this.lb_CompraTortuguita = new System.Windows.Forms.Label();
            this.lb_CompraFalda = new System.Windows.Forms.Label();
            this.rtb_ComprarCostoTotal = new System.Windows.Forms.RichTextBox();
            this.lb_ComprarCostoTotal = new System.Windows.Forms.Label();
            this.lb_CompraMontoInicial = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_BolsaCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CompraKilos)).BeginInit();
            this.gb_CompraCortes.SuspendLayout();
            this.gpb_CompraPrecioPorKilo.SuspendLayout();
            this.gpb_CompraKilos.SuspendLayout();
            this.gpb_CompraMetodosDePago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ComprarVisaDebito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CompraDebitoMastercard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CompraCreditoMastercard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CompraPagoVisa)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_BolsaCompras
            // 
            this.pb_BolsaCompras.Image = global::Form_Login.Properties.Resources.img_bolsaCompras1;
            this.pb_BolsaCompras.Location = new System.Drawing.Point(414, -30);
            this.pb_BolsaCompras.Name = "pb_BolsaCompras";
            this.pb_BolsaCompras.Size = new System.Drawing.Size(480, 453);
            this.pb_BolsaCompras.TabIndex = 0;
            this.pb_BolsaCompras.TabStop = false;
            // 
            // btn_CompraPagar
            // 
            this.btn_CompraPagar.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_CompraPagar.Location = new System.Drawing.Point(686, 490);
            this.btn_CompraPagar.Name = "btn_CompraPagar";
            this.btn_CompraPagar.Size = new System.Drawing.Size(102, 40);
            this.btn_CompraPagar.TabIndex = 1;
            this.btn_CompraPagar.Text = "Pasar a pagar!";
            this.btn_CompraPagar.UseVisualStyleBackColor = false;
            // 
            // btn_ComprarCancelar
            // 
            this.btn_ComprarCancelar.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_ComprarCancelar.Location = new System.Drawing.Point(12, 490);
            this.btn_ComprarCancelar.Name = "btn_ComprarCancelar";
            this.btn_ComprarCancelar.Size = new System.Drawing.Size(102, 40);
            this.btn_ComprarCancelar.TabIndex = 2;
            this.btn_ComprarCancelar.Text = "Cancelar";
            this.btn_ComprarCancelar.UseVisualStyleBackColor = false;
            this.btn_ComprarCancelar.Click += new System.EventHandler(this.btn_ComprarCancelar_Click);
            // 
            // nud_CompraKilos
            // 
            this.nud_CompraKilos.DecimalPlaces = 1;
            this.nud_CompraKilos.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nud_CompraKilos.Location = new System.Drawing.Point(15, 22);
            this.nud_CompraKilos.Name = "nud_CompraKilos";
            this.nud_CompraKilos.ReadOnly = true;
            this.nud_CompraKilos.Size = new System.Drawing.Size(52, 23);
            this.nud_CompraKilos.TabIndex = 3;
            this.nud_CompraKilos.ValueChanged += new System.EventHandler(this.nud_CompraKilos_ValueChanged);
            // 
            // rtb_CompraMonto
            // 
            this.rtb_CompraMonto.BackColor = System.Drawing.Color.White;
            this.rtb_CompraMonto.Location = new System.Drawing.Point(350, 0);
            this.rtb_CompraMonto.Name = "rtb_CompraMonto";
            this.rtb_CompraMonto.ReadOnly = true;
            this.rtb_CompraMonto.Size = new System.Drawing.Size(100, 27);
            this.rtb_CompraMonto.TabIndex = 4;
            this.rtb_CompraMonto.Text = "";
            // 
            // lb_CompraMonto
            // 
            this.lb_CompraMonto.AutoSize = true;
            this.lb_CompraMonto.BackColor = System.Drawing.Color.White;
            this.lb_CompraMonto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_CompraMonto.Location = new System.Drawing.Point(375, 3);
            this.lb_CompraMonto.Name = "lb_CompraMonto";
            this.lb_CompraMonto.Size = new System.Drawing.Size(52, 21);
            this.lb_CompraMonto.TabIndex = 5;
            this.lb_CompraMonto.Text = "label1";
            // 
            // lb_CompraPeso
            // 
            this.lb_CompraPeso.AutoSize = true;
            this.lb_CompraPeso.BackColor = System.Drawing.Color.Transparent;
            this.lb_CompraPeso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_CompraPeso.Location = new System.Drawing.Point(325, 3);
            this.lb_CompraPeso.Name = "lb_CompraPeso";
            this.lb_CompraPeso.Size = new System.Drawing.Size(19, 21);
            this.lb_CompraPeso.TabIndex = 6;
            this.lb_CompraPeso.Text = "$";
            // 
            // gb_CompraCortes
            // 
            this.gb_CompraCortes.BackColor = System.Drawing.Color.Transparent;
            this.gb_CompraCortes.Controls.Add(this.groupBox1);
            this.gb_CompraCortes.Controls.Add(this.cmb_CompraCortes);
            this.gb_CompraCortes.Location = new System.Drawing.Point(12, 61);
            this.gb_CompraCortes.Name = "gb_CompraCortes";
            this.gb_CompraCortes.Size = new System.Drawing.Size(269, 63);
            this.gb_CompraCortes.TabIndex = 7;
            this.gb_CompraCortes.TabStop = false;
            this.gb_CompraCortes.Text = "Cortes";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(154, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(107, 63);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cmb_CompraCortes
            // 
            this.cmb_CompraCortes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CompraCortes.FormattingEnabled = true;
            this.cmb_CompraCortes.Location = new System.Drawing.Point(15, 22);
            this.cmb_CompraCortes.Name = "cmb_CompraCortes";
            this.cmb_CompraCortes.Size = new System.Drawing.Size(232, 23);
            this.cmb_CompraCortes.TabIndex = 0;
            this.cmb_CompraCortes.SelectedIndexChanged += new System.EventHandler(this.cmb_CompraCortes_SelectedIndexChanged);
            this.cmb_CompraCortes.SelectedValueChanged += new System.EventHandler(this.cmb_CompraCortes_SelectedValueChanged);
            // 
            // rtb_CompraPrecioPorKilo
            // 
            this.rtb_CompraPrecioPorKilo.BackColor = System.Drawing.Color.White;
            this.rtb_CompraPrecioPorKilo.Location = new System.Drawing.Point(15, 22);
            this.rtb_CompraPrecioPorKilo.Name = "rtb_CompraPrecioPorKilo";
            this.rtb_CompraPrecioPorKilo.ReadOnly = true;
            this.rtb_CompraPrecioPorKilo.Size = new System.Drawing.Size(97, 24);
            this.rtb_CompraPrecioPorKilo.TabIndex = 8;
            this.rtb_CompraPrecioPorKilo.Text = "";
            // 
            // gpb_CompraPrecioPorKilo
            // 
            this.gpb_CompraPrecioPorKilo.BackColor = System.Drawing.Color.Transparent;
            this.gpb_CompraPrecioPorKilo.Controls.Add(this.lb_CompraPrecioPorKilo);
            this.gpb_CompraPrecioPorKilo.Controls.Add(this.rtb_CompraPrecioPorKilo);
            this.gpb_CompraPrecioPorKilo.Location = new System.Drawing.Point(12, 139);
            this.gpb_CompraPrecioPorKilo.Name = "gpb_CompraPrecioPorKilo";
            this.gpb_CompraPrecioPorKilo.Size = new System.Drawing.Size(136, 63);
            this.gpb_CompraPrecioPorKilo.TabIndex = 11;
            this.gpb_CompraPrecioPorKilo.TabStop = false;
            this.gpb_CompraPrecioPorKilo.Text = "Precio por kilo";
            // 
            // lb_CompraPrecioPorKilo
            // 
            this.lb_CompraPrecioPorKilo.AutoSize = true;
            this.lb_CompraPrecioPorKilo.BackColor = System.Drawing.Color.White;
            this.lb_CompraPrecioPorKilo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_CompraPrecioPorKilo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_CompraPrecioPorKilo.Location = new System.Drawing.Point(43, 25);
            this.lb_CompraPrecioPorKilo.Name = "lb_CompraPrecioPorKilo";
            this.lb_CompraPrecioPorKilo.Size = new System.Drawing.Size(45, 19);
            this.lb_CompraPrecioPorKilo.TabIndex = 12;
            this.lb_CompraPrecioPorKilo.Text = "label1";
            // 
            // gpb_CompraKilos
            // 
            this.gpb_CompraKilos.BackColor = System.Drawing.Color.Transparent;
            this.gpb_CompraKilos.Controls.Add(this.nud_CompraKilos);
            this.gpb_CompraKilos.Location = new System.Drawing.Point(12, 228);
            this.gpb_CompraKilos.Name = "gpb_CompraKilos";
            this.gpb_CompraKilos.Size = new System.Drawing.Size(102, 63);
            this.gpb_CompraKilos.TabIndex = 12;
            this.gpb_CompraKilos.TabStop = false;
            this.gpb_CompraKilos.Text = "Kilo/s";
            // 
            // gpb_CompraMetodosDePago
            // 
            this.gpb_CompraMetodosDePago.BackColor = System.Drawing.Color.Transparent;
            this.gpb_CompraMetodosDePago.Controls.Add(this.pb_ComprarVisaDebito);
            this.gpb_CompraMetodosDePago.Controls.Add(this.pb_CompraDebitoMastercard);
            this.gpb_CompraMetodosDePago.Controls.Add(this.pb_CompraCreditoMastercard);
            this.gpb_CompraMetodosDePago.Controls.Add(this.pb_CompraPagoVisa);
            this.gpb_CompraMetodosDePago.Controls.Add(this.btn_CompraCredito);
            this.gpb_CompraMetodosDePago.Controls.Add(this.btn_CompraDebito);
            this.gpb_CompraMetodosDePago.Controls.Add(this.btn_CompraEfectivo);
            this.gpb_CompraMetodosDePago.Location = new System.Drawing.Point(12, 312);
            this.gpb_CompraMetodosDePago.Name = "gpb_CompraMetodosDePago";
            this.gpb_CompraMetodosDePago.Size = new System.Drawing.Size(360, 100);
            this.gpb_CompraMetodosDePago.TabIndex = 13;
            this.gpb_CompraMetodosDePago.TabStop = false;
            this.gpb_CompraMetodosDePago.Text = "Metodos de pago";
            // 
            // pb_ComprarVisaDebito
            // 
            this.pb_ComprarVisaDebito.Image = global::Form_Login.Properties.Resources.img_visa;
            this.pb_ComprarVisaDebito.Location = new System.Drawing.Point(207, 56);
            this.pb_ComprarVisaDebito.Name = "pb_ComprarVisaDebito";
            this.pb_ComprarVisaDebito.Size = new System.Drawing.Size(20, 12);
            this.pb_ComprarVisaDebito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_ComprarVisaDebito.TabIndex = 22;
            this.pb_ComprarVisaDebito.TabStop = false;
            // 
            // pb_CompraDebitoMastercard
            // 
            this.pb_CompraDebitoMastercard.Image = global::Form_Login.Properties.Resources.mastercard_4;
            this.pb_CompraDebitoMastercard.Location = new System.Drawing.Point(207, 37);
            this.pb_CompraDebitoMastercard.Name = "pb_CompraDebitoMastercard";
            this.pb_CompraDebitoMastercard.Size = new System.Drawing.Size(13, 13);
            this.pb_CompraDebitoMastercard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_CompraDebitoMastercard.TabIndex = 22;
            this.pb_CompraDebitoMastercard.TabStop = false;
            // 
            // pb_CompraCreditoMastercard
            // 
            this.pb_CompraCreditoMastercard.Image = global::Form_Login.Properties.Resources.mastercard_4;
            this.pb_CompraCreditoMastercard.Location = new System.Drawing.Point(323, 37);
            this.pb_CompraCreditoMastercard.Name = "pb_CompraCreditoMastercard";
            this.pb_CompraCreditoMastercard.Size = new System.Drawing.Size(13, 13);
            this.pb_CompraCreditoMastercard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_CompraCreditoMastercard.TabIndex = 17;
            this.pb_CompraCreditoMastercard.TabStop = false;
            // 
            // pb_CompraPagoVisa
            // 
            this.pb_CompraPagoVisa.Image = global::Form_Login.Properties.Resources.img_visa;
            this.pb_CompraPagoVisa.Location = new System.Drawing.Point(323, 56);
            this.pb_CompraPagoVisa.Name = "pb_CompraPagoVisa";
            this.pb_CompraPagoVisa.Size = new System.Drawing.Size(20, 12);
            this.pb_CompraPagoVisa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_CompraPagoVisa.TabIndex = 16;
            this.pb_CompraPagoVisa.TabStop = false;
            // 
            // btn_CompraCredito
            // 
            this.btn_CompraCredito.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_CompraCredito.Location = new System.Drawing.Point(242, 35);
            this.btn_CompraCredito.Name = "btn_CompraCredito";
            this.btn_CompraCredito.Size = new System.Drawing.Size(75, 39);
            this.btn_CompraCredito.TabIndex = 2;
            this.btn_CompraCredito.Text = "Credito";
            this.btn_CompraCredito.UseVisualStyleBackColor = false;
            this.btn_CompraCredito.Click += new System.EventHandler(this.btn_CompraCredito_Click);
            // 
            // btn_CompraDebito
            // 
            this.btn_CompraDebito.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_CompraDebito.Location = new System.Drawing.Point(126, 35);
            this.btn_CompraDebito.Name = "btn_CompraDebito";
            this.btn_CompraDebito.Size = new System.Drawing.Size(75, 39);
            this.btn_CompraDebito.TabIndex = 1;
            this.btn_CompraDebito.Text = "Debito";
            this.btn_CompraDebito.UseVisualStyleBackColor = false;
            this.btn_CompraDebito.Click += new System.EventHandler(this.btn_CompraDebito_Click);
            // 
            // btn_CompraEfectivo
            // 
            this.btn_CompraEfectivo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_CompraEfectivo.Location = new System.Drawing.Point(13, 35);
            this.btn_CompraEfectivo.Name = "btn_CompraEfectivo";
            this.btn_CompraEfectivo.Size = new System.Drawing.Size(75, 39);
            this.btn_CompraEfectivo.TabIndex = 0;
            this.btn_CompraEfectivo.Text = "Efectivo";
            this.btn_CompraEfectivo.UseVisualStyleBackColor = false;
            // 
            // lb_CompraColitaDeCuadril
            // 
            this.lb_CompraColitaDeCuadril.AutoSize = true;
            this.lb_CompraColitaDeCuadril.BackColor = System.Drawing.Color.Transparent;
            this.lb_CompraColitaDeCuadril.Location = new System.Drawing.Point(541, 149);
            this.lb_CompraColitaDeCuadril.Name = "lb_CompraColitaDeCuadril";
            this.lb_CompraColitaDeCuadril.Size = new System.Drawing.Size(38, 15);
            this.lb_CompraColitaDeCuadril.TabIndex = 14;
            this.lb_CompraColitaDeCuadril.Text = "label1";
            // 
            // lb_CompraEntrania
            // 
            this.lb_CompraEntrania.AutoSize = true;
            this.lb_CompraEntrania.BackColor = System.Drawing.Color.Transparent;
            this.lb_CompraEntrania.Location = new System.Drawing.Point(541, 206);
            this.lb_CompraEntrania.Name = "lb_CompraEntrania";
            this.lb_CompraEntrania.Size = new System.Drawing.Size(38, 15);
            this.lb_CompraEntrania.TabIndex = 15;
            this.lb_CompraEntrania.Text = "label2";
            // 
            // lb_CompraTiraAsado
            // 
            this.lb_CompraTiraAsado.AutoSize = true;
            this.lb_CompraTiraAsado.BackColor = System.Drawing.Color.Transparent;
            this.lb_CompraTiraAsado.Location = new System.Drawing.Point(541, 258);
            this.lb_CompraTiraAsado.Name = "lb_CompraTiraAsado";
            this.lb_CompraTiraAsado.Size = new System.Drawing.Size(38, 15);
            this.lb_CompraTiraAsado.TabIndex = 16;
            this.lb_CompraTiraAsado.Text = "label3";
            // 
            // lb_CompraBolaLomo
            // 
            this.lb_CompraBolaLomo.AutoSize = true;
            this.lb_CompraBolaLomo.BackColor = System.Drawing.Color.Transparent;
            this.lb_CompraBolaLomo.Location = new System.Drawing.Point(541, 321);
            this.lb_CompraBolaLomo.Name = "lb_CompraBolaLomo";
            this.lb_CompraBolaLomo.Size = new System.Drawing.Size(38, 15);
            this.lb_CompraBolaLomo.TabIndex = 17;
            this.lb_CompraBolaLomo.Text = "label4";
            // 
            // lb_CompraOjoBife
            // 
            this.lb_CompraOjoBife.AutoSize = true;
            this.lb_CompraOjoBife.BackColor = System.Drawing.Color.Transparent;
            this.lb_CompraOjoBife.Location = new System.Drawing.Point(664, 206);
            this.lb_CompraOjoBife.Name = "lb_CompraOjoBife";
            this.lb_CompraOjoBife.Size = new System.Drawing.Size(38, 15);
            this.lb_CompraOjoBife.TabIndex = 18;
            this.lb_CompraOjoBife.Text = "label5";
            // 
            // lb_CompraBifeChorizo
            // 
            this.lb_CompraBifeChorizo.AutoSize = true;
            this.lb_CompraBifeChorizo.BackColor = System.Drawing.Color.Transparent;
            this.lb_CompraBifeChorizo.Location = new System.Drawing.Point(664, 149);
            this.lb_CompraBifeChorizo.Name = "lb_CompraBifeChorizo";
            this.lb_CompraBifeChorizo.Size = new System.Drawing.Size(38, 15);
            this.lb_CompraBifeChorizo.TabIndex = 19;
            this.lb_CompraBifeChorizo.Text = "label6";
            // 
            // lb_CompraTortuguita
            // 
            this.lb_CompraTortuguita.AutoSize = true;
            this.lb_CompraTortuguita.BackColor = System.Drawing.Color.Transparent;
            this.lb_CompraTortuguita.Location = new System.Drawing.Point(664, 258);
            this.lb_CompraTortuguita.Name = "lb_CompraTortuguita";
            this.lb_CompraTortuguita.Size = new System.Drawing.Size(38, 15);
            this.lb_CompraTortuguita.TabIndex = 20;
            this.lb_CompraTortuguita.Text = "label7";
            // 
            // lb_CompraFalda
            // 
            this.lb_CompraFalda.AutoSize = true;
            this.lb_CompraFalda.BackColor = System.Drawing.Color.Transparent;
            this.lb_CompraFalda.Location = new System.Drawing.Point(664, 321);
            this.lb_CompraFalda.Name = "lb_CompraFalda";
            this.lb_CompraFalda.Size = new System.Drawing.Size(38, 15);
            this.lb_CompraFalda.TabIndex = 21;
            this.lb_CompraFalda.Text = "label8";
            // 
            // rtb_ComprarCostoTotal
            // 
            this.rtb_ComprarCostoTotal.BackColor = System.Drawing.Color.White;
            this.rtb_ComprarCostoTotal.Location = new System.Drawing.Point(350, 451);
            this.rtb_ComprarCostoTotal.Name = "rtb_ComprarCostoTotal";
            this.rtb_ComprarCostoTotal.ReadOnly = true;
            this.rtb_ComprarCostoTotal.Size = new System.Drawing.Size(100, 27);
            this.rtb_ComprarCostoTotal.TabIndex = 22;
            this.rtb_ComprarCostoTotal.Text = "";
            // 
            // lb_ComprarCostoTotal
            // 
            this.lb_ComprarCostoTotal.AutoSize = true;
            this.lb_ComprarCostoTotal.BackColor = System.Drawing.Color.White;
            this.lb_ComprarCostoTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_ComprarCostoTotal.Location = new System.Drawing.Point(375, 454);
            this.lb_ComprarCostoTotal.Name = "lb_ComprarCostoTotal";
            this.lb_ComprarCostoTotal.Size = new System.Drawing.Size(52, 21);
            this.lb_ComprarCostoTotal.TabIndex = 23;
            this.lb_ComprarCostoTotal.Text = "label1";
            // 
            // lb_CompraMontoInicial
            // 
            this.lb_CompraMontoInicial.AutoSize = true;
            this.lb_CompraMontoInicial.BackColor = System.Drawing.Color.Transparent;
            this.lb_CompraMontoInicial.Location = new System.Drawing.Point(372, 30);
            this.lb_CompraMontoInicial.Name = "lb_CompraMontoInicial";
            this.lb_CompraMontoInicial.Size = new System.Drawing.Size(59, 15);
            this.lb_CompraMontoInicial.TabIndex = 24;
            this.lb_CompraMontoInicial.Text = "Tu monto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(325, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(368, 481);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Costo total";
            // 
            // FormComprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 542);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_CompraMontoInicial);
            this.Controls.Add(this.lb_ComprarCostoTotal);
            this.Controls.Add(this.rtb_ComprarCostoTotal);
            this.Controls.Add(this.lb_CompraFalda);
            this.Controls.Add(this.lb_CompraTortuguita);
            this.Controls.Add(this.lb_CompraBifeChorizo);
            this.Controls.Add(this.lb_CompraOjoBife);
            this.Controls.Add(this.lb_CompraBolaLomo);
            this.Controls.Add(this.lb_CompraTiraAsado);
            this.Controls.Add(this.lb_CompraEntrania);
            this.Controls.Add(this.lb_CompraColitaDeCuadril);
            this.Controls.Add(this.gpb_CompraMetodosDePago);
            this.Controls.Add(this.gpb_CompraKilos);
            this.Controls.Add(this.gpb_CompraPrecioPorKilo);
            this.Controls.Add(this.gb_CompraCortes);
            this.Controls.Add(this.lb_CompraPeso);
            this.Controls.Add(this.lb_CompraMonto);
            this.Controls.Add(this.rtb_CompraMonto);
            this.Controls.Add(this.btn_ComprarCancelar);
            this.Controls.Add(this.btn_CompraPagar);
            this.Controls.Add(this.pb_BolsaCompras);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormComprar";
            this.Text = "A comprar!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormComprar_FormClosing);
            this.Load += new System.EventHandler(this.FormComprar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_BolsaCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CompraKilos)).EndInit();
            this.gb_CompraCortes.ResumeLayout(false);
            this.gpb_CompraPrecioPorKilo.ResumeLayout(false);
            this.gpb_CompraPrecioPorKilo.PerformLayout();
            this.gpb_CompraKilos.ResumeLayout(false);
            this.gpb_CompraMetodosDePago.ResumeLayout(false);
            this.gpb_CompraMetodosDePago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ComprarVisaDebito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CompraDebitoMastercard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CompraCreditoMastercard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CompraPagoVisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pb_BolsaCompras;
        private Button btn_CompraPagar;
        private Button btn_ComprarCancelar;
        private NumericUpDown nud_CompraKilos;
        private RichTextBox rtb_CompraMonto;
        private Label lb_CompraMonto;
        private Label lb_CompraPeso;
        private GroupBox gb_CompraCortes;
        private ComboBox cmb_CompraCortes;
        private RichTextBox rtb_CompraPrecioPorKilo;
        private GroupBox gpb_CompraPrecioPorKilo;
        private Label lb_CompraPrecioPorKilo;
        private GroupBox groupBox1;
        private GroupBox gpb_CompraKilos;
        private GroupBox gpb_CompraMetodosDePago;
        private Button btn_CompraCredito;
        private Button btn_CompraDebito;
        private Button btn_CompraEfectivo;
        private PictureBox pb_CompraPagoVisa;
        private Label lb_CompraColitaDeCuadril;
        private Label lb_CompraEntrania;
        private Label lb_CompraTiraAsado;
        private Label lb_CompraBolaLomo;
        private Label lb_CompraOjoBife;
        private Label lb_CompraBifeChorizo;
        private Label lb_CompraTortuguita;
        private Label lb_CompraFalda;
        private PictureBox pb_CompraCreditoMastercard;
        private PictureBox pb_CompraDebitoMastercard;
        private PictureBox pb_ComprarVisaDebito;
        private RichTextBox rtb_ComprarCostoTotal;
        private Label lb_ComprarCostoTotal;
        private Label lb_CompraMontoInicial;
        private Label label1;
        private Label label2;
    }
}