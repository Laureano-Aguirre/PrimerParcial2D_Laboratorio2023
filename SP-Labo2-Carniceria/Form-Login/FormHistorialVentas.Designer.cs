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
            btn_HistorialVentasDeserealizarXml = new Button();
            btn_HistorialVentaTipoDePagoXml = new Button();
            btn_HistorialVentaPagoDeserializarXml = new Button();
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
            btn_HistorialVentasSerializarXml.Location = new Point(133, 399);
            btn_HistorialVentasSerializarXml.Name = "btn_HistorialVentasSerializarXml";
            btn_HistorialVentasSerializarXml.Size = new Size(84, 39);
            btn_HistorialVentasSerializarXml.TabIndex = 3;
            btn_HistorialVentasSerializarXml.Text = "Serializar xml";
            btn_HistorialVentasSerializarXml.UseVisualStyleBackColor = false;
            btn_HistorialVentasSerializarXml.Click += btn_HistorialVentasSerializarXml_Click;
            // 
            // btn_HistorialVentasDeserealizarXml
            // 
            btn_HistorialVentasDeserealizarXml.BackColor = Color.LemonChiffon;
            btn_HistorialVentasDeserealizarXml.Location = new Point(232, 399);
            btn_HistorialVentasDeserealizarXml.Name = "btn_HistorialVentasDeserealizarXml";
            btn_HistorialVentasDeserealizarXml.Size = new Size(79, 39);
            btn_HistorialVentasDeserealizarXml.TabIndex = 4;
            btn_HistorialVentasDeserealizarXml.Text = "Deserializar xml";
            btn_HistorialVentasDeserealizarXml.UseVisualStyleBackColor = false;
            btn_HistorialVentasDeserealizarXml.Click += btn_HistorialVentasDeserealizarXml_Click;
            // 
            // btn_HistorialVentaTipoDePagoXml
            // 
            btn_HistorialVentaTipoDePagoXml.BackColor = Color.LemonChiffon;
            btn_HistorialVentaTipoDePagoXml.Location = new Point(326, 399);
            btn_HistorialVentaTipoDePagoXml.Name = "btn_HistorialVentaTipoDePagoXml";
            btn_HistorialVentaTipoDePagoXml.Size = new Size(79, 39);
            btn_HistorialVentaTipoDePagoXml.TabIndex = 5;
            btn_HistorialVentaTipoDePagoXml.Text = "Tipo de pago";
            btn_HistorialVentaTipoDePagoXml.UseVisualStyleBackColor = false;
            btn_HistorialVentaTipoDePagoXml.Click += btn_HistorialVentaTipoDePagoXml_Click;
            // 
            // btn_HistorialVentaPagoDeserializarXml
            // 
            btn_HistorialVentaPagoDeserializarXml.BackColor = Color.LemonChiffon;
            btn_HistorialVentaPagoDeserializarXml.Location = new Point(421, 399);
            btn_HistorialVentaPagoDeserializarXml.Name = "btn_HistorialVentaPagoDeserializarXml";
            btn_HistorialVentaPagoDeserializarXml.Size = new Size(79, 39);
            btn_HistorialVentaPagoDeserializarXml.TabIndex = 6;
            btn_HistorialVentaPagoDeserializarXml.Text = "Deserealizar Tipo de pago";
            btn_HistorialVentaPagoDeserializarXml.UseVisualStyleBackColor = false;
            btn_HistorialVentaPagoDeserializarXml.Click += btn_HistorialVentaPagoDeserializarXml_Click;
            // 
            // FormHistorialVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(615, 450);
            Controls.Add(btn_HistorialVentaPagoDeserializarXml);
            Controls.Add(btn_HistorialVentaTipoDePagoXml);
            Controls.Add(btn_HistorialVentasDeserealizarXml);
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
        private Button btn_HistorialVentasDeserealizarXml;
        private Button btn_HistorialVentaTipoDePagoXml;
        private Button btn_HistorialVentaPagoDeserializarXml;
    }
}