namespace AgendaMedica
{
	partial class FrmAddPaciente
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
            this.painelTitulo = new System.Windows.Forms.Panel();
            this.Titulo = new System.Windows.Forms.Label();
            this.btnFechar = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnomePaciente = new System.Windows.Forms.TextBox();
            this.txttelPaciente = new System.Windows.Forms.TextBox();
            this.txtendPaciente = new System.Windows.Forms.TextBox();
            this.btnAddPaciente = new FontAwesome.Sharp.IconButton();
            this.txtcpfPaciente = new System.Windows.Forms.MaskedTextBox();
            this.painelTitulo.SuspendLayout();
            this.SuspendLayout();
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
            this.painelTitulo.TabIndex = 3;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.Titulo.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.Titulo.Location = new System.Drawing.Point(230, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(299, 37);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Cadastro de Pacientes";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label3.Location = new System.Drawing.Point(49, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label1.Location = new System.Drawing.Point(49, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label2.Location = new System.Drawing.Point(49, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label4.Location = new System.Drawing.Point(49, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Endereço:";
            // 
            // txtnomePaciente
            // 
            this.txtnomePaciente.Location = new System.Drawing.Point(152, 116);
            this.txtnomePaciente.Name = "txtnomePaciente";
            this.txtnomePaciente.Size = new System.Drawing.Size(411, 23);
            this.txtnomePaciente.TabIndex = 10;
            // 
            // txttelPaciente
            // 
            this.txttelPaciente.Location = new System.Drawing.Point(152, 150);
            this.txttelPaciente.Name = "txttelPaciente";
            this.txttelPaciente.Size = new System.Drawing.Size(411, 23);
            this.txttelPaciente.TabIndex = 11;
            // 
            // txtendPaciente
            // 
            this.txtendPaciente.Location = new System.Drawing.Point(152, 184);
            this.txtendPaciente.Name = "txtendPaciente";
            this.txtendPaciente.Size = new System.Drawing.Size(411, 23);
            this.txtendPaciente.TabIndex = 12;
            // 
            // btnAddPaciente
            // 
            this.btnAddPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPaciente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddPaciente.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnAddPaciente.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddPaciente.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnAddPaciente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPaciente.Location = new System.Drawing.Point(332, 232);
            this.btnAddPaciente.Name = "btnAddPaciente";
            this.btnAddPaciente.Size = new System.Drawing.Size(153, 56);
            this.btnAddPaciente.TabIndex = 13;
            this.btnAddPaciente.Text = "Cadastrar";
            this.btnAddPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPaciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddPaciente.UseVisualStyleBackColor = true;
            this.btnAddPaciente.Click += new System.EventHandler(this.btnAddPaciente_Click);
            // 
            // txtcpfPaciente
            // 
            this.txtcpfPaciente.Location = new System.Drawing.Point(152, 84);
            this.txtcpfPaciente.Mask = "000.000.000-00";
            this.txtcpfPaciente.Name = "txtcpfPaciente";
            this.txtcpfPaciente.Size = new System.Drawing.Size(411, 23);
            this.txtcpfPaciente.TabIndex = 14;
            // 
            // FrmAddPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.txtcpfPaciente);
            this.Controls.Add(this.btnAddPaciente);
            this.Controls.Add(this.txtendPaciente);
            this.Controls.Add(this.txttelPaciente);
            this.Controls.Add(this.txtnomePaciente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.painelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddPaciente";
            this.painelTitulo.ResumeLayout(false);
            this.painelTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Panel painelTitulo;
		private Label Titulo;
		private FontAwesome.Sharp.IconButton btnFechar;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox txtnomePaciente;
        private TextBox txttelPaciente;
        private TextBox txtendPaciente;
        private FontAwesome.Sharp.IconButton btnAddPaciente;
        private MaskedTextBox txtcpfPaciente;
    }
}