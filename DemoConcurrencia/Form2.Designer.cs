namespace DemoConcurrencia
{
    partial class frmBloqueos
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
            btnIncrementar = new Button();
            lblContador = new Label();
            btnDisminuir = new Button();
            splitContainer1 = new SplitContainer();
            TxtResultado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // btnIncrementar
            // 
            btnIncrementar.BackColor = Color.FromArgb(192, 255, 192);
            btnIncrementar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIncrementar.Location = new Point(22, 24);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(99, 31);
            btnIncrementar.TabIndex = 0;
            btnIncrementar.Text = "Incrementar";
            btnIncrementar.UseVisualStyleBackColor = false;
            btnIncrementar.Click += btnIncrementar_Click;
            // 
            // lblContador
            // 
            lblContador.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblContador.AutoSize = true;
            lblContador.Location = new Point(46, 296);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(13, 15);
            lblContador.TabIndex = 1;
            lblContador.Text = "0";
            // 
            // btnDisminuir
            // 
            btnDisminuir.BackColor = Color.FromArgb(192, 255, 255);
            btnDisminuir.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDisminuir.Location = new Point(22, 61);
            btnDisminuir.Name = "btnDisminuir";
            btnDisminuir.Size = new Size(99, 27);
            btnDisminuir.TabIndex = 2;
            btnDisminuir.Text = "Disminuir";
            btnDisminuir.UseVisualStyleBackColor = false;
            btnDisminuir.Click += btnDisminuir_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnIncrementar);
            splitContainer1.Panel1.Controls.Add(lblContador);
            splitContainer1.Panel1.Controls.Add(btnDisminuir);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TxtResultado);
            splitContainer1.Size = new Size(445, 332);
            splitContainer1.SplitterDistance = 147;
            splitContainer1.TabIndex = 3;
            // 
            // TxtResultado
            // 
            TxtResultado.Dock = DockStyle.Fill;
            TxtResultado.Location = new Point(0, 0);
            TxtResultado.Multiline = true;
            TxtResultado.Name = "TxtResultado";
            TxtResultado.Size = new Size(294, 332);
            TxtResultado.TabIndex = 1;
            // 
            // frmBloqueos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(445, 332);
            Controls.Add(splitContainer1);
            Name = "frmBloqueos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Bloqueos";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnIncrementar;
        private Label lblContador;
        private Button btnDisminuir;
        private SplitContainer splitContainer1;
        private TextBox TxtResultado;
    }
}