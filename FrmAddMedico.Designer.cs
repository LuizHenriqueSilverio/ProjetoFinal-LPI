namespace AgendaMedica
{
	partial class FrmAddMedico
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
            this.btnFechar = new FontAwesome.Sharp.IconButton();
            this.painelTitulo = new System.Windows.Forms.Panel();
            this.Titulo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnomeMedico = new System.Windows.Forms.TextBox();
            this.txtcrmMedico = new System.Windows.Forms.TextBox();
            this.txtespMedico = new System.Windows.Forms.TextBox();
            this.btnAddMedico = new FontAwesome.Sharp.IconButton();
            this.painelTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnFechar.IconChar = FontAwesome.Sharp.IconChar.XmarkSquare;
            this.btnFechar.IconColor = System.Drawing.Color.White;
            this.btnFechar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFechar.Location = new System.Drawing.Point(749, 9);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(39, 37);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // painelTitulo
            // 
            this.painelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.painelTitulo.Controls.Add(this.Titulo);
            this.painelTitulo.Controls.Add(this.btnFechar);
            this.painelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelTitulo.Location = new System.Drawing.Point(0, 0);
            this.painelTitulo.Name = "painelTitulo";
            this.painelTitulo.Size = new System.Drawing.Size(800, 75);
            this.painelTitulo.TabIndex = 2;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.Titulo.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.Titulo.Location = new System.Drawing.Point(230, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(286, 37);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Cadastro de Médicos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label3.Location = new System.Drawing.Point(46, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label1.Location = new System.Drawing.Point(46, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "CRM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label2.Location = new System.Drawing.Point(46, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Especialidade(s):";
            // 
            // txtnomeMedico
            // 
            this.txtnomeMedico.Location = new System.Drawing.Point(188, 74);
            this.txtnomeMedico.Name = "txtnomeMedico";
            this.txtnomeMedico.Size = new System.Drawing.Size(377, 23);
            this.txtnomeMedico.TabIndex = 7;
            // 
            // txtcrmMedico
            // 
            this.txtcrmMedico.Location = new System.Drawing.Point(188, 117);
            this.txtcrmMedico.Name = "txtcrmMedico";
            this.txtcrmMedico.Size = new System.Drawing.Size(377, 23);
            this.txtcrmMedico.TabIndex = 8;
            // 
            // txtespMedico
            // 
            this.txtespMedico.Location = new System.Drawing.Point(188, 161);
            this.txtespMedico.Name = "txtespMedico";
            this.txtespMedico.Size = new System.Drawing.Size(377, 23);
            this.txtespMedico.TabIndex = 9;
            // 
            // btnAddMedico
            // 
            this.btnAddMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMedico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddMedico.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnAddMedico.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddMedico.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnAddMedico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddMedico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMedico.Location = new System.Drawing.Point(321, 232);
            this.btnAddMedico.Name = "btnAddMedico";
            this.btnAddMedico.Size = new System.Drawing.Size(153, 56);
            this.btnAddMedico.TabIndex = 12;
            this.btnAddMedico.Text = "Cadastrar";
            this.btnAddMedico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMedico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddMedico.UseVisualStyleBackColor = true;
            this.btnAddMedico.Click += new System.EventHandler(this.btnAddMedico_Click);
            // 
            // FrmAddMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.btnAddMedico);
            this.Controls.Add(this.txtespMedico);
            this.Controls.Add(this.txtcrmMedico);
            this.Controls.Add(this.txtnomeMedico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.painelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddMedico";
            this.painelTitulo.ResumeLayout(false);
            this.painelTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private FontAwesome.Sharp.IconButton btnFechar;
		private Panel painelTitulo;
		private Label Titulo;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox txtnomeMedico;
        private TextBox txtcrmMedico;
        private TextBox txtespMedico;
        private FontAwesome.Sharp.IconButton btnAddMedico;
    }
}