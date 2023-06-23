namespace Form_Login
{
    partial class FormBorrarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBorrarCliente));
            lb_BorrarCliente = new Label();
            cmb_BorrarClienteLista = new ComboBox();
            btn_BorrarClienteCancelar = new Button();
            btn_BorrarClienteBorrar = new Button();
            SuspendLayout();
            // 
            // lb_BorrarCliente
            // 
            lb_BorrarCliente.AutoSize = true;
            lb_BorrarCliente.Location = new Point(35, 53);
            lb_BorrarCliente.Name = "lb_BorrarCliente";
            lb_BorrarCliente.Size = new Size(215, 15);
            lb_BorrarCliente.TabIndex = 0;
            lb_BorrarCliente.Text = "Seleccione el cliente que desea eliminar";
            // 
            // cmb_BorrarClienteLista
            // 
            cmb_BorrarClienteLista.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_BorrarClienteLista.FormattingEnabled = true;
            cmb_BorrarClienteLista.Location = new Point(35, 81);
            cmb_BorrarClienteLista.Name = "cmb_BorrarClienteLista";
            cmb_BorrarClienteLista.Size = new Size(215, 23);
            cmb_BorrarClienteLista.TabIndex = 1;
            cmb_BorrarClienteLista.SelectedValueChanged += cmb_BorrarClienteLista_SelectedValueChanged;
            // 
            // btn_BorrarClienteCancelar
            // 
            btn_BorrarClienteCancelar.BackColor = Color.RosyBrown;
            btn_BorrarClienteCancelar.Location = new Point(12, 235);
            btn_BorrarClienteCancelar.Name = "btn_BorrarClienteCancelar";
            btn_BorrarClienteCancelar.Size = new Size(87, 37);
            btn_BorrarClienteCancelar.TabIndex = 2;
            btn_BorrarClienteCancelar.Text = "Cancelar";
            btn_BorrarClienteCancelar.UseVisualStyleBackColor = false;
            btn_BorrarClienteCancelar.Click += btn_BorrarClienteCancelar_Click;
            // 
            // btn_BorrarClienteBorrar
            // 
            btn_BorrarClienteBorrar.BackColor = Color.YellowGreen;
            btn_BorrarClienteBorrar.Location = new Point(186, 235);
            btn_BorrarClienteBorrar.Name = "btn_BorrarClienteBorrar";
            btn_BorrarClienteBorrar.Size = new Size(87, 37);
            btn_BorrarClienteBorrar.TabIndex = 3;
            btn_BorrarClienteBorrar.Text = "Borrar";
            btn_BorrarClienteBorrar.UseVisualStyleBackColor = false;
            btn_BorrarClienteBorrar.Click += btn_BorrarClienteBorrar_Click;
            // 
            // FormBorrarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(285, 284);
            Controls.Add(btn_BorrarClienteBorrar);
            Controls.Add(btn_BorrarClienteCancelar);
            Controls.Add(cmb_BorrarClienteLista);
            Controls.Add(lb_BorrarCliente);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormBorrarCliente";
            Text = "Borrar cliente";
            Load += FormBorrarCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_BorrarCliente;
        private ComboBox cmb_BorrarClienteLista;
        private Button btn_BorrarClienteCancelar;
        private Button btn_BorrarClienteBorrar;
    }
}