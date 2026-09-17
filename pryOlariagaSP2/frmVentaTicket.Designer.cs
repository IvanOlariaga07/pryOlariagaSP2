namespace pryOlariagaSP2
{
    partial class frmVentaTicket
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.dtmFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbTickets = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lstRegistro = new System.Windows.Forms.ListBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNumero.Location = new System.Drawing.Point(151, 97);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(163, 20);
            this.txtNumero.TabIndex = 0;
            // 
            // dtmFecha
            // 
            this.dtmFecha.Location = new System.Drawing.Point(134, 3);
            this.dtmFecha.Name = "dtmFecha";
            this.dtmFecha.Size = new System.Drawing.Size(213, 20);
            this.dtmFecha.TabIndex = 1;
            // 
            // cmbTickets
            // 
            this.cmbTickets.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbTickets.FormattingEnabled = true;
            this.cmbTickets.Items.AddRange(new object[] {
            "- Básico",
            "- Estándar",
            "-Premium"});
            this.cmbTickets.Location = new System.Drawing.Point(151, 123);
            this.cmbTickets.Name = "cmbTickets";
            this.cmbTickets.Size = new System.Drawing.Size(163, 21);
            this.cmbTickets.TabIndex = 2;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(256, 164);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(80, 24);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lstRegistro
            // 
            this.lstRegistro.FormattingEnabled = true;
            this.lstRegistro.Location = new System.Drawing.Point(45, 194);
            this.lstRegistro.Name = "lstRegistro";
            this.lstRegistro.Size = new System.Drawing.Size(291, 82);
            this.lstRegistro.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombre.Location = new System.Drawing.Point(54, 97);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nº de Ticket: ";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTipo.Location = new System.Drawing.Point(54, 126);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(82, 13);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.Text = "Tipo de Ticket: ";
            // 
            // frmVentaTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryOlariagaSP2.Properties.Resources.descarga;
            this.ClientSize = new System.Drawing.Size(350, 318);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lstRegistro);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cmbTickets);
            this.Controls.Add(this.dtmFecha);
            this.Controls.Add(this.txtNumero);
            this.Name = "frmVentaTicket";
            this.Text = "frmVentaTicket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.DateTimePicker dtmFecha;
        private System.Windows.Forms.ComboBox cmbTickets;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ListBox lstRegistro;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTipo;
    }
}