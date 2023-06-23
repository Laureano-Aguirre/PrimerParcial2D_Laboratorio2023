namespace Form_Login
{
    partial class FormModificarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificarUsuario));
            lb_ModificarUsuarioCorreo = new Label();
            lb_ModificarUsuarioPassword = new Label();
            lb_ModificarUsuarioMonto = new Label();
            txb_ModificarUsuarioCorreo = new TextBox();
            txb_ModificarUsuarioPassword = new TextBox();
            txb_ModificarUsuarioMonto = new TextBox();
            gpb_ModificarUsuario = new GroupBox();
            cmb_ModificarUsuario = new ComboBox();
            bn_ModificarUsuarioCancelar = new Button();
            btn_ModificarUsuarioModificar = new Button();
            gpb_ModificarUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // lb_ModificarUsuarioCorreo
            // 
            lb_ModificarUsuarioCorreo.AutoSize = true;
            lb_ModificarUsuarioCorreo.Location = new Point(40, 111);
            lb_ModificarUsuarioCorreo.Name = "lb_ModificarUsuarioCorreo";
            lb_ModificarUsuarioCorreo.Size = new Size(79, 15);
            lb_ModificarUsuarioCorreo.TabIndex = 3;
            lb_ModificarUsuarioCorreo.Text = "Correo nuevo";
            // 
            // lb_ModificarUsuarioPassword
            // 
            lb_ModificarUsuarioPassword.AutoSize = true;
            lb_ModificarUsuarioPassword.Location = new Point(40, 186);
            lb_ModificarUsuarioPassword.Name = "lb_ModificarUsuarioPassword";
            lb_ModificarUsuarioPassword.Size = new Size(102, 15);
            lb_ModificarUsuarioPassword.TabIndex = 4;
            lb_ModificarUsuarioPassword.Text = "Contraseña nueva";
            // 
            // lb_ModificarUsuarioMonto
            // 
            lb_ModificarUsuarioMonto.AutoSize = true;
            lb_ModificarUsuarioMonto.Location = new Point(40, 260);
            lb_ModificarUsuarioMonto.Name = "lb_ModificarUsuarioMonto";
            lb_ModificarUsuarioMonto.Size = new Size(79, 15);
            lb_ModificarUsuarioMonto.TabIndex = 5;
            lb_ModificarUsuarioMonto.Text = "Monto nuevo";
            // 
            // txb_ModificarUsuarioCorreo
            // 
            txb_ModificarUsuarioCorreo.Location = new Point(40, 129);
            txb_ModificarUsuarioCorreo.Name = "txb_ModificarUsuarioCorreo";
            txb_ModificarUsuarioCorreo.PlaceholderText = "Ingrese aquí";
            txb_ModificarUsuarioCorreo.Size = new Size(144, 23);
            txb_ModificarUsuarioCorreo.TabIndex = 7;
            // 
            // txb_ModificarUsuarioPassword
            // 
            txb_ModificarUsuarioPassword.Location = new Point(40, 204);
            txb_ModificarUsuarioPassword.Name = "txb_ModificarUsuarioPassword";
            txb_ModificarUsuarioPassword.PasswordChar = '*';
            txb_ModificarUsuarioPassword.PlaceholderText = "Ingrese aquí";
            txb_ModificarUsuarioPassword.Size = new Size(144, 23);
            txb_ModificarUsuarioPassword.TabIndex = 8;
            // 
            // txb_ModificarUsuarioMonto
            // 
            txb_ModificarUsuarioMonto.Location = new Point(40, 278);
            txb_ModificarUsuarioMonto.Name = "txb_ModificarUsuarioMonto";
            txb_ModificarUsuarioMonto.PlaceholderText = "Ingrese aquí";
            txb_ModificarUsuarioMonto.Size = new Size(100, 23);
            txb_ModificarUsuarioMonto.TabIndex = 9;
            // 
            // gpb_ModificarUsuario
            // 
            gpb_ModificarUsuario.Controls.Add(cmb_ModificarUsuario);
            gpb_ModificarUsuario.Location = new Point(80, 28);
            gpb_ModificarUsuario.Name = "gpb_ModificarUsuario";
            gpb_ModificarUsuario.Size = new Size(200, 62);
            gpb_ModificarUsuario.TabIndex = 10;
            gpb_ModificarUsuario.TabStop = false;
            gpb_ModificarUsuario.Text = "Usuarios";
            // 
            // cmb_ModificarUsuario
            // 
            cmb_ModificarUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_ModificarUsuario.FormattingEnabled = true;
            cmb_ModificarUsuario.Location = new Point(6, 22);
            cmb_ModificarUsuario.Name = "cmb_ModificarUsuario";
            cmb_ModificarUsuario.Size = new Size(188, 23);
            cmb_ModificarUsuario.TabIndex = 0;
            cmb_ModificarUsuario.SelectedValueChanged += cmb_ModificarUsuario_SelectedValueChanged;
            // 
            // bn_ModificarUsuarioCancelar
            // 
            bn_ModificarUsuarioCancelar.BackColor = Color.RosyBrown;
            bn_ModificarUsuarioCancelar.Location = new Point(12, 333);
            bn_ModificarUsuarioCancelar.Name = "bn_ModificarUsuarioCancelar";
            bn_ModificarUsuarioCancelar.Size = new Size(103, 41);
            bn_ModificarUsuarioCancelar.TabIndex = 11;
            bn_ModificarUsuarioCancelar.Text = "Cancelar";
            bn_ModificarUsuarioCancelar.UseVisualStyleBackColor = false;
            bn_ModificarUsuarioCancelar.Click += bn_ModificarUsuarioCancelar_Click;
            // 
            // btn_ModificarUsuarioModificar
            // 
            btn_ModificarUsuarioModificar.BackColor = Color.YellowGreen;
            btn_ModificarUsuarioModificar.Location = new Point(263, 333);
            btn_ModificarUsuarioModificar.Name = "btn_ModificarUsuarioModificar";
            btn_ModificarUsuarioModificar.Size = new Size(103, 41);
            btn_ModificarUsuarioModificar.TabIndex = 12;
            btn_ModificarUsuarioModificar.Text = "Modificar";
            btn_ModificarUsuarioModificar.UseVisualStyleBackColor = false;
            // 
            // FormModificarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(378, 386);
            Controls.Add(btn_ModificarUsuarioModificar);
            Controls.Add(bn_ModificarUsuarioCancelar);
            Controls.Add(gpb_ModificarUsuario);
            Controls.Add(txb_ModificarUsuarioMonto);
            Controls.Add(txb_ModificarUsuarioPassword);
            Controls.Add(txb_ModificarUsuarioCorreo);
            Controls.Add(lb_ModificarUsuarioMonto);
            Controls.Add(lb_ModificarUsuarioPassword);
            Controls.Add(lb_ModificarUsuarioCorreo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormModificarUsuario";
            Text = "Modificar usuario";
            Load += FormModificarUsuario_Load;
            gpb_ModificarUsuario.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lb_ModificarUsuarioCorreo;
        private Label lb_ModificarUsuarioPassword;
        private Label lb_ModificarUsuarioMonto;
        private TextBox txb_ModificarUsuarioCorreo;
        private TextBox txb_ModificarUsuarioPassword;
        private TextBox txb_ModificarUsuarioMonto;
        private GroupBox gpb_ModificarUsuario;
        private ComboBox cmb_ModificarUsuario;
        private Button bn_ModificarUsuarioCancelar;
        private Button btn_ModificarUsuarioModificar;
    }
}