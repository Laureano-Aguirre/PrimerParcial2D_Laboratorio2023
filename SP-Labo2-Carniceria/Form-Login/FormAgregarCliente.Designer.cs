namespace Form_Login
{
    partial class FormAgregarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarCliente));
            lb_AgregarClienteCorreo = new Label();
            lb_AgregarClientePassword = new Label();
            lb_AgregarClienteMonto = new Label();
            lb_AgregarClienteGasto = new Label();
            txb_AgregarClienteCorreo = new TextBox();
            txb_AgregarClientePassword = new TextBox();
            txb_AgregarClienteMonto = new TextBox();
            txb_AgregarClienteGasto = new TextBox();
            bn_AgregarClienteCancelar = new Button();
            btn_AgregarClienteAgregar = new Button();
            SuspendLayout();
            // 
            // lb_AgregarClienteCorreo
            // 
            lb_AgregarClienteCorreo.AutoSize = true;
            lb_AgregarClienteCorreo.Location = new Point(46, 50);
            lb_AgregarClienteCorreo.Name = "lb_AgregarClienteCorreo";
            lb_AgregarClienteCorreo.Size = new Size(43, 15);
            lb_AgregarClienteCorreo.TabIndex = 0;
            lb_AgregarClienteCorreo.Text = "Correo";
            // 
            // lb_AgregarClientePassword
            // 
            lb_AgregarClientePassword.AutoSize = true;
            lb_AgregarClientePassword.Location = new Point(46, 112);
            lb_AgregarClientePassword.Name = "lb_AgregarClientePassword";
            lb_AgregarClientePassword.Size = new Size(57, 15);
            lb_AgregarClientePassword.TabIndex = 1;
            lb_AgregarClientePassword.Text = "Password";
            // 
            // lb_AgregarClienteMonto
            // 
            lb_AgregarClienteMonto.AutoSize = true;
            lb_AgregarClienteMonto.Location = new Point(46, 183);
            lb_AgregarClienteMonto.Name = "lb_AgregarClienteMonto";
            lb_AgregarClienteMonto.Size = new Size(43, 15);
            lb_AgregarClienteMonto.TabIndex = 2;
            lb_AgregarClienteMonto.Text = "Monto";
            // 
            // lb_AgregarClienteGasto
            // 
            lb_AgregarClienteGasto.AutoSize = true;
            lb_AgregarClienteGasto.Location = new Point(46, 253);
            lb_AgregarClienteGasto.Name = "lb_AgregarClienteGasto";
            lb_AgregarClienteGasto.Size = new Size(37, 15);
            lb_AgregarClienteGasto.TabIndex = 3;
            lb_AgregarClienteGasto.Text = "Gasto";
            // 
            // txb_AgregarClienteCorreo
            // 
            txb_AgregarClienteCorreo.Location = new Point(46, 68);
            txb_AgregarClienteCorreo.Name = "txb_AgregarClienteCorreo";
            txb_AgregarClienteCorreo.PlaceholderText = "Ingrese aquí";
            txb_AgregarClienteCorreo.Size = new Size(100, 23);
            txb_AgregarClienteCorreo.TabIndex = 4;
            // 
            // txb_AgregarClientePassword
            // 
            txb_AgregarClientePassword.Location = new Point(46, 130);
            txb_AgregarClientePassword.Name = "txb_AgregarClientePassword";
            txb_AgregarClientePassword.PasswordChar = '*';
            txb_AgregarClientePassword.PlaceholderText = "Ingrese aquí";
            txb_AgregarClientePassword.Size = new Size(100, 23);
            txb_AgregarClientePassword.TabIndex = 5;
            // 
            // txb_AgregarClienteMonto
            // 
            txb_AgregarClienteMonto.Location = new Point(46, 201);
            txb_AgregarClienteMonto.Name = "txb_AgregarClienteMonto";
            txb_AgregarClienteMonto.PlaceholderText = "Ingrese aquí";
            txb_AgregarClienteMonto.Size = new Size(100, 23);
            txb_AgregarClienteMonto.TabIndex = 6;
            // 
            // txb_AgregarClienteGasto
            // 
            txb_AgregarClienteGasto.Location = new Point(46, 271);
            txb_AgregarClienteGasto.Name = "txb_AgregarClienteGasto";
            txb_AgregarClienteGasto.PlaceholderText = "Ingrese aquí";
            txb_AgregarClienteGasto.Size = new Size(100, 23);
            txb_AgregarClienteGasto.TabIndex = 7;
            // 
            // bn_AgregarClienteCancelar
            // 
            bn_AgregarClienteCancelar.BackColor = Color.RosyBrown;
            bn_AgregarClienteCancelar.Location = new Point(12, 328);
            bn_AgregarClienteCancelar.Name = "bn_AgregarClienteCancelar";
            bn_AgregarClienteCancelar.Size = new Size(96, 39);
            bn_AgregarClienteCancelar.TabIndex = 8;
            bn_AgregarClienteCancelar.Text = "Cancelar";
            bn_AgregarClienteCancelar.UseVisualStyleBackColor = false;
            bn_AgregarClienteCancelar.Click += bn_AgregarClienteCancelar_Click;
            // 
            // btn_AgregarClienteAgregar
            // 
            btn_AgregarClienteAgregar.BackColor = Color.YellowGreen;
            btn_AgregarClienteAgregar.Location = new Point(198, 328);
            btn_AgregarClienteAgregar.Name = "btn_AgregarClienteAgregar";
            btn_AgregarClienteAgregar.Size = new Size(96, 39);
            btn_AgregarClienteAgregar.TabIndex = 9;
            btn_AgregarClienteAgregar.Text = "Agregar";
            btn_AgregarClienteAgregar.UseVisualStyleBackColor = false;
            btn_AgregarClienteAgregar.Click += btn_AgregarClienteAgregar_Click;
            // 
            // FormAgregarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(306, 379);
            Controls.Add(btn_AgregarClienteAgregar);
            Controls.Add(bn_AgregarClienteCancelar);
            Controls.Add(txb_AgregarClienteGasto);
            Controls.Add(txb_AgregarClienteMonto);
            Controls.Add(txb_AgregarClientePassword);
            Controls.Add(txb_AgregarClienteCorreo);
            Controls.Add(lb_AgregarClienteGasto);
            Controls.Add(lb_AgregarClienteMonto);
            Controls.Add(lb_AgregarClientePassword);
            Controls.Add(lb_AgregarClienteCorreo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAgregarCliente";
            Text = "Agregar cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_AgregarClienteCorreo;
        private Label lb_AgregarClientePassword;
        private Label lb_AgregarClienteMonto;
        private Label lb_AgregarClienteGasto;
        private TextBox txb_AgregarClienteCorreo;
        private TextBox txb_AgregarClientePassword;
        private TextBox txb_AgregarClienteMonto;
        private TextBox txb_AgregarClienteGasto;
        private Button bn_AgregarClienteCancelar;
        private Button btn_AgregarClienteAgregar;
    }
}