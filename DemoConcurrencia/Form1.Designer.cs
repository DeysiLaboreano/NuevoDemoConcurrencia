namespace DemoConcurrencia
{
    partial class FrmConcurrencia
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
            splitContainer1 = new SplitContainer();
            BtnCancelarProceso = new Button();
            BtnIniciarTarea = new Button();
            BtnSecuencial = new Button();
            BtnIniciarHilos = new Button();
            TxtResultado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(BtnCancelarProceso);
            splitContainer1.Panel1.Controls.Add(BtnIniciarTarea);
            splitContainer1.Panel1.Controls.Add(BtnSecuencial);
            splitContainer1.Panel1.Controls.Add(BtnIniciarHilos);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TxtResultado);
            splitContainer1.Size = new Size(502, 366);
            splitContainer1.SplitterDistance = 167;
            splitContainer1.TabIndex = 0;
            // 
            // BtnCancelarProceso
            // 
            BtnCancelarProceso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnCancelarProceso.BackColor = Color.MediumSpringGreen;
            BtnCancelarProceso.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            BtnCancelarProceso.Location = new Point(15, 279);
            BtnCancelarProceso.Name = "BtnCancelarProceso";
            BtnCancelarProceso.Size = new Size(137, 37);
            BtnCancelarProceso.TabIndex = 7;
            BtnCancelarProceso.Text = "Cancelar Proceso";
            BtnCancelarProceso.UseVisualStyleBackColor = false;
            BtnCancelarProceso.Click += BtnCancelarProceso_Click_1;
            // 
            // BtnIniciarTarea
            // 
            BtnIniciarTarea.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnIniciarTarea.BackColor = Color.FromArgb(192, 192, 255);
            BtnIniciarTarea.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            BtnIniciarTarea.Location = new Point(15, 176);
            BtnIniciarTarea.Name = "BtnIniciarTarea";
            BtnIniciarTarea.Size = new Size(137, 34);
            BtnIniciarTarea.TabIndex = 6;
            BtnIniciarTarea.Text = "Iniciar Tarea";
            BtnIniciarTarea.UseVisualStyleBackColor = false;
            BtnIniciarTarea.Click += BtnIniciarTarea_Click_1;
            // 
            // BtnSecuencial
            // 
            BtnSecuencial.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnSecuencial.BackColor = Color.FromArgb(192, 255, 192);
            BtnSecuencial.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            BtnSecuencial.Location = new Point(15, 50);
            BtnSecuencial.Name = "BtnSecuencial";
            BtnSecuencial.Size = new Size(137, 37);
            BtnSecuencial.TabIndex = 4;
            BtnSecuencial.Text = "Iniciar Secuencial ";
            BtnSecuencial.UseVisualStyleBackColor = false;
            BtnSecuencial.Click += BtnSecuencial_Click;
            // 
            // BtnIniciarHilos
            // 
            BtnIniciarHilos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnIniciarHilos.BackColor = Color.FromArgb(255, 192, 255);
            BtnIniciarHilos.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            BtnIniciarHilos.Location = new Point(15, 109);
            BtnIniciarHilos.Name = "BtnIniciarHilos";
            BtnIniciarHilos.Size = new Size(137, 34);
            BtnIniciarHilos.TabIndex = 5;
            BtnIniciarHilos.Text = "Iniciar Hilo";
            BtnIniciarHilos.UseVisualStyleBackColor = false;
            BtnIniciarHilos.Click += BtnIniciarHilos_Click_1;
            // 
            // TxtResultado
            // 
            TxtResultado.Dock = DockStyle.Fill;
            TxtResultado.Location = new Point(0, 0);
            TxtResultado.Multiline = true;
            TxtResultado.Name = "TxtResultado";
            TxtResultado.Size = new Size(331, 366);
            TxtResultado.TabIndex = 1;
            // 
            // FrmConcurrencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 366);
            Controls.Add(splitContainer1);
            Name = "FrmConcurrencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Demostración De Concurrencia";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button BtnCancelarProceso;
        private Button BtnIniciarTarea;
        private Button BtnSecuencial;
        private Button BtnIniciarHilos;
        private TextBox TxtResultado;
    }
}
