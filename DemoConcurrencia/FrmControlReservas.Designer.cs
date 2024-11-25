namespace DemoConcurrencia
{
    partial class FrmControlReservas
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
            btnReservar = new Button();
            btnLiberar = new Button();
            lblRecursosActivos = new Label();
            splitContainer1 = new SplitContainer();
            TxtResultado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // btnReservar
            // 
            btnReservar.BackColor = Color.FromArgb(255, 192, 255);
            btnReservar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReservar.Location = new Point(3, 27);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(135, 37);
            btnReservar.TabIndex = 0;
            btnReservar.Text = "Reservar Recursos";
            btnReservar.UseVisualStyleBackColor = false;
            btnReservar.Click += btnReservar_Click;
            // 
            // btnLiberar
            // 
            btnLiberar.BackColor = Color.FromArgb(192, 255, 255);
            btnLiberar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLiberar.Location = new Point(3, 116);
            btnLiberar.Name = "btnLiberar";
            btnLiberar.Size = new Size(135, 27);
            btnLiberar.TabIndex = 3;
            btnLiberar.Text = "Liberar Recurso";
            btnLiberar.UseVisualStyleBackColor = false;
            btnLiberar.Click += btnLiberar_Click;
            // 
            // lblRecursosActivos
            // 
            lblRecursosActivos.AutoSize = true;
            lblRecursosActivos.Location = new Point(17, 263);
            lblRecursosActivos.Name = "lblRecursosActivos";
            lblRecursosActivos.Size = new Size(108, 15);
            lblRecursosActivos.TabIndex = 4;
            lblRecursosActivos.Text = "Recursos Activos: 0";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 12);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(192, 255, 192);
            splitContainer1.Panel1.Controls.Add(btnLiberar);
            splitContainer1.Panel1.Controls.Add(lblRecursosActivos);
            splitContainer1.Panel1.Controls.Add(btnReservar);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TxtResultado);
            splitContainer1.Size = new Size(477, 305);
            splitContainer1.SplitterDistance = 158;
            splitContainer1.TabIndex = 5;
            // 
            // TxtResultado
            // 
            TxtResultado.Dock = DockStyle.Fill;
            TxtResultado.Location = new Point(0, 0);
            TxtResultado.Multiline = true;
            TxtResultado.Name = "TxtResultado";
            TxtResultado.Size = new Size(315, 305);
            TxtResultado.TabIndex = 2;
            // 
            // FrmControlReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 320);
            Controls.Add(splitContainer1);
            Name = "FrmControlReservas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmControlReservas";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnReservar;
        private Button btnLiberar;
        private Label lblRecursosActivos;
        private SplitContainer splitContainer1;
        private TextBox TxtResultado;
    }
}