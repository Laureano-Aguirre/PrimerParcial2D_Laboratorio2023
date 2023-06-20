namespace Form_Login
{
    partial class FormHistorialVentas
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
            rtb_HistorialVentas = new RichTextBox();
            btn_HistorialVentasAtras = new Button();
            btn_HistorialVentasGenerarTxt = new Button();
            btn_HistorialVentasSerializarXml = new Button();
            SuspendLayout();
            // 
            // rtb_HistorialVentas
            // 
            rtb_HistorialVentas.Location = new Point(12, 12);
            rtb_HistorialVentas.Name = "rtb_HistorialVentas";
            rtb_HistorialVentas.Size = new Size(591, 351);
            rtb_HistorialVentas.TabIndex = 0;
            rtb_HistorialVentas.Text = "";
            // 
            // btn_HistorialVentasAtras
            // 
            btn_HistorialVentasAtras.BackColor = Color.RosyBrown;
            btn_HistorialVentasAtras.Location = new Point(12, 399);
            btn_HistorialVentasAtras.Name = "btn_HistorialVentasAtras";
            btn_HistorialVentasAtras.Size = new Size(97, 39);
            btn_HistorialVentasAtras.TabIndex = 1;
            btn_HistorialVentasAtras.Text = "Atras";
            btn_HistorialVentasAtras.UseVisualStyleBackColor = false;
            btn_HistorialVentasAtras.Click += btn_HistorialVentasAtras_Click;
            // 
            // btn_HistorialVentasGenerarTxt
            // 
            btn_HistorialVentasGenerarTxt.BackColor = Color.YellowGreen;
            btn_HistorialVentasGenerarTxt.Location = new Point(506, 399);
            btn_HistorialVentasGenerarTxt.Name = "btn_HistorialVentasGenerarTxt";
            btn_HistorialVentasGenerarTxt.Size = new Size(97, 39);
            btn_HistorialVentasGenerarTxt.TabIndex = 2;
            btn_HistorialVentasGenerarTxt.Text = "Generar txt";
            btn_HistorialVentasGenerarTxt.UseVisualStyleBackColor = false;
            btn_HistorialVentasGenerarTxt.Click += btn_HistorialVentasGenerarTxt_Click;
            // 
            // btn_HistorialVentasSerializarXml
            // 
            btn_HistorialVentasSerializarXml.BackColor = Color.LemonChiffon;
            btn_HistorialVentasSerializarXml.Location = new Point(197, 399);
            btn_HistorialVentasSerializarXml.Name = "btn_HistorialVentasSerializarXml";
            btn_HistorialVentasSerializarXml.Size = new Size(97, 39);
            btn_HistorialVentasSerializarXml.TabIndex = 3;
            btn_HistorialVentasSerializarXml.Text = "Serializar xml";
            btn_HistorialVentasSerializarXml.UseVisualStyleBackColor = false;
            btn_HistorialVentasSerializarXml.Click += btn_HistorialVentasSerializarXml_Click;
            // 
            // FormHistorialVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(615, 450);
            Controls.Add(btn_HistorialVentasSerializarXml);
            Controls.Add(btn_HistorialVentasGenerarTxt);
            Controls.Add(btn_HistorialVentasAtras);
            Controls.Add(rtb_HistorialVentas);
            Name = "FormHistorialVentas";
            Text = "Historial de ventas";
            Load += FormHistorialVentas_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtb_HistorialVentas;
        private Button btn_HistorialVentasAtras;
        private Button btn_HistorialVentasGenerarTxt;
        private Button btn_HistorialVentasSerializarXml;
    }
}