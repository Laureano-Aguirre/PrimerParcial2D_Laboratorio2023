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
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.precioPorKiloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_HeladeraVender = new System.Windows.Forms.Button();
            this.btn_HeladeraSalir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_HeladeraBiennvenida = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.modificarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockToolStripMenuItem});
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.stockToolStripMenuItem.Text = "Producto";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click_1);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.precioPorKiloToolStripMenuItem});
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // precioPorKiloToolStripMenuItem
            // 
            this.precioPorKiloToolStripMenuItem.Name = "precioPorKiloToolStripMenuItem";
            this.precioPorKiloToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.precioPorKiloToolStripMenuItem.Text = "Producto";
            this.precioPorKiloToolStripMenuItem.Click += new System.EventHandler(this.precioPorKiloToolStripMenuItem_Click);
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
            this.btn_HeladeraVender.Click += new System.EventHandler(this.btn_HeladeraVender_Click);
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
            this.btn_HeladeraSalir.Click += new System.EventHandler(this.btn_HeladeraSalir_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(95, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(360, 270);
            this.dataGridView1.TabIndex = 3;
            // 
            // lb_HeladeraBiennvenida
            // 
            this.lb_HeladeraBiennvenida.AutoSize = true;
            this.lb_HeladeraBiennvenida.BackColor = System.Drawing.Color.Transparent;
            this.lb_HeladeraBiennvenida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_HeladeraBiennvenida.Location = new System.Drawing.Point(25, 43);
            this.lb_HeladeraBiennvenida.Name = "lb_HeladeraBiennvenida";
            this.lb_HeladeraBiennvenida.Size = new System.Drawing.Size(52, 21);
            this.lb_HeladeraBiennvenida.TabIndex = 4;
            this.lb_HeladeraBiennvenida.Text = "label1";
            // 
            // FormHeladera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.lb_HeladeraBiennvenida);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_HeladeraSalir);
            this.Controls.Add(this.btn_HeladeraVender);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormHeladera";
            this.Text = "Heladera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHeladera_FormClosing_1);
            this.Load += new System.EventHandler(this.FormHeladera_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem stockToolStripMenuItem;
        private Button btn_HeladeraVender;
        private Button btn_HeladeraSalir;
        private DataGridView dataGridView1;
        private ToolStripMenuItem modificarToolStripMenuItem;
        private ToolStripMenuItem precioPorKiloToolStripMenuItem;
        private Label lb_HeladeraBiennvenida;
    }
}