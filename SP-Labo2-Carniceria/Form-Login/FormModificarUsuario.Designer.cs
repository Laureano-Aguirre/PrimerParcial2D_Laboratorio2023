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
            lb_ModificarUsuario = new Label();
            txb_ModificarUsuario = new TextBox();
            gpb_ModificarUsuario = new GroupBox();
            cmb_ModificarUsuario = new ComboBox();
            bn_ModificarUsuarioCancelar = new Button();
            btn_ModificarUsuarioModificar = new Button();
            gpb_ModificarUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // lb_ModificarUsuario
            // 
            lb_ModificarUsuario.AutoSize = true;
            lb_ModificarUsuario.Location = new Point(150, 123);
            lb_ModificarUsuario.Name = "lb_ModificarUsuario";
            lb_ModificarUsuario.Size = new Size(79, 15);
            lb_ModificarUsuario.TabIndex = 3;
            lb_ModificarUsuario.Text = "Correo nuevo";
            // 
            // txb_ModificarUsuario
            // 
            txb_ModificarUsuario.Location = new Point(117, 141);
            txb_ModificarUsuario.Name = "txb_ModificarUsuario";
            txb_ModificarUsuario.PlaceholderText = "Ingrese aquí";
            txb_ModificarUsuario.Size = new Size(144, 23);
            txb_ModificarUsuario.TabIndex = 7;
            // 
            // gpb_ModificarUsuario
            // 
            gpb_ModificarUsuario.Controls.Add(cmb_ModificarUsuario);
            gpb_ModificarUsuario.Location = new Point(90, 29);
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
            bn_ModificarUsuarioCancelar.Location = new Point(12, 194);
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
            btn_ModificarUsuarioModificar.Location = new Point(263, 194);
            btn_ModificarUsuarioModificar.Name = "btn_ModificarUsuarioModificar";
            btn_ModificarUsuarioModificar.Size = new Size(103, 41);
            btn_ModificarUsuarioModificar.TabIndex = 12;
            btn_ModificarUsuarioModificar.Text = "Modificar";
            btn_ModificarUsuarioModificar.UseVisualStyleBackColor = false;
            btn_ModificarUsuarioModificar.Click += btn_ModificarUsuarioModificar_Click;
            // 
            // FormModificarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(378, 247);
            Controls.Add(btn_ModificarUsuarioModificar);
            Controls.Add(bn_ModificarUsuarioCancelar);
            Controls.Add(gpb_ModificarUsuario);
            Controls.Add(txb_ModificarUsuario);
            Controls.Add(lb_ModificarUsuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormModificarUsuario";
            Text = "Modificar usuario";
            Load += FormModificarUsuario_Load;
            gpb_ModificarUsuario.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lb_ModificarUsuario;
        private TextBox txb_ModificarUsuario;
        private GroupBox gpb_ModificarUsuario;
        private ComboBox cmb_ModificarUsuario;
        private Button bn_ModificarUsuarioCancelar;
        private Button btn_ModificarUsuarioModificar;
    }
}