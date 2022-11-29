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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.painelMenu = new System.Windows.Forms.Panel();
            this.btn_Listar = new FontAwesome.Sharp.IconButton();
            this.btn_Cadastrar = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Icone = new FontAwesome.Sharp.IconPictureBox();
            this.painelTitulo = new System.Windows.Forms.Panel();
            this.Titulo = new System.Windows.Forms.Label();
            this.painelPrincipal = new System.Windows.Forms.TabControl();
            this.tabCadastrar = new System.Windows.Forms.TabPage();
            this.btnConfirmaCadastro = new FontAwesome.Sharp.IconButton();
            this.txtmotivo = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddPaciente = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPaciente = new System.Windows.Forms.ComboBox();
            this.btnAddMedicos = new FontAwesome.Sharp.IconButton();
            this.cbMedico = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdatahora = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabListar = new System.Windows.Forms.TabPage();
            this.btnAlterar = new FontAwesome.Sharp.IconButton();
            this.btnExcluir = new FontAwesome.Sharp.IconButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgConsultas = new System.Windows.Forms.DataGridView();
            this.tabAlterar = new System.Windows.Forms.TabPage();
            this.lblmsgerro = new System.Windows.Forms.Label();
            this.painelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Icone)).BeginInit();
            this.painelTitulo.SuspendLayout();
            this.painelPrincipal.SuspendLayout();
            this.tabCadastrar.SuspendLayout();
            this.tabListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // painelMenu
            // 
            this.painelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(58)))));
            this.painelMenu.Controls.Add(this.btn_Listar);
            this.painelMenu.Controls.Add(this.btn_Cadastrar);
            this.painelMenu.Controls.Add(this.panel2);
            this.painelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.painelMenu.Location = new System.Drawing.Point(0, 0);
            this.painelMenu.Name = "painelMenu";
            this.painelMenu.Size = new System.Drawing.Size(220, 592);
            this.painelMenu.TabIndex = 0;
            // 
            // btn_Listar
            // 
            this.btn_Listar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Listar.FlatAppearance.BorderSize = 0;
            this.btn_Listar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Listar.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Listar.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.btn_Listar.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Listar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Listar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Listar.Location = new System.Drawing.Point(0, 200);
            this.btn_Listar.Name = "btn_Listar";
            this.btn_Listar.Size = new System.Drawing.Size(220, 60);
            this.btn_Listar.TabIndex = 2;
            this.btn_Listar.Text = "Listar";
            this.btn_Listar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Listar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Listar.UseVisualStyleBackColor = true;
            this.btn_Listar.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Cadastrar.FlatAppearance.BorderSize = 0;
            this.btn_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cadastrar.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Cadastrar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btn_Cadastrar.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Cadastrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cadastrar.Location = new System.Drawing.Point(0, 140);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(220, 60);
            this.btn_Cadastrar.TabIndex = 1;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_Icone);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 140);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label1.Location = new System.Drawing.Point(40, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "AGENDA MÉDICA";
            // 
            // btn_Icone
            // 
            this.btn_Icone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(58)))));
            this.btn_Icone.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Icone.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus;
            this.btn_Icone.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Icone.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Icone.IconSize = 99;
            this.btn_Icone.Location = new System.Drawing.Point(3, 3);
            this.btn_Icone.Name = "btn_Icone";
            this.btn_Icone.Size = new System.Drawing.Size(217, 99);
            this.btn_Icone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Icone.TabIndex = 1;
            this.btn_Icone.TabStop = false;
            this.btn_Icone.Click += new System.EventHandler(this.btn_Icone_Click);
            // 
            // painelTitulo
            // 
            this.painelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.painelTitulo.Controls.Add(this.Titulo);
            this.painelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelTitulo.Location = new System.Drawing.Point(220, 0);
            this.painelTitulo.Name = "painelTitulo";
            this.painelTitulo.Size = new System.Drawing.Size(753, 75);
            this.painelTitulo.TabIndex = 1;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.Titulo.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.Titulo.Location = new System.Drawing.Point(233, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(295, 37);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Registro de Consultas";
            // 
            // painelPrincipal
            // 
            this.painelPrincipal.Controls.Add(this.tabCadastrar);
            this.painelPrincipal.Controls.Add(this.tabListar);
            this.painelPrincipal.Controls.Add(this.tabAlterar);
            this.painelPrincipal.Location = new System.Drawing.Point(220, 140);
            this.painelPrincipal.Name = "painelPrincipal";
            this.painelPrincipal.SelectedIndex = 0;
            this.painelPrincipal.Size = new System.Drawing.Size(753, 449);
            this.painelPrincipal.TabIndex = 2;
            // 
            // tabCadastrar
            // 
            this.tabCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.tabCadastrar.Controls.Add(this.btnConfirmaCadastro);
            this.tabCadastrar.Controls.Add(this.txtmotivo);
            this.tabCadastrar.Controls.Add(this.label5);
            this.tabCadastrar.Controls.Add(this.btnAddPaciente);
            this.tabCadastrar.Controls.Add(this.label4);
            this.tabCadastrar.Controls.Add(this.cbPaciente);
            this.tabCadastrar.Controls.Add(this.btnAddMedicos);
            this.tabCadastrar.Controls.Add(this.cbMedico);
            this.tabCadastrar.Controls.Add(this.label3);
            this.tabCadastrar.Controls.Add(this.txtdatahora);
            this.tabCadastrar.Controls.Add(this.label2);
            this.tabCadastrar.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.tabCadastrar.Location = new System.Drawing.Point(4, 24);
            this.tabCadastrar.Name = "tabCadastrar";
            this.tabCadastrar.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastrar.Size = new System.Drawing.Size(745, 421);
            this.tabCadastrar.TabIndex = 0;
            this.tabCadastrar.Text = "Cadastrar";
            // 
            // btnConfirmaCadastro
            // 
            this.btnConfirmaCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmaCadastro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmaCadastro.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnConfirmaCadastro.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnConfirmaCadastro.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnConfirmaCadastro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfirmaCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmaCadastro.Location = new System.Drawing.Point(293, 331);
            this.btnConfirmaCadastro.Name = "btnConfirmaCadastro";
            this.btnConfirmaCadastro.Size = new System.Drawing.Size(153, 56);
            this.btnConfirmaCadastro.TabIndex = 11;
            this.btnConfirmaCadastro.Text = "Cadastrar";
            this.btnConfirmaCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmaCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmaCadastro.UseVisualStyleBackColor = true;
            this.btnConfirmaCadastro.Click += new System.EventHandler(this.btnConfirmaCadastro_Click);
            // 
            // txtmotivo
            // 
            this.txtmotivo.Location = new System.Drawing.Point(177, 182);
            this.txtmotivo.Name = "txtmotivo";
            this.txtmotivo.Size = new System.Drawing.Size(493, 82);
            this.txtmotivo.TabIndex = 10;
            this.txtmotivo.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(57, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Motivo:";
            // 
            // btnAddPaciente
            // 
            this.btnAddPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnAddPaciente.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddPaciente.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnAddPaciente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddPaciente.Location = new System.Drawing.Point(631, 132);
            this.btnAddPaciente.Name = "btnAddPaciente";
            this.btnAddPaciente.Size = new System.Drawing.Size(39, 35);
            this.btnAddPaciente.TabIndex = 8;
            this.btnAddPaciente.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(57, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Paciente:";
            // 
            // cbPaciente
            // 
            this.cbPaciente.FormattingEnabled = true;
            this.cbPaciente.Location = new System.Drawing.Point(177, 139);
            this.cbPaciente.Name = "cbPaciente";
            this.cbPaciente.Size = new System.Drawing.Size(426, 23);
            this.cbPaciente.TabIndex = 6;
            // 
            // btnAddMedicos
            // 
            this.btnAddMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMedicos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnAddMedicos.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddMedicos.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnAddMedicos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddMedicos.Location = new System.Drawing.Point(631, 82);
            this.btnAddMedicos.Name = "btnAddMedicos";
            this.btnAddMedicos.Size = new System.Drawing.Size(39, 35);
            this.btnAddMedicos.TabIndex = 5;
            this.btnAddMedicos.UseVisualStyleBackColor = true;
            // 
            // cbMedico
            // 
            this.cbMedico.FormattingEnabled = true;
            this.cbMedico.Location = new System.Drawing.Point(177, 89);
            this.cbMedico.Name = "cbMedico";
            this.cbMedico.Size = new System.Drawing.Size(426, 23);
            this.cbMedico.TabIndex = 4;
            this.cbMedico.SelectedIndexChanged += new System.EventHandler(this.cbMedico_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(57, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Médico:";
            // 
            // txtdatahora
            // 
            this.txtdatahora.Location = new System.Drawing.Point(177, 41);
            this.txtdatahora.Name = "txtdatahora";
            this.txtdatahora.Size = new System.Drawing.Size(426, 23);
            this.txtdatahora.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(57, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data e Hora:";
            // 
            // tabListar
            // 
            this.tabListar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.tabListar.Controls.Add(this.btnAlterar);
            this.tabListar.Controls.Add(this.btnExcluir);
            this.tabListar.Controls.Add(this.txtBuscar);
            this.tabListar.Controls.Add(this.label6);
            this.tabListar.Controls.Add(this.dgConsultas);
            this.tabListar.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.tabListar.Location = new System.Drawing.Point(4, 24);
            this.tabListar.Name = "tabListar";
            this.tabListar.Padding = new System.Windows.Forms.Padding(3);
            this.tabListar.Size = new System.Drawing.Size(745, 421);
            this.tabListar.TabIndex = 1;
            this.tabListar.Text = "Listar";
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnAlterar.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btnAlterar.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnAlterar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(574, 13);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(114, 65);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnExcluir.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            this.btnExcluir.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnExcluir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(424, 13);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(114, 65);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(92, 35);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(292, 23);
            this.txtBuscar.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(34, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Buscar:";
            // 
            // dgConsultas
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgConsultas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgConsultas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.dgConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgConsultas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgConsultas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.dgConsultas.Location = new System.Drawing.Point(6, 108);
            this.dgConsultas.Name = "dgConsultas";
            this.dgConsultas.ReadOnly = true;
            this.dgConsultas.RowTemplate.Height = 25;
            this.dgConsultas.Size = new System.Drawing.Size(733, 245);
            this.dgConsultas.TabIndex = 0;
            // 
            // tabAlterar
            // 
            this.tabAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.tabAlterar.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.tabAlterar.Location = new System.Drawing.Point(4, 24);
            this.tabAlterar.Name = "tabAlterar";
            this.tabAlterar.Size = new System.Drawing.Size(745, 421);
            this.tabAlterar.TabIndex = 2;
            this.tabAlterar.Text = "Alterar";
            this.tabAlterar.Click += new System.EventHandler(this.tabAlterar_Click);
            // 
            // lblmsgerro
            // 
            this.lblmsgerro.AutoSize = true;
            this.lblmsgerro.ForeColor = System.Drawing.Color.White;
            this.lblmsgerro.Location = new System.Drawing.Point(272, 87);
            this.lblmsgerro.Name = "lblmsgerro";
            this.lblmsgerro.Size = new System.Drawing.Size(38, 15);
            this.lblmsgerro.TabIndex = 3;
            this.lblmsgerro.Text = "label7";
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(973, 592);
            this.Controls.Add(this.lblmsgerro);
            this.Controls.Add(this.painelPrincipal);
            this.Controls.Add(this.painelTitulo);
            this.Controls.Add(this.painelMenu);
            this.Name = "formPrincipal";
            this.Text = "Agenda Médica";
            this.Load += new System.EventHandler(this.formPrincipal_Load);
            this.painelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Icone)).EndInit();
            this.painelTitulo.ResumeLayout(false);
            this.painelTitulo.PerformLayout();
            this.painelPrincipal.ResumeLayout(false);
            this.tabCadastrar.ResumeLayout(false);
            this.tabCadastrar.PerformLayout();
            this.tabListar.ResumeLayout(false);
            this.tabListar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Panel painelMenu;
		private FontAwesome.Sharp.IconButton btn_Listar;
		private FontAwesome.Sharp.IconButton btn_Cadastrar;
		private Panel panel2;
		private FontAwesome.Sharp.IconPictureBox btn_Icone;
		private Panel painelTitulo;
        private Label label1;
        private TabControl painelPrincipal;
        private TabPage tabCadastrar;
        private TabPage tabListar;
        private TabPage tabAlterar;
        private Label Titulo;
        private Label label2;
        private ComboBox cbPaciente;
        private FontAwesome.Sharp.IconButton btnAddMedicos;
        private ComboBox cbMedico;
        private Label label3;
        private TextBox txtdatahora;
        private Label label4;
        private RichTextBox txtmotivo;
        private Label label5;
        private FontAwesome.Sharp.IconButton btnAddPaciente;
        private FontAwesome.Sharp.IconButton btnConfirmaCadastro;
        private FontAwesome.Sharp.IconButton btnAlterar;
        private FontAwesome.Sharp.IconButton btnExcluir;
        private TextBox txtBuscar;
        private Label label6;
        private DataGridView dgConsultas;
		private Label lblmsgerro;
	}
}
