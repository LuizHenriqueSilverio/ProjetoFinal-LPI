using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Drawing;
using MySqlConnector;
using System.Data;

namespace AgendaMedica
{
	public partial class formPrincipal : Form
	{

		private IconButton currentBtn;
		private Panel leftBorderBtn;
		public int idalterar;

		public formPrincipal()
		{
			InitializeComponent();
			leftBorderBtn = new Panel();
			leftBorderBtn.Size = new Size(7, 60);
			painelMenu.Controls.Add(leftBorderBtn);
		}

		public static Color color = Color.FromArgb(253, 138, 114);

		private void ActivateButton(object senderBtn, Color color)
		{
			if(senderBtn != null)
			{
				DisableButton();
				currentBtn = (IconButton)senderBtn;
				currentBtn.BackColor = Color.FromArgb(37, 36, 81);
				currentBtn.ForeColor = color;
				currentBtn.TextAlign = ContentAlignment.MiddleCenter;
				currentBtn.IconColor = color;
				currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
				currentBtn.ImageAlign = ContentAlignment.MiddleRight;
				// Left border button
				leftBorderBtn.BackColor = color;
				leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
				leftBorderBtn.Visible = true;
				leftBorderBtn.BringToFront();
			}
		}

		private void DisableButton()
		{
			if(currentBtn != null)
			{
				currentBtn.BackColor = Color.FromArgb(31, 30, 58);
				currentBtn.ForeColor = Color.BlanchedAlmond;
				currentBtn.TextAlign = ContentAlignment.MiddleLeft;
				currentBtn.IconColor = Color.BlanchedAlmond;
				currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
				currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
			}
		}

		private void listaMedico()
		{
			ConectaBanco con = new ConectaBanco(); // instancia o ConectaBanco
			DataTable tabelaDados = new DataTable(); // instancia uma tabela virtual, que vai receber a tabela virtual de outra função
			tabelaDados = con.listaMedicos();
			cbMedico.DataSource = tabelaDados; // especifica a fonte de dados
			cbMedico.DisplayMember = "nome"; // texto que será mostrado
			cbMedico.ValueMember = "codMedicos"; // qual valor que será guardado quando selecionado
			cbAlteramedico.DataSource = tabelaDados; // especifica a fonte de dados
			cbAlteramedico.DisplayMember = "nome"; // texto que será mostrado
			cbAlteramedico.ValueMember = "codMedicos"; // qual valor que será guardado quando selecionado
												 //lblmsgerro.Text = con.mensagem;
			cbMedico.Text = "";
		}

		private void listaPaciente()
		{
			ConectaBanco con = new ConectaBanco(); // instancia o ConectaBanco
			DataTable tabelaDados = new DataTable(); // instancia uma tabela virtual, que vai receber a tabela virtual de outra função
			tabelaDados = con.listaPacientes();
			cbPaciente.DataSource = tabelaDados; // especifica a fonte de dados
			cbPaciente.DisplayMember = "nome"; // texto que será mostrado
			cbPaciente.ValueMember = "codPacientes"; // qual valor que será guardado quando selecionado
			cbAlterapaciente.DataSource = tabelaDados; // especifica a fonte de dados
			cbAlterapaciente.DisplayMember = "nome"; // texto que será mostrado
			cbAlterapaciente.ValueMember = "codPacientes"; // qual valor que será guardado quando selecionado
													 //lblmsgerro.Text = con.mensagem;
			cbPaciente.Text = "";
		}

		private void listaConsulta()
		{
			ConectaBanco con = new ConectaBanco();
			dgConsultas.DataSource = con.listaConsultas();
			lblmsgerro.Text = con.mensagem;
		}

		private void limpaCampos()
		{
			txtdatahora.Text = "";
			cbMedico.Text = "";
			cbPaciente.Text = "";
			txtmotivo.Text = "";
			txtalteradata.Text = "";
			cbAlteramedico.Text = "";
			cbAlterapaciente.Text = "";
			txtmotivo.Text = "";
		}

		private void formPrincipal_Load(object sender, EventArgs e)
		{
			listaMedico();
			listaPaciente();
			listaConsulta();
			limpaCampos();
			this.painelPrincipal.Appearance = TabAppearance.FlatButtons;
			this.painelPrincipal.ItemSize = new System.Drawing.Size(0, 1);
			this.painelPrincipal.SizeMode = TabSizeMode.Fixed;
		}

