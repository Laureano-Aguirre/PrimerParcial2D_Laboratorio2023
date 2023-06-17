namespace Form_Login
{
    partial class FormFacturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFacturacion));
            this.label1 = new System.Windows.Forms.Label();
            this.dgb_Facturaciones = new System.Windows.Forms.DataGridView();
            this.btn_FacturacionAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgb_Facturaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado de facturaciones:";
            // 
            // dgb_Facturaciones
            // 
            this.dgb_Facturaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgb_Facturaciones.Location = new System.Drawing.Point(12, 64);
            this.dgb_Facturaciones.Name = "dgb_Facturaciones";
            this.dgb_Facturaciones.ReadOnly = true;
            this.dgb_Facturaciones.RowTemplate.Height = 25;
            this.dgb_Facturaciones.Size = new System.Drawing.Size(347, 156);
            this.dgb_Facturaciones.TabIndex = 1;
            // 
            // btn_FacturacionAtras
            // 
            this.btn_FacturacionAtras.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_FacturacionAtras.Location = new System.Drawing.Point(12, 269);
            this.btn_FacturacionAtras.Name = "btn_FacturacionAtras";
            this.btn_FacturacionAtras.Size = new System.Drawing.Size(88, 40);
            this.btn_FacturacionAtras.TabIndex = 2;
            this.btn_FacturacionAtras.Text = "Atras";
            this.btn_FacturacionAtras.UseVisualStyleBackColor = false;
            this.btn_FacturacionAtras.Click += new System.EventHandler(this.btn_FacturacionAtras_Click);
            // 
            // FormFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(426, 321);
            this.Controls.Add(this.btn_FacturacionAtras);
            this.Controls.Add(this.dgb_Facturaciones);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFacturacion";
            this.Text = "Facturaciones";
            this.Load += new System.EventHandler(this.FormFacturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgb_Facturaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dgb_Facturaciones;
        private Button btn_FacturacionAtras;
    }
}