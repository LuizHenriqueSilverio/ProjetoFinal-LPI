namespace AgendaMedica
{
	partial class formPrincipal
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
            this.painelMenu = new System.Windows.Forms.Panel();
            this.btn_Consultas = new FontAwesome.Sharp.IconButton();
            this.btn_Pacientes = new FontAwesome.Sharp.IconButton();
            this.btn_Medicos = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Icone = new FontAwesome.Sharp.IconPictureBox();
            this.painelTitulo = new System.Windows.Forms.Panel();
            this.painelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Icone)).BeginInit();
            this.SuspendLayout();
            // 
            // painelMenu
            // 
            this.painelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(58)))));
            this.painelMenu.Controls.Add(this.btn_Consultas);
            this.painelMenu.Controls.Add(this.btn_Pacientes);
            this.painelMenu.Controls.Add(this.btn_Medicos);
            this.painelMenu.Controls.Add(this.panel2);
            this.painelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.painelMenu.Location = new System.Drawing.Point(0, 0);
            this.painelMenu.Name = "painelMenu";
            this.painelMenu.Size = new System.Drawing.Size(220, 592);
            this.painelMenu.TabIndex = 0;
            // 
            // btn_Consultas
            // 
            this.btn_Consultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Consultas.FlatAppearance.BorderSize = 0;
            this.btn_Consultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Consultas.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Consultas.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.btn_Consultas.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Consultas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Consultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Consultas.Location = new System.Drawing.Point(0, 260);
            this.btn_Consultas.Name = "btn_Consultas";
            this.btn_Consultas.Size = new System.Drawing.Size(220, 60);
            this.btn_Consultas.TabIndex = 3;
            this.btn_Consultas.Text = "Consultas";
            this.btn_Consultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Consultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Consultas.UseVisualStyleBackColor = true;
            this.btn_Consultas.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // btn_Pacientes
            // 
            this.btn_Pacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Pacientes.FlatAppearance.BorderSize = 0;
            this.btn_Pacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pacientes.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Pacientes.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btn_Pacientes.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Pacientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Pacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Pacientes.Location = new System.Drawing.Point(0, 200);
            this.btn_Pacientes.Name = "btn_Pacientes";
            this.btn_Pacientes.Size = new System.Drawing.Size(220, 60);
            this.btn_Pacientes.TabIndex = 2;
            this.btn_Pacientes.Text = "Pacientes";
            this.btn_Pacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Pacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Pacientes.UseVisualStyleBackColor = true;
            this.btn_Pacientes.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btn_Medicos
            // 
            this.btn_Medicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Medicos.FlatAppearance.BorderSize = 0;
            this.btn_Medicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Medicos.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Medicos.IconChar = FontAwesome.Sharp.IconChar.UserDoctor;
            this.btn_Medicos.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Medicos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Medicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Medicos.Location = new System.Drawing.Point(0, 140);
            this.btn_Medicos.Name = "btn_Medicos";
            this.btn_Medicos.Size = new System.Drawing.Size(220, 60);
            this.btn_Medicos.TabIndex = 1;
            this.btn_Medicos.Text = "Médicos";
            this.btn_Medicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Medicos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Medicos.UseVisualStyleBackColor = true;
            this.btn_Medicos.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Icone);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 140);
            this.panel2.TabIndex = 1;
            // 
            // btn_Icone
            // 
            this.btn_Icone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(58)))));
            this.btn_Icone.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Icone.IconChar = FontAwesome.Sharp.IconChar.SuitcaseMedical;
            this.btn_Icone.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Icone.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Icone.IconSize = 122;
            this.btn_Icone.Location = new System.Drawing.Point(0, 12);
            this.btn_Icone.Name = "btn_Icone";
            this.btn_Icone.Size = new System.Drawing.Size(217, 122);
            this.btn_Icone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Icone.TabIndex = 1;
            this.btn_Icone.TabStop = false;
            this.btn_Icone.Click += new System.EventHandler(this.btn_Icone_Click);
            // 
            // painelTitulo
            // 
            this.painelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.painelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelTitulo.Location = new System.Drawing.Point(220, 0);
            this.painelTitulo.Name = "painelTitulo";
            this.painelTitulo.Size = new System.Drawing.Size(676, 75);
            this.painelTitulo.TabIndex = 1;
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 592);
            this.Controls.Add(this.painelTitulo);
            this.Controls.Add(this.painelMenu);
            this.Name = "formPrincipal";
            this.Text = "Agenda Médica";
            this.Load += new System.EventHandler(this.formPrincipal_Load);
            this.painelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Icone)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private Panel painelMenu;
		private FontAwesome.Sharp.IconButton btn_Consultas;
		private FontAwesome.Sharp.IconButton btn_Pacientes;
		private FontAwesome.Sharp.IconButton btn_Medicos;
		private Panel panel2;
		private FontAwesome.Sharp.IconPictureBox btn_Icone;
		private Panel painelTitulo;
	}
}
