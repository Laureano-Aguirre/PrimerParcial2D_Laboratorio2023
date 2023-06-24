namespace Form_Login
{
    partial class FormAgregarVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarVendedor));
            btn_AgregarVendedorAgregar = new Button();
            bn_AgregarVendedorCancelar = new Button();
            txb_AgregarVendedorPassword = new TextBox();
            txb_AgregarVendedorCorreo = new TextBox();
            lb_AgregarVendedorPassword = new Label();
            lb_AgregarVendedorCorreo = new Label();
            lb_AgregarVendedor = new Label();
            SuspendLayout();
            // 
            // btn_AgregarVendedorAgregar
            // 
            btn_AgregarVendedorAgregar.BackColor = Color.YellowGreen;
            btn_AgregarVendedorAgregar.Location = new Point(207, 213);
            btn_AgregarVendedorAgregar.Name = "btn_AgregarVendedorAgregar";
            btn_AgregarVendedorAgregar.Size = new Size(96, 39);
            btn_AgregarVendedorAgregar.TabIndex = 15;
            btn_AgregarVendedorAgregar.Text = "Agregar";
            btn_AgregarVendedorAgregar.UseVisualStyleBackColor = false;
            btn_AgregarVendedorAgregar.Click += btn_AgregarVendedorAgregar_Click;
            // 
            // bn_AgregarVendedorCancelar
            // 
            bn_AgregarVendedorCancelar.BackColor = Color.RosyBrown;
            bn_AgregarVendedorCancelar.Location = new Point(12, 213);
            bn_AgregarVendedorCancelar.Name = "bn_AgregarVendedorCancelar";
            bn_AgregarVendedorCancelar.Size = new Size(96, 39);
            bn_AgregarVendedorCancelar.TabIndex = 14;
            bn_AgregarVendedorCancelar.Text = "Cancelar";
            bn_AgregarVendedorCancelar.UseVisualStyleBackColor = false;
            bn_AgregarVendedorCancelar.Click += bn_AgregarVendedorCancelar_Click;
            // 
            // txb_AgregarVendedorPassword
            // 
            txb_AgregarVendedorPassword.Location = new Point(75, 139);
            txb_AgregarVendedorPassword.Name = "txb_AgregarVendedorPassword";
            txb_AgregarVendedorPassword.PasswordChar = '*';
            txb_AgregarVendedorPassword.PlaceholderText = "Ingrese aquí";
            txb_AgregarVendedorPassword.Size = new Size(165, 23);
            txb_AgregarVendedorPassword.TabIndex = 13;
            // 
            // txb_AgregarVendedorCorreo
            // 
            txb_AgregarVendedorCorreo.Location = new Point(75, 77);
            txb_AgregarVendedorCorreo.Name = "txb_AgregarVendedorCorreo";
            txb_AgregarVendedorCorreo.PlaceholderText = "Ingrese aquí";
            txb_AgregarVendedorCorreo.Size = new Size(165, 23);
            txb_AgregarVendedorCorreo.TabIndex = 12;
            // 
            // lb_AgregarVendedorPassword
            // 
            lb_AgregarVendedorPassword.AutoSize = true;
            lb_AgregarVendedorPassword.Location = new Point(75, 121);
            lb_AgregarVendedorPassword.Name = "lb_AgregarVendedorPassword";
            lb_AgregarVendedorPassword.Size = new Size(57, 15);
            lb_AgregarVendedorPassword.TabIndex = 11;
            lb_AgregarVendedorPassword.Text = "Password";
            // 
            // lb_AgregarVendedorCorreo
            // 
            lb_AgregarVendedorCorreo.AutoSize = true;
            lb_AgregarVendedorCorreo.Location = new Point(75, 59);
            lb_AgregarVendedorCorreo.Name = "lb_AgregarVendedorCorreo";
            lb_AgregarVendedorCorreo.Size = new Size(43, 15);
            lb_AgregarVendedorCorreo.TabIndex = 10;
            lb_AgregarVendedorCorreo.Text = "Correo";
            // 
            // lb_AgregarVendedor
            // 
            lb_AgregarVendedor.AutoSize = true;
            lb_AgregarVendedor.Location = new Point(57, 18);
            lb_AgregarVendedor.Name = "lb_AgregarVendedor";
            lb_AgregarVendedor.Size = new Size(206, 15);
            lb_AgregarVendedor.TabIndex = 16;
            lb_AgregarVendedor.Text = "Ingrese los datos del nuevo vendedor:";
            // 
            // FormAgregarVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(315, 269);
            Controls.Add(lb_AgregarVendedor);
            Controls.Add(btn_AgregarVendedorAgregar);
            Controls.Add(bn_AgregarVendedorCancelar);
            Controls.Add(txb_AgregarVendedorPassword);
            Controls.Add(txb_AgregarVendedorCorreo);
            Controls.Add(lb_AgregarVendedorPassword);
            Controls.Add(lb_AgregarVendedorCorreo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAgregarVendedor";
            Text = "Agregar vendedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_AgregarVendedorAgregar;
        private Button bn_AgregarVendedorCancelar;
        private TextBox txb_AgregarVendedorPassword;
        private TextBox txb_AgregarVendedorCorreo;
        private Label lb_AgregarVendedorPassword;
        private Label lb_AgregarVendedorCorreo;
        private Label lb_AgregarVendedor;
    }
}