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
            label1 = new Label();
            rdb_AgregarTipoDeCorte = new RadioButton();
            rdb_AgregarStock = new RadioButton();
            txb_AgregarTipoDeCorte = new TextBox();
            lb_AgregarTipoDeCorte = new Label();
            nud_AgregarStock = new NumericUpDown();
            lb_AgregarStock = new Label();
            lb_AgregarSeleccionarCorte = new Label();
            btn_AgregarAgregar = new Button();
            btn_AgregarCancelar = new Button();
            cmb_AgregarSeleccionarCorte = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nud_AgregarStock).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 24);
            label1.Name = "label1";
            label1.Size = new Size(129, 17);
            label1.TabIndex = 0;
            label1.Text = "Que desea agregar?";
            // 
            // rdb_AgregarTipoDeCorte
            // 
            rdb_AgregarTipoDeCorte.AutoSize = true;
            rdb_AgregarTipoDeCorte.Location = new Point(22, 63);
            rdb_AgregarTipoDeCorte.Name = "rdb_AgregarTipoDeCorte";
            rdb_AgregarTipoDeCorte.Size = new Size(94, 19);
            rdb_AgregarTipoDeCorte.TabIndex = 1;
            rdb_AgregarTipoDeCorte.Text = "Tipo de corte";
            rdb_AgregarTipoDeCorte.UseVisualStyleBackColor = true;
            rdb_AgregarTipoDeCorte.CheckedChanged += rdb_AgregarTipoDeCorte_CheckedChanged;
            // 
            // rdb_AgregarStock
            // 
            rdb_AgregarStock.AutoSize = true;
            rdb_AgregarStock.Location = new Point(243, 63);
            rdb_AgregarStock.Name = "rdb_AgregarStock";
            rdb_AgregarStock.Size = new Size(54, 19);
            rdb_AgregarStock.TabIndex = 2;
            rdb_AgregarStock.Text = "Stock";
            rdb_AgregarStock.UseVisualStyleBackColor = true;
            rdb_AgregarStock.CheckedChanged += rdb_AgregarStock_CheckedChanged;
            // 
            // txb_AgregarTipoDeCorte
            // 
            txb_AgregarTipoDeCorte.Location = new Point(12, 138);
            txb_AgregarTipoDeCorte.Name = "txb_AgregarTipoDeCorte";
            txb_AgregarTipoDeCorte.PlaceholderText = "Agregue aqui";
            txb_AgregarTipoDeCorte.Size = new Size(139, 23);
            txb_AgregarTipoDeCorte.TabIndex = 3;
            // 
            // lb_AgregarTipoDeCorte
            // 
            lb_AgregarTipoDeCorte.AutoSize = true;
            lb_AgregarTipoDeCorte.Location = new Point(12, 120);
            lb_AgregarTipoDeCorte.Name = "lb_AgregarTipoDeCorte";
            lb_AgregarTipoDeCorte.Size = new Size(159, 15);
            lb_AgregarTipoDeCorte.TabIndex = 4;
            lb_AgregarTipoDeCorte.Text = "Agregue aquí el nuevo corte:";
            // 
            // nud_AgregarStock
            // 
            nud_AgregarStock.DecimalPlaces = 1;
            nud_AgregarStock.Location = new Point(68, 299);
            nud_AgregarStock.Name = "nud_AgregarStock";
            nud_AgregarStock.Size = new Size(68, 23);
            nud_AgregarStock.TabIndex = 5;
            // 
            // lb_AgregarStock
            // 
            lb_AgregarStock.AutoSize = true;
            lb_AgregarStock.Location = new Point(12, 281);
            lb_AgregarStock.Name = "lb_AgregarStock";
            lb_AgregarStock.Size = new Size(182, 15);
            lb_AgregarStock.TabIndex = 6;
            lb_AgregarStock.Text = "Agregue aquí para reponer stock:";
            // 
            // lb_AgregarSeleccionarCorte
            // 
            lb_AgregarSeleccionarCorte.AutoSize = true;
            lb_AgregarSeleccionarCorte.Location = new Point(12, 200);
            lb_AgregarSeleccionarCorte.Name = "lb_AgregarSeleccionarCorte";
            lb_AgregarSeleccionarCorte.Size = new Size(134, 15);
            lb_AgregarSeleccionarCorte.TabIndex = 8;
            lb_AgregarSeleccionarCorte.Text = "Seleccione aquí el corte:";
            // 
            // btn_AgregarAgregar
            // 
            btn_AgregarAgregar.BackColor = Color.YellowGreen;
            btn_AgregarAgregar.Location = new Point(257, 365);
            btn_AgregarAgregar.Name = "btn_AgregarAgregar";
            btn_AgregarAgregar.Size = new Size(81, 36);
            btn_AgregarAgregar.TabIndex = 9;
            btn_AgregarAgregar.Text = "Agregar";
            btn_AgregarAgregar.UseVisualStyleBackColor = false;
            btn_AgregarAgregar.Click += btn_AgregarAgregar_Click;
            // 
            // btn_AgregarCancelar
            // 
            btn_AgregarCancelar.BackColor = Color.RosyBrown;
            btn_AgregarCancelar.Location = new Point(12, 365);
            btn_AgregarCancelar.Name = "btn_AgregarCancelar";
            btn_AgregarCancelar.Size = new Size(81, 36);
            btn_AgregarCancelar.TabIndex = 10;
            btn_AgregarCancelar.Text = "Cancelar";
            btn_AgregarCancelar.UseVisualStyleBackColor = false;
            btn_AgregarCancelar.Click += btn_AgregarCancelar_Click;
            // 
            // cmb_AgregarSeleccionarCorte
            // 
            cmb_AgregarSeleccionarCorte.FormattingEnabled = true;
            cmb_AgregarSeleccionarCorte.Location = new Point(12, 218);
            cmb_AgregarSeleccionarCorte.Name = "cmb_AgregarSeleccionarCorte";
            cmb_AgregarSeleccionarCorte.Size = new Size(139, 23);
            cmb_AgregarSeleccionarCorte.TabIndex = 11;
            // 
            // FormAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(350, 413);
            Controls.Add(cmb_AgregarSeleccionarCorte);
            Controls.Add(btn_AgregarCancelar);
            Controls.Add(btn_AgregarAgregar);
            Controls.Add(lb_AgregarSeleccionarCorte);
            Controls.Add(lb_AgregarStock);
            Controls.Add(nud_AgregarStock);
            Controls.Add(lb_AgregarTipoDeCorte);
            Controls.Add(txb_AgregarTipoDeCorte);
            Controls.Add(rdb_AgregarStock);
            Controls.Add(rdb_AgregarTipoDeCorte);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAgregar";
            Text = "Agregar";
            FormClosing += FormAgregar_FormClosing;
            Load += FormAgregar_Load;
            Shown += FormAgregar_Shown;
            ((System.ComponentModel.ISupportInitialize)nud_AgregarStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private ComboBox cmb_AgregarSeleccionarCorte;
    }
}