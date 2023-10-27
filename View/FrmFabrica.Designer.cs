namespace View
{
    partial class FrmFabrica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFabrica));
            lstVehiculos = new ListBox();
            lblTipo = new Label();
            cmbTipo = new ComboBox();
            pcbFabrica = new PictureBox();
            button1 = new Button();
            btnFabricar = new Button();
            ((System.ComponentModel.ISupportInitialize)pcbFabrica).BeginInit();
            SuspendLayout();
            // 
            // lstVehiculos
            // 
            lstVehiculos.FormattingEnabled = true;
            lstVehiculos.HorizontalScrollbar = true;
            lstVehiculos.ItemHeight = 15;
            lstVehiculos.Location = new Point(0, 45);
            lstVehiculos.Name = "lstVehiculos";
            lstVehiculos.Size = new Size(718, 514);
            lstVehiculos.TabIndex = 0;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(827, 26);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(94, 15);
            lblTipo.TabIndex = 1;
            lblTipo.Text = "Tipo de vehiculo";
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(746, 44);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(251, 23);
            cmbTipo.TabIndex = 2;
            // 
            // pcbFabrica
            // 
            pcbFabrica.Image = (Image)resources.GetObject("pcbFabrica.Image");
            pcbFabrica.Location = new Point(746, 73);
            pcbFabrica.Name = "pcbFabrica";
            pcbFabrica.Size = new Size(251, 222);
            pcbFabrica.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbFabrica.TabIndex = 3;
            pcbFabrica.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(746, 301);
            button1.Name = "button1";
            button1.Size = new Size(251, 122);
            button1.TabIndex = 4;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnEliminar_Click;
            // 
            // btnFabricar
            // 
            btnFabricar.Location = new Point(746, 429);
            btnFabricar.Name = "btnFabricar";
            btnFabricar.Size = new Size(251, 122);
            btnFabricar.TabIndex = 5;
            btnFabricar.Text = "Fabricar";
            btnFabricar.UseVisualStyleBackColor = true;
            btnFabricar.Click += label1_Click;
            // 
            // FrmFabrica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 563);
            Controls.Add(btnFabricar);
            Controls.Add(button1);
            Controls.Add(pcbFabrica);
            Controls.Add(cmbTipo);
            Controls.Add(lblTipo);
            Controls.Add(lstVehiculos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmFabrica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fabrica de vehiculos";
            Load += FrmFabrica_Load;
            ((System.ComponentModel.ISupportInitialize)pcbFabrica).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstVehiculos;
        private Label lblTipo;
        private ComboBox cmbTipo;
        private PictureBox pcbFabrica;
        private Button button1;
        private Button btnFabricar;
    }
}