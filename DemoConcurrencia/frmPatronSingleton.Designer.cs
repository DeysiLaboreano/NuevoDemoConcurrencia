namespace DemoConcurrencia
{
    partial class frmPatronSingleton
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
            btnAsignar = new Button();
            btnRecuperar = new Button();
            txtCadenaConexion = new TextBox();
            label1 = new Label();
            lblCadenaConexionRecuperada = new Label();
            SuspendLayout();
            // 
            // btnAsignar
            // 
            btnAsignar.BackColor = Color.FromArgb(255, 128, 255);
            btnAsignar.Location = new Point(12, 97);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(129, 76);
            btnAsignar.TabIndex = 0;
            btnAsignar.Text = "Asignar cadena de conexión ";
            btnAsignar.UseVisualStyleBackColor = false;
            btnAsignar.Click += btnAsignar_Click;
            // 
            // btnRecuperar
            // 
            btnRecuperar.BackColor = Color.FromArgb(128, 255, 128);
            btnRecuperar.Location = new Point(12, 209);
            btnRecuperar.Name = "btnRecuperar";
            btnRecuperar.Size = new Size(129, 76);
            btnRecuperar.TabIndex = 1;
            btnRecuperar.Text = "Obtener cadena de conexión ";
            btnRecuperar.UseVisualStyleBackColor = false;
            btnRecuperar.Click += btnRecuperar_Click;
            // 
            // txtCadenaConexion
            // 
            txtCadenaConexion.Location = new Point(37, 57);
            txtCadenaConexion.Name = "txtCadenaConexion";
            txtCadenaConexion.Size = new Size(310, 23);
            txtCadenaConexion.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 28);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 3;
            label1.Text = "Caneda de conexción";
            // 
            // lblCadenaConexionRecuperada
            // 
            lblCadenaConexionRecuperada.AutoSize = true;
            lblCadenaConexionRecuperada.Location = new Point(200, 251);
            lblCadenaConexionRecuperada.Name = "lblCadenaConexionRecuperada";
            lblCadenaConexionRecuperada.Size = new Size(0, 15);
            lblCadenaConexionRecuperada.TabIndex = 4;
            // 
            // frmPatronSingleton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(391, 326);
            Controls.Add(lblCadenaConexionRecuperada);
            Controls.Add(label1);
            Controls.Add(txtCadenaConexion);
            Controls.Add(btnRecuperar);
            Controls.Add(btnAsignar);
            Name = "frmPatronSingleton";
            Text = "Demostración de Patrón Singleton";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAsignar;
        private Button btnRecuperar;
        private TextBox txtCadenaConexion;
        private Label label1;
        private Label lblCadenaConexionRecuperada;
    }
}