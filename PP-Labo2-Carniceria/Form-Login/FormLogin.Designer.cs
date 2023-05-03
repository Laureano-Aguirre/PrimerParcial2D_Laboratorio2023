namespace Form_Login
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb_LoginPassword = new System.Windows.Forms.Label();
            this.lb_LoginCorreo = new System.Windows.Forms.Label();
            this.btn_LoginIngresar = new System.Windows.Forms.Button();
            this.pb_Usuario = new System.Windows.Forms.PictureBox();
            this.txb_LoginCorreo = new System.Windows.Forms.TextBox();
            this.txb_LoginPassword = new System.Windows.Forms.TextBox();
            this.btn_LoginVendedor = new System.Windows.Forms.Button();
            this.btn_LoginCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_LoginPassword
            // 
            this.lb_LoginPassword.AutoSize = true;
            this.lb_LoginPassword.Location = new System.Drawing.Point(184, 274);
            this.lb_LoginPassword.Name = "lb_LoginPassword";
            this.lb_LoginPassword.Size = new System.Drawing.Size(67, 15);
            this.lb_LoginPassword.TabIndex = 0;
            this.lb_LoginPassword.Text = "Contraseña";
            // 
            // lb_LoginCorreo
            // 
            this.lb_LoginCorreo.AutoSize = true;
            this.lb_LoginCorreo.Location = new System.Drawing.Point(184, 216);
            this.lb_LoginCorreo.Name = "lb_LoginCorreo";
            this.lb_LoginCorreo.Size = new System.Drawing.Size(43, 15);
            this.lb_LoginCorreo.TabIndex = 1;
            this.lb_LoginCorreo.Text = "Correo";
            // 
            // btn_LoginIngresar
            // 
            this.btn_LoginIngresar.Location = new System.Drawing.Point(495, 354);
            this.btn_LoginIngresar.Name = "btn_LoginIngresar";
            this.btn_LoginIngresar.Size = new System.Drawing.Size(85, 34);
            this.btn_LoginIngresar.TabIndex = 2;
            this.btn_LoginIngresar.Text = "Ingresar";
            this.btn_LoginIngresar.UseVisualStyleBackColor = true;
            this.btn_LoginIngresar.Click += new System.EventHandler(this.btn_LoginIngresar_Click);
            // 
            // pb_Usuario
            // 
            this.pb_Usuario.Image = global::Form_Login.Properties.Resources.img_usuario;
            this.pb_Usuario.Location = new System.Drawing.Point(239, 83);
            this.pb_Usuario.Name = "pb_Usuario";
            this.pb_Usuario.Size = new System.Drawing.Size(105, 103);
            this.pb_Usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Usuario.TabIndex = 3;
            this.pb_Usuario.TabStop = false;
            // 
            // txb_LoginCorreo
            // 
            this.txb_LoginCorreo.Location = new System.Drawing.Point(184, 234);
            this.txb_LoginCorreo.Name = "txb_LoginCorreo";
            this.txb_LoginCorreo.PlaceholderText = "Ingrese aqui";
            this.txb_LoginCorreo.Size = new System.Drawing.Size(217, 23);
            this.txb_LoginCorreo.TabIndex = 4;
            // 
            // txb_LoginPassword
            // 
            this.txb_LoginPassword.Location = new System.Drawing.Point(184, 292);
            this.txb_LoginPassword.Name = "txb_LoginPassword";
            this.txb_LoginPassword.PasswordChar = '*';
            this.txb_LoginPassword.PlaceholderText = "Ingrese aqui";
            this.txb_LoginPassword.Size = new System.Drawing.Size(217, 23);
            this.txb_LoginPassword.TabIndex = 5;
            // 
            // btn_LoginVendedor
            // 
            this.btn_LoginVendedor.Location = new System.Drawing.Point(184, 352);
            this.btn_LoginVendedor.Name = "btn_LoginVendedor";
            this.btn_LoginVendedor.Size = new System.Drawing.Size(83, 31);
            this.btn_LoginVendedor.TabIndex = 6;
            this.btn_LoginVendedor.Text = "Vendedor";
            this.btn_LoginVendedor.UseVisualStyleBackColor = true;
            this.btn_LoginVendedor.Click += new System.EventHandler(this.btn_LoginVendedor_Click);
            // 
            // btn_LoginCliente
            // 
            this.btn_LoginCliente.Location = new System.Drawing.Point(320, 352);
            this.btn_LoginCliente.Name = "btn_LoginCliente";
            this.btn_LoginCliente.Size = new System.Drawing.Size(81, 31);
            this.btn_LoginCliente.TabIndex = 7;
            this.btn_LoginCliente.Text = "Cliente";
            this.btn_LoginCliente.UseVisualStyleBackColor = true;
            this.btn_LoginCliente.Click += new System.EventHandler(this.btn_LoginCliente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 421);
            this.Controls.Add(this.btn_LoginCliente);
            this.Controls.Add(this.btn_LoginVendedor);
            this.Controls.Add(this.txb_LoginPassword);
            this.Controls.Add(this.txb_LoginCorreo);
            this.Controls.Add(this.pb_Usuario);
            this.Controls.Add(this.btn_LoginIngresar);
            this.Controls.Add(this.lb_LoginCorreo);
            this.Controls.Add(this.lb_LoginPassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Usuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_LoginPassword;
        private Label lb_LoginCorreo;
        private Button btn_LoginIngresar;
        private PictureBox pb_Usuario;
        private TextBox txb_LoginCorreo;
        private TextBox txb_LoginPassword;
        private Button btn_LoginVendedor;
        private Button btn_LoginCliente;
    }
}