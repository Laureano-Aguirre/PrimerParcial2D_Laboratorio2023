﻿namespace Form_Login
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
            clienteToolStripMenuItem = new ToolStripMenuItem();
            modificarToolStripMenuItem = new ToolStripMenuItem();
            precioPorKiloToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem3 = new ToolStripMenuItem();
            correoToolStripMenuItem = new ToolStripMenuItem();
            passwordToolStripMenuItem = new ToolStripMenuItem();
            montoToolStripMenuItem = new ToolStripMenuItem();
            vendedorToolStripMenuItem1 = new ToolStripMenuItem();
            correoToolStripMenuItem1 = new ToolStripMenuItem();
            passwordToolStripMenuItem1 = new ToolStripMenuItem();
            verToolStripMenuItem = new ToolStripMenuItem();
            historialDeFacturacionToolStripMenuItem = new ToolStripMenuItem();
            historialDeVentasToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem1 = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem2 = new ToolStripMenuItem();
            vendedorToolStripMenuItem = new ToolStripMenuItem();
            btn_HeladeraVender = new Button();
            btn_HeladeraSalir = new Button();
            dataGridView1 = new DataGridView();
            lb_HeladeraBiennvenida = new Label();
            vendedorToolStripMenuItem2 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { agregarToolStripMenuItem, modificarToolStripMenuItem, verToolStripMenuItem, eliminarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(684, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stockToolStripMenuItem, clienteToolStripMenuItem, vendedorToolStripMenuItem2 });
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(61, 20);
            agregarToolStripMenuItem.Text = "Agregar";
            // 
            // stockToolStripMenuItem
            // 
            stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            stockToolStripMenuItem.Size = new Size(180, 22);
            stockToolStripMenuItem.Text = "Producto";
            stockToolStripMenuItem.Click += stockToolStripMenuItem_Click_1;
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(180, 22);
            clienteToolStripMenuItem.Text = "Cliente";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // modificarToolStripMenuItem
            // 
            modificarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { precioPorKiloToolStripMenuItem, clienteToolStripMenuItem3, vendedorToolStripMenuItem1 });
            modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            modificarToolStripMenuItem.Size = new Size(70, 20);
            modificarToolStripMenuItem.Text = "Modificar";
            // 
            // precioPorKiloToolStripMenuItem
            // 
            precioPorKiloToolStripMenuItem.Name = "precioPorKiloToolStripMenuItem";
            precioPorKiloToolStripMenuItem.Size = new Size(124, 22);
            precioPorKiloToolStripMenuItem.Text = "Producto";
            precioPorKiloToolStripMenuItem.Click += precioPorKiloToolStripMenuItem_Click;
            // 
            // clienteToolStripMenuItem3
            // 
            clienteToolStripMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { correoToolStripMenuItem, passwordToolStripMenuItem, montoToolStripMenuItem });
            clienteToolStripMenuItem3.Name = "clienteToolStripMenuItem3";
            clienteToolStripMenuItem3.Size = new Size(124, 22);
            clienteToolStripMenuItem3.Text = "Cliente";
            // 
            // correoToolStripMenuItem
            // 
            correoToolStripMenuItem.Name = "correoToolStripMenuItem";
            correoToolStripMenuItem.Size = new Size(124, 22);
            correoToolStripMenuItem.Text = "Correo";
            correoToolStripMenuItem.Click += correoToolStripMenuItem_Click;
            // 
            // passwordToolStripMenuItem
            // 
            passwordToolStripMenuItem.Name = "passwordToolStripMenuItem";
            passwordToolStripMenuItem.Size = new Size(124, 22);
            passwordToolStripMenuItem.Text = "Password";
            passwordToolStripMenuItem.Click += passwordToolStripMenuItem_Click;
            // 
            // montoToolStripMenuItem
            // 
            montoToolStripMenuItem.Name = "montoToolStripMenuItem";
            montoToolStripMenuItem.Size = new Size(124, 22);
            montoToolStripMenuItem.Text = "Monto";
            montoToolStripMenuItem.Click += montoToolStripMenuItem_Click;
            // 
            // vendedorToolStripMenuItem1
            // 
            vendedorToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { correoToolStripMenuItem1, passwordToolStripMenuItem1 });
            vendedorToolStripMenuItem1.Name = "vendedorToolStripMenuItem1";
            vendedorToolStripMenuItem1.Size = new Size(124, 22);
            vendedorToolStripMenuItem1.Text = "Vendedor";
            // 
            // correoToolStripMenuItem1
            // 
            correoToolStripMenuItem1.Name = "correoToolStripMenuItem1";
            correoToolStripMenuItem1.Size = new Size(124, 22);
            correoToolStripMenuItem1.Text = "Correo";
            correoToolStripMenuItem1.Click += correoToolStripMenuItem1_Click;
            // 
            // passwordToolStripMenuItem1
            // 
            passwordToolStripMenuItem1.Name = "passwordToolStripMenuItem1";
            passwordToolStripMenuItem1.Size = new Size(124, 22);
            passwordToolStripMenuItem1.Text = "Password";
            passwordToolStripMenuItem1.Click += passwordToolStripMenuItem1_Click;
            // 
            // verToolStripMenuItem
            // 
            verToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { historialDeFacturacionToolStripMenuItem, historialDeVentasToolStripMenuItem, clienteToolStripMenuItem1 });
            verToolStripMenuItem.Name = "verToolStripMenuItem";
            verToolStripMenuItem.Size = new Size(35, 20);
            verToolStripMenuItem.Text = "Ver";
            // 
            // historialDeFacturacionToolStripMenuItem
            // 
            historialDeFacturacionToolStripMenuItem.Name = "historialDeFacturacionToolStripMenuItem";
            historialDeFacturacionToolStripMenuItem.Size = new Size(197, 22);
            historialDeFacturacionToolStripMenuItem.Text = "Historial de facturacion";
            historialDeFacturacionToolStripMenuItem.Click += historialDeFacturacionToolStripMenuItem_Click;
            // 
            // historialDeVentasToolStripMenuItem
            // 
            historialDeVentasToolStripMenuItem.Name = "historialDeVentasToolStripMenuItem";
            historialDeVentasToolStripMenuItem.Size = new Size(197, 22);
            historialDeVentasToolStripMenuItem.Text = "Historial de ventas";
            historialDeVentasToolStripMenuItem.Click += historialDeVentasToolStripMenuItem_Click;
            // 
            // clienteToolStripMenuItem1
            // 
            clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            clienteToolStripMenuItem1.Size = new Size(197, 22);
            clienteToolStripMenuItem1.Text = "Cliente";
            clienteToolStripMenuItem1.Click += clienteToolStripMenuItem1_Click;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clienteToolStripMenuItem2, vendedorToolStripMenuItem });
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(62, 20);
            eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // clienteToolStripMenuItem2
            // 
            clienteToolStripMenuItem2.Name = "clienteToolStripMenuItem2";
            clienteToolStripMenuItem2.Size = new Size(180, 22);
            clienteToolStripMenuItem2.Text = "Cliente";
            clienteToolStripMenuItem2.Click += clienteToolStripMenuItem2_Click;
            // 
            // vendedorToolStripMenuItem
            // 
            vendedorToolStripMenuItem.Name = "vendedorToolStripMenuItem";
            vendedorToolStripMenuItem.Size = new Size(180, 22);
            vendedorToolStripMenuItem.Text = "Vendedor";
            vendedorToolStripMenuItem.Click += vendedorToolStripMenuItem_Click;
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
            btn_HeladeraSalir.Click += btn_HeladeraSalir_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(95, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(360, 270);
            dataGridView1.TabIndex = 3;
            // 
            // lb_HeladeraBiennvenida
            // 
            lb_HeladeraBiennvenida.AutoSize = true;
            lb_HeladeraBiennvenida.BackColor = Color.Transparent;
            lb_HeladeraBiennvenida.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_HeladeraBiennvenida.Location = new Point(25, 43);
            lb_HeladeraBiennvenida.Name = "lb_HeladeraBiennvenida";
            lb_HeladeraBiennvenida.Size = new Size(52, 21);
            lb_HeladeraBiennvenida.TabIndex = 4;
            lb_HeladeraBiennvenida.Text = "label1";
            // 
            // vendedorToolStripMenuItem2
            // 
            vendedorToolStripMenuItem2.Name = "vendedorToolStripMenuItem2";
            vendedorToolStripMenuItem2.Size = new Size(180, 22);
            vendedorToolStripMenuItem2.Text = "Vendedor";
            vendedorToolStripMenuItem2.Click += vendedorToolStripMenuItem2_Click;
            // 
            // FormHeladera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 450);
            Controls.Add(lb_HeladeraBiennvenida);
            Controls.Add(dataGridView1);
            Controls.Add(btn_HeladeraSalir);
            Controls.Add(btn_HeladeraVender);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "FormHeladera";
            Text = "Heladera";
            FormClosing += FormHeladera_FormClosing_1;
            Load += FormHeladera_Load_1;
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
        private Button btn_HeladeraVender;
        private Button btn_HeladeraSalir;
        private DataGridView dataGridView1;
        private ToolStripMenuItem modificarToolStripMenuItem;
        private ToolStripMenuItem precioPorKiloToolStripMenuItem;
        private Label lb_HeladeraBiennvenida;
        private ToolStripMenuItem verToolStripMenuItem;
        private ToolStripMenuItem historialDeFacturacionToolStripMenuItem;
        private ToolStripMenuItem historialDeVentasToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem1;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem2;
        private ToolStripMenuItem vendedorToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem3;
        private ToolStripMenuItem vendedorToolStripMenuItem1;
        private ToolStripMenuItem correoToolStripMenuItem;
        private ToolStripMenuItem passwordToolStripMenuItem;
        private ToolStripMenuItem montoToolStripMenuItem;
        private ToolStripMenuItem correoToolStripMenuItem1;
        private ToolStripMenuItem passwordToolStripMenuItem1;
        private ToolStripMenuItem vendedorToolStripMenuItem2;
    }
}