		private void iconButton1_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, color);
			painelPrincipal.SelectedTab = tabCadastrar;
		}

		private void iconButton2_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, color);
			painelPrincipal.SelectedTab = tabListar;
		}

		private void iconButton3_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, color);
		}

		private void Reset()
		{
			DisableButton();
			leftBorderBtn.Visible = false;
		}

		private void btn_Icone_Click(object sender, EventArgs e)
		{
			Reset();
			painelPrincipal.SelectedTab = tabHome;
		}

		private void tabAlterar_Click(object sender, EventArgs e)
		{

		}

		private void cbMedico_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnSair_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnConfirmaCadastro_Click(object sender, EventArgs e)
		{
			Consulta c = new Consulta();
			c.Datahora = txtdatahora.Value;
			c.Motivo = txtmotivo.Text;
			c.Medicos = Convert.ToInt32(cbMedico.SelectedValue.ToString());
			c.Pacientes = Convert.ToInt32(cbPaciente.SelectedValue.ToString());

			ConectaBanco conecta = new ConectaBanco();
			bool retorno = conecta.insereConsulta(c);
			if (retorno)
			{
				MessageBox.Show("Dados inseridos com sucesso!");

			}
			else
			{
				MessageBox.Show(conecta.mensagem);
			}
			listaConsulta();
			limpaCampos(); 
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			int linha = dgConsultas.CurrentRow.Index;
			int idRemover = Convert.ToInt32(dgConsultas.Rows[linha].Cells["código"].Value.ToString());
			DialogResult resp = MessageBox.Show("Confirma exclusão?", "Remove consulta", MessageBoxButtons.OKCancel);
			if (resp == DialogResult.OK)
			{
				ConectaBanco conecta = new ConectaBanco();
				bool retorno = conecta.deletaConsulta(idRemover);
				if (retorno)
				{
					MessageBox.Show("Consulta excluída!");
				}
				else
				{
					MessageBox.Show(conecta.mensagem);
				}
			}
			else
			{
				MessageBox.Show("Operação cancelada!");
			}
			listaConsulta();
		}

		private void btnAlterar_Click(object sender, EventArgs e)
		{
			int linha = dgConsultas.CurrentRow.Index;
			idalterar = Convert.ToInt32(dgConsultas.Rows[linha].Cells["código"].Value.ToString());
			txtalteradata.Text = dgConsultas.Rows[linha].Cells["data e hora"].Value.ToString();
			cbAlteramedico.Text = dgConsultas.Rows[linha].Cells["nome do médico"].Value.ToString();
			cbAlterapaciente.Text = dgConsultas.Rows[linha].Cells["nome do paciente"].Value.ToString();
			txtalteramotivo.Text = dgConsultas.Rows[linha].Cells["motivo"].Value.ToString();

			painelPrincipal.SelectedTab = tabAlterar;
		}

		private void btnConfirmaAlteracao_Click(object sender, EventArgs e)
		{
			Consulta c = new Consulta();
			c.Datahora = txtalteradata.Value;
			c.Medicos = Convert.ToInt32(cbAlteramedico.SelectedValue.ToString());
			c.Pacientes = Convert.ToInt32(cbAlterapaciente.SelectedValue.ToString());
			c.Motivo = txtalteramotivo.Text;

			ConectaBanco conecta = new ConectaBanco();
			bool retorno = conecta.alteraConsulta(c, idalterar);
			if (retorno)
			{
				MessageBox.Show("Dados alterados com sucesso!");
			}
			else
			{
				lblmsgerro.Text = conecta.mensagem;
			}
			listaConsulta();
			limpaCampos();
			painelPrincipal.SelectedTab = tabListar;
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void btnAddMedicos_Click(object sender, EventArgs e)
		{
			FrmAddMedico frmAddMedico = new FrmAddMedico();
			this.Hide();
			frmAddMedico.ShowDialog();
			this.Close();
		}

		private void btnFechar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnAddPaciente_Click(object sender, EventArgs e)
		{
			FrmAddPaciente frmAddPaciente = new FrmAddPaciente();
			this.Hide();
			frmAddPaciente.ShowDialog();
			this.Close();
		}
	}
}
