namespace Form_Login
{
    partial class FormHeladera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHeladera));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeCorteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cortesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detallesDeCortesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_HeladeraVender = new System.Windows.Forms.Button();
            this.btn_HeladeraSalir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.verToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoDeCorteToolStripMenuItem,
            this.stockToolStripMenuItem});
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // tipoDeCorteToolStripMenuItem
            // 
            this.tipoDeCorteToolStripMenuItem.Name = "tipoDeCorteToolStripMenuItem";
            this.tipoDeCorteToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.tipoDeCorteToolStripMenuItem.Text = "Tipo de corte";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cortesToolStripMenuItem,
            this.detallesDeCortesToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // cortesToolStripMenuItem
            // 
            this.cortesToolStripMenuItem.Name = "cortesToolStripMenuItem";
            this.cortesToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.cortesToolStripMenuItem.Text = "Cortes";
            // 
            // detallesDeCortesToolStripMenuItem
            // 
            this.detallesDeCortesToolStripMenuItem.Name = "detallesDeCortesToolStripMenuItem";
            this.detallesDeCortesToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.detallesDeCortesToolStripMenuItem.Text = "Detalles de cortes";
            // 
            // btn_HeladeraVender
            // 
            this.btn_HeladeraVender.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_HeladeraVender.Location = new System.Drawing.Point(558, 391);
            this.btn_HeladeraVender.Name = "btn_HeladeraVender";
            this.btn_HeladeraVender.Size = new System.Drawing.Size(114, 47);
            this.btn_HeladeraVender.TabIndex = 1;
            this.btn_HeladeraVender.Text = "Vender";
            this.btn_HeladeraVender.UseVisualStyleBackColor = false;
            // 
            // btn_HeladeraSalir
            // 
            this.btn_HeladeraSalir.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_HeladeraSalir.Location = new System.Drawing.Point(12, 391);
            this.btn_HeladeraSalir.Name = "btn_HeladeraSalir";
            this.btn_HeladeraSalir.Size = new System.Drawing.Size(114, 47);
            this.btn_HeladeraSalir.TabIndex = 2;
            this.btn_HeladeraSalir.Text = "Salir";
            this.btn_HeladeraSalir.UseVisualStyleBackColor = false;
            this.btn_HeladeraSalir.Click += new System.EventHandler(this.btn_HeladeraSalir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(95, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(360, 270);
            this.dataGridView1.TabIndex = 3;
            // 
            // FormHeladera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_HeladeraSalir);
            this.Controls.Add(this.btn_HeladeraVender);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormHeladera";
            this.Text = "Heladera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHeladera_FormClosing);
            this.Load += new System.EventHandler(this.FormHeladera_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem tipoDeCorteToolStripMenuItem;
        private ToolStripMenuItem stockToolStripMenuItem;
        private ToolStripMenuItem verToolStripMenuItem;
        private ToolStripMenuItem cortesToolStripMenuItem;
        private ToolStripMenuItem detallesDeCortesToolStripMenuItem;
        private Button btn_HeladeraVender;
        private Button btn_HeladeraSalir;
        private DataGridView dataGridView1;
    }
}