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
            btn_HistorialVentaPagoDeserializarJson = new Button();
            btn_HistorialVentaTipoDePagoJson = new Button();
            btn_HistorialVentasDeserealizarJson = new Button();
            btn_HistorialVentasSerializarJson = new Button();
            SuspendLayout();
            // 
            // rtb_HistorialVentas
            // 
            rtb_HistorialVentas.Location = new Point(12, 12);
            rtb_HistorialVentas.Name = "rtb_HistorialVentas";
            rtb_HistorialVentas.ReadOnly = true;
            rtb_HistorialVentas.Size = new Size(591, 351);
            rtb_HistorialVentas.TabIndex = 0;
            rtb_HistorialVentas.Text = "";
            // 
            // btn_HistorialVentasAtras
            // 
            btn_HistorialVentasAtras.BackColor = Color.RosyBrown;
            btn_HistorialVentasAtras.Location = new Point(12, 481);
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
            btn_HistorialVentasGenerarTxt.Location = new Point(557, 481);
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
            btn_HistorialVentasSerializarXml.Location = new Point(133, 458);
            btn_HistorialVentasSerializarXml.Name = "btn_HistorialVentasSerializarXml";
            btn_HistorialVentasSerializarXml.Size = new Size(84, 62);
            btn_HistorialVentasSerializarXml.TabIndex = 3;
            btn_HistorialVentasSerializarXml.Text = "Serializar productos xml";
            btn_HistorialVentasSerializarXml.UseVisualStyleBackColor = false;
            btn_HistorialVentasSerializarXml.Click += btn_HistorialVentasSerializarXml_Click;
            // 
            // btn_HistorialVentasDeserealizarXml
            // 
            btn_HistorialVentasDeserealizarXml.BackColor = Color.LemonChiffon;
            btn_HistorialVentasDeserealizarXml.Location = new Point(234, 458);
            btn_HistorialVentasDeserealizarXml.Name = "btn_HistorialVentasDeserealizarXml";
            btn_HistorialVentasDeserealizarXml.Size = new Size(84, 62);
            btn_HistorialVentasDeserealizarXml.TabIndex = 4;
            btn_HistorialVentasDeserealizarXml.Text = "Deserializar productos xml";
            btn_HistorialVentasDeserealizarXml.UseVisualStyleBackColor = false;
            btn_HistorialVentasDeserealizarXml.Click += btn_HistorialVentasDeserealizarXml_Click;
            // 
            // btn_HistorialVentaTipoDePagoXml
            // 
            btn_HistorialVentaTipoDePagoXml.BackColor = Color.LemonChiffon;
            btn_HistorialVentaTipoDePagoXml.Location = new Point(337, 458);
            btn_HistorialVentaTipoDePagoXml.Name = "btn_HistorialVentaTipoDePagoXml";
            btn_HistorialVentaTipoDePagoXml.Size = new Size(84, 62);
            btn_HistorialVentaTipoDePagoXml.TabIndex = 5;
            btn_HistorialVentaTipoDePagoXml.Text = "Serializar tipo de pago xml";
            btn_HistorialVentaTipoDePagoXml.UseVisualStyleBackColor = false;
            btn_HistorialVentaTipoDePagoXml.Click += btn_HistorialVentaTipoDePagoXml_Click;
            // 
            // btn_HistorialVentaPagoDeserializarXml
            // 
            btn_HistorialVentaPagoDeserializarXml.BackColor = Color.LemonChiffon;
            btn_HistorialVentaPagoDeserializarXml.Location = new Point(446, 458);
            btn_HistorialVentaPagoDeserializarXml.Name = "btn_HistorialVentaPagoDeserializarXml";
            btn_HistorialVentaPagoDeserializarXml.Size = new Size(84, 62);
            btn_HistorialVentaPagoDeserializarXml.TabIndex = 6;
            btn_HistorialVentaPagoDeserializarXml.Text = "Deserealizar tipo de pago xml";
            btn_HistorialVentaPagoDeserializarXml.UseVisualStyleBackColor = false;
            btn_HistorialVentaPagoDeserializarXml.Click += btn_HistorialVentaPagoDeserializarXml_Click;
            // 
            // btn_HistorialVentaPagoDeserializarJson
            // 
            btn_HistorialVentaPagoDeserializarJson.BackColor = Color.LemonChiffon;
            btn_HistorialVentaPagoDeserializarJson.Location = new Point(446, 378);
            btn_HistorialVentaPagoDeserializarJson.Name = "btn_HistorialVentaPagoDeserializarJson";
            btn_HistorialVentaPagoDeserializarJson.Size = new Size(84, 74);
            btn_HistorialVentaPagoDeserializarJson.TabIndex = 10;
            btn_HistorialVentaPagoDeserializarJson.Text = "Deserealizar tipo de pago json";
            btn_HistorialVentaPagoDeserializarJson.UseVisualStyleBackColor = false;
            btn_HistorialVentaPagoDeserializarJson.Click += btn_HistorialVentaPagoDeserializarJson_Click;
            // 
            // btn_HistorialVentaTipoDePagoJson
            // 
            btn_HistorialVentaTipoDePagoJson.BackColor = Color.LemonChiffon;
            btn_HistorialVentaTipoDePagoJson.Location = new Point(337, 378);
            btn_HistorialVentaTipoDePagoJson.Name = "btn_HistorialVentaTipoDePagoJson";
            btn_HistorialVentaTipoDePagoJson.Size = new Size(84, 74);
            btn_HistorialVentaTipoDePagoJson.TabIndex = 9;
            btn_HistorialVentaTipoDePagoJson.Text = "Serializar tipo de pago json";
            btn_HistorialVentaTipoDePagoJson.UseVisualStyleBackColor = false;
            btn_HistorialVentaTipoDePagoJson.Click += btn_HistorialVentaTipoDePagoJson_Click;
            // 
            // btn_HistorialVentasDeserealizarJson
            // 
            btn_HistorialVentasDeserealizarJson.BackColor = Color.LemonChiffon;
            btn_HistorialVentasDeserealizarJson.Location = new Point(234, 378);
            btn_HistorialVentasDeserealizarJson.Name = "btn_HistorialVentasDeserealizarJson";
            btn_HistorialVentasDeserealizarJson.Size = new Size(84, 74);
            btn_HistorialVentasDeserealizarJson.TabIndex = 8;
            btn_HistorialVentasDeserealizarJson.Text = "Deserializar productos json";
            btn_HistorialVentasDeserealizarJson.UseVisualStyleBackColor = false;
            btn_HistorialVentasDeserealizarJson.Click += btn_HistorialVentasDeserealizarJson_Click;
            // 
            // btn_HistorialVentasSerializarJson
            // 
            btn_HistorialVentasSerializarJson.BackColor = Color.LemonChiffon;
            btn_HistorialVentasSerializarJson.Location = new Point(133, 378);
            btn_HistorialVentasSerializarJson.Name = "btn_HistorialVentasSerializarJson";
            btn_HistorialVentasSerializarJson.Size = new Size(84, 74);
            btn_HistorialVentasSerializarJson.TabIndex = 7;
            btn_HistorialVentasSerializarJson.Text = "Serializar productos json";
            btn_HistorialVentasSerializarJson.UseVisualStyleBackColor = false;
            btn_HistorialVentasSerializarJson.Click += btn_HistorialVentasSerializarJson_Click;
            // 
            // FormHistorialVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(666, 532);
            Controls.Add(btn_HistorialVentaPagoDeserializarJson);
            Controls.Add(btn_HistorialVentaTipoDePagoJson);
            Controls.Add(btn_HistorialVentasDeserealizarJson);
            Controls.Add(btn_HistorialVentasSerializarJson);
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
        private Button btn_HistorialVentaPagoDeserializarJson;
        private Button btn_HistorialVentaTipoDePagoJson;
        private Button btn_HistorialVentasDeserealizarJson;
        private Button btn_HistorialVentasSerializarJson;
    }
}