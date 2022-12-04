namespace AgendaMedica
{
	partial class FrmLogin
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
            this.txtuserlogin = new System.Windows.Forms.TextBox();
            this.txtsenhalogin = new System.Windows.Forms.TextBox();
            this.btn_Icone = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Icone)).BeginInit();
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
            this.btnFechar.Location = new System.Drawing.Point(462, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(39, 37);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtuserlogin
            // 
            this.txtuserlogin.Location = new System.Drawing.Point(125, 205);
            this.txtuserlogin.Name = "txtuserlogin";
            this.txtuserlogin.Size = new System.Drawing.Size(255, 23);
            this.txtuserlogin.TabIndex = 3;
            // 
            // txtsenhalogin
            // 
            this.txtsenhalogin.Location = new System.Drawing.Point(125, 295);
            this.txtsenhalogin.Name = "txtsenhalogin";
            this.txtsenhalogin.PasswordChar = '*';
            this.txtsenhalogin.Size = new System.Drawing.Size(255, 23);
            this.txtsenhalogin.TabIndex = 4;
            // 
            // btn_Icone
            // 
            this.btn_Icone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btn_Icone.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus;
            this.btn_Icone.IconColor = System.Drawing.Color.White;
            this.btn_Icone.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Icone.IconSize = 99;
            this.btn_Icone.Location = new System.Drawing.Point(125, 12);
            this.btn_Icone.Name = "btn_Icone";
            this.btn_Icone.Size = new System.Drawing.Size(255, 99);
            this.btn_Icone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Icone.TabIndex = 5;
            this.btn_Icone.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label1.Location = new System.Drawing.Point(125, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "AGENDA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label2.Location = new System.Drawing.Point(308, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "MÉDICA";
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            this.btnLogin.IconColor = System.Drawing.Color.White;
            this.btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(172, 368);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(153, 56);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label3.Location = new System.Drawing.Point(38, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "USUÁRIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label4.Location = new System.Drawing.Point(55, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "SENHA";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(510, 455);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Icone);
            this.Controls.Add(this.txtsenhalogin);
            this.Controls.Add(this.txtuserlogin);
            this.Controls.Add(this.btnFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.btn_Icone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private FontAwesome.Sharp.IconButton btnFechar;
		private TextBox txtuserlogin;
		private TextBox txtsenhalogin;
        private FontAwesome.Sharp.IconPictureBox btn_Icone;
        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnLogin;
        private Label label3;
        private Label label4;
    }
}