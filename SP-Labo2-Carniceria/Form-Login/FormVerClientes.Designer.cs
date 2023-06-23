namespace Form_Login
{
    partial class FormVerClientes
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
            rtb_VerClientes = new RichTextBox();
            btn_VerClientesAtras = new Button();
            SuspendLayout();
            // 
            // rtb_VerClientes
            // 
            rtb_VerClientes.Location = new Point(12, 30);
            rtb_VerClientes.Name = "rtb_VerClientes";
            rtb_VerClientes.Size = new Size(484, 202);
            rtb_VerClientes.TabIndex = 0;
            rtb_VerClientes.Text = "";
            // 
            // btn_VerClientesAtras
            // 
            btn_VerClientesAtras.BackColor = Color.RosyBrown;
            btn_VerClientesAtras.Location = new Point(12, 261);
            btn_VerClientesAtras.Name = "btn_VerClientesAtras";
            btn_VerClientesAtras.Size = new Size(99, 37);
            btn_VerClientesAtras.TabIndex = 1;
            btn_VerClientesAtras.Text = "Atras";
            btn_VerClientesAtras.UseVisualStyleBackColor = false;
            btn_VerClientesAtras.Click += btn_VerClientesAtras_Click;
            // 
            // FormVerClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(511, 310);
            Controls.Add(btn_VerClientesAtras);
            Controls.Add(rtb_VerClientes);
            Name = "FormVerClientes";
            Text = "Clientes";
            Load += FormVerClientes_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtb_VerClientes;
        private Button btn_VerClientesAtras;
    }
}