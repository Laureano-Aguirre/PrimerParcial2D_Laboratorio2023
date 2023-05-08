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
            menuStrip1 = new MenuStrip();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            stockToolStripMenuItem = new ToolStripMenuItem();
            verToolStripMenuItem = new ToolStripMenuItem();
            cortesToolStripMenuItem = new ToolStripMenuItem();
            detallesDeCortesToolStripMenuItem = new ToolStripMenuItem();
            btn_HeladeraVender = new Button();
            btn_HeladeraSalir = new Button();
            dataGridView1 = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { agregarToolStripMenuItem, verToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(684, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stockToolStripMenuItem });
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(61, 20);
            agregarToolStripMenuItem.Text = "Agregar";
            // 
            // stockToolStripMenuItem
            // 
            stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            stockToolStripMenuItem.Size = new Size(123, 22);
            stockToolStripMenuItem.Text = "Producto";
            stockToolStripMenuItem.Click += stockToolStripMenuItem_Click;
            // 
            // verToolStripMenuItem
            // 
            verToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cortesToolStripMenuItem, detallesDeCortesToolStripMenuItem });
            verToolStripMenuItem.Name = "verToolStripMenuItem";
            verToolStripMenuItem.Size = new Size(35, 20);
            verToolStripMenuItem.Text = "Ver";
            // 
            // cortesToolStripMenuItem
            // 
            cortesToolStripMenuItem.Name = "cortesToolStripMenuItem";
            cortesToolStripMenuItem.Size = new Size(166, 22);
            cortesToolStripMenuItem.Text = "Cortes";
            // 
            // detallesDeCortesToolStripMenuItem
            // 
            detallesDeCortesToolStripMenuItem.Name = "detallesDeCortesToolStripMenuItem";
            detallesDeCortesToolStripMenuItem.Size = new Size(166, 22);
            detallesDeCortesToolStripMenuItem.Text = "Detalles de cortes";
            // 
            // btn_HeladeraVender
            // 
            btn_HeladeraVender.BackColor = Color.YellowGreen;
            btn_HeladeraVender.Location = new Point(558, 391);
            btn_HeladeraVender.Name = "btn_HeladeraVender";
            btn_HeladeraVender.Size = new Size(114, 47);
            btn_HeladeraVender.TabIndex = 1;
            btn_HeladeraVender.Text = "Vender";
            btn_HeladeraVender.UseVisualStyleBackColor = false;
            btn_HeladeraVender.Click += btn_HeladeraVender_Click;
            // 
            // btn_HeladeraSalir
            // 
            btn_HeladeraSalir.BackColor = Color.RosyBrown;
            btn_HeladeraSalir.Location = new Point(12, 391);
            btn_HeladeraSalir.Name = "btn_HeladeraSalir";
            btn_HeladeraSalir.Size = new Size(114, 47);
            btn_HeladeraSalir.TabIndex = 2;
            btn_HeladeraSalir.Text = "Salir";
            btn_HeladeraSalir.UseVisualStyleBackColor = false;
            btn_HeladeraSalir.Click += btn_HeladeraSalir_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(95, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(360, 270);
            dataGridView1.TabIndex = 3;
            // 
            // FormHeladera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btn_HeladeraSalir);
            Controls.Add(btn_HeladeraVender);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "FormHeladera";
            Text = "Heladera";
            FormClosing += FormHeladera_FormClosing;
            Load += FormHeladera_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem stockToolStripMenuItem;
        private ToolStripMenuItem verToolStripMenuItem;
        private ToolStripMenuItem cortesToolStripMenuItem;
        private ToolStripMenuItem detallesDeCortesToolStripMenuItem;
        private Button btn_HeladeraVender;
        private Button btn_HeladeraSalir;
        private DataGridView dataGridView1;
    }
}