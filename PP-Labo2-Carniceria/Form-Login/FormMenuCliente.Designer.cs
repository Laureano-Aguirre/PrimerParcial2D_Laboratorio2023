namespace Form_Login
{
    partial class Form_MenuCliente
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MenuCliente));
            this.lb_MenPrincMonto = new System.Windows.Forms.Label();
            this.txb_MenPrinMonto = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodosDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.montoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cortesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_MenPrinComenzarAComprar = new System.Windows.Forms.Button();
            this.lb_MenPrincMoneda = new System.Windows.Forms.Label();
            this.lb_MenuPrinHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_MenPrinBienvenido = new System.Windows.Forms.Label();
            this.btn_MenPrinSalir = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_MenPrincMonto
            // 
            this.lb_MenPrincMonto.AutoSize = true;
            this.lb_MenPrincMonto.BackColor = System.Drawing.SystemColors.Info;
            this.lb_MenPrincMonto.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_MenPrincMonto.Location = new System.Drawing.Point(16, 80);
            this.lb_MenPrincMonto.Name = "lb_MenPrincMonto";
            this.lb_MenPrincMonto.Size = new System.Drawing.Size(383, 37);
            this.lb_MenPrincMonto.TabIndex = 0;
            this.lb_MenPrincMonto.Text = "Ingrese el monto para comprar";
            // 
            // txb_MenPrinMonto
            // 
            this.txb_MenPrinMonto.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_MenPrinMonto.Location = new System.Drawing.Point(54, 130);
            this.txb_MenPrinMonto.Name = "txb_MenPrinMonto";
            this.txb_MenPrinMonto.PlaceholderText = "Ingrese aqui";
            this.txb_MenPrinMonto.Size = new System.Drawing.Size(292, 43);
            this.txb_MenPrinMonto.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(688, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metodosDePagoToolStripMenuItem,
            this.montoToolStripMenuItem,
            this.cortesToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // metodosDePagoToolStripMenuItem
            // 
            this.metodosDePagoToolStripMenuItem.Name = "metodosDePagoToolStripMenuItem";
            this.metodosDePagoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.metodosDePagoToolStripMenuItem.Text = "Metodos de pago";
            this.metodosDePagoToolStripMenuItem.Click += new System.EventHandler(this.metodosDePagoToolStripMenuItem_Click);
            // 
            // montoToolStripMenuItem
            // 
            this.montoToolStripMenuItem.Name = "montoToolStripMenuItem";
            this.montoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.montoToolStripMenuItem.Text = "Monto";
            this.montoToolStripMenuItem.Click += new System.EventHandler(this.montoToolStripMenuItem_Click);
            // 
            // cortesToolStripMenuItem
            // 
            this.cortesToolStripMenuItem.Name = "cortesToolStripMenuItem";
            this.cortesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.cortesToolStripMenuItem.Text = "Cortes";
            this.cortesToolStripMenuItem.Click += new System.EventHandler(this.cortesToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactoToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // contactoToolStripMenuItem
            // 
            this.contactoToolStripMenuItem.Name = "contactoToolStripMenuItem";
            this.contactoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contactoToolStripMenuItem.Text = "Contacto";
            this.contactoToolStripMenuItem.Click += new System.EventHandler(this.contactoToolStripMenuItem_Click);
            // 
            // btn_MenPrinComenzarAComprar
            // 
            this.btn_MenPrinComenzarAComprar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_MenPrinComenzarAComprar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_MenPrinComenzarAComprar.Location = new System.Drawing.Point(533, 258);
            this.btn_MenPrinComenzarAComprar.Name = "btn_MenPrinComenzarAComprar";
            this.btn_MenPrinComenzarAComprar.Size = new System.Drawing.Size(141, 48);
            this.btn_MenPrinComenzarAComprar.TabIndex = 3;
            this.btn_MenPrinComenzarAComprar.Text = "Comencemos a comprar!";
            this.btn_MenPrinComenzarAComprar.UseVisualStyleBackColor = false;
            this.btn_MenPrinComenzarAComprar.Click += new System.EventHandler(this.btn_MenPrinComenzarAComprar_Click);
            // 
            // lb_MenPrincMoneda
            // 
            this.lb_MenPrincMoneda.AutoSize = true;
            this.lb_MenPrincMoneda.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_MenPrincMoneda.Location = new System.Drawing.Point(16, 133);
            this.lb_MenPrincMoneda.Name = "lb_MenPrincMoneda";
            this.lb_MenPrincMoneda.Size = new System.Drawing.Size(32, 37);
            this.lb_MenPrincMoneda.TabIndex = 4;
            this.lb_MenPrincMoneda.Text = "$";
            // 
            // lb_MenuPrinHora
            // 
            this.lb_MenuPrinHora.AutoSize = true;
            this.lb_MenuPrinHora.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_MenuPrinHora.Location = new System.Drawing.Point(493, 120);
            this.lb_MenuPrinHora.Name = "lb_MenuPrinHora";
            this.lb_MenuPrinHora.Size = new System.Drawing.Size(130, 54);
            this.lb_MenuPrinHora.TabIndex = 5;
            this.lb_MenuPrinHora.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_MenPrinBienvenido
            // 
            this.lb_MenPrinBienvenido.AutoSize = true;
            this.lb_MenPrinBienvenido.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_MenPrinBienvenido.Location = new System.Drawing.Point(16, 33);
            this.lb_MenPrinBienvenido.Name = "lb_MenPrinBienvenido";
            this.lb_MenPrinBienvenido.Size = new System.Drawing.Size(90, 37);
            this.lb_MenPrinBienvenido.TabIndex = 6;
            this.lb_MenPrinBienvenido.Text = "label1";
            // 
            // btn_MenPrinSalir
            // 
            this.btn_MenPrinSalir.BackColor = System.Drawing.SystemColors.Control;
            this.btn_MenPrinSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_MenPrinSalir.Location = new System.Drawing.Point(16, 258);
            this.btn_MenPrinSalir.Name = "btn_MenPrinSalir";
            this.btn_MenPrinSalir.Size = new System.Drawing.Size(141, 48);
            this.btn_MenPrinSalir.TabIndex = 7;
            this.btn_MenPrinSalir.Text = "Salir";
            this.btn_MenPrinSalir.UseVisualStyleBackColor = false;
            this.btn_MenPrinSalir.Click += new System.EventHandler(this.btn_MenPrinSalir_Click);
            // 
            // Form_MenuCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 318);
            this.Controls.Add(this.btn_MenPrinSalir);
            this.Controls.Add(this.lb_MenPrinBienvenido);
            this.Controls.Add(this.lb_MenuPrinHora);
            this.Controls.Add(this.lb_MenPrincMoneda);
            this.Controls.Add(this.btn_MenPrinComenzarAComprar);
            this.Controls.Add(this.txb_MenPrinMonto);
            this.Controls.Add(this.lb_MenPrincMonto);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_MenuCliente";
            this.Text = "Menu principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_MenuCliente_FormClosing);
            this.Load += new System.EventHandler(this.Form_MenuCliente_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_MenPrincMonto;
        private TextBox txb_MenPrinMonto;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem verToolStripMenuItem;
        private ToolStripMenuItem metodosDePagoToolStripMenuItem;
        private ToolStripMenuItem montoToolStripMenuItem;
        private ToolStripMenuItem cortesToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem contactoToolStripMenuItem;
        private Button btn_MenPrinComenzarAComprar;
        private Label lb_MenPrincMoneda;
        private Label lb_MenuPrinHora;
        private System.Windows.Forms.Timer timer1;
        private Label lb_MenPrinBienvenido;
        private Button btn_MenPrinSalir;
    }
}