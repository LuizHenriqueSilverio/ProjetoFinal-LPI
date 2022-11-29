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
			//lblmsgerro.Text = con.mensagem;
			cbPaciente.Text = "";
		}

		private void listaConsulta()
		{
			ConectaBanco con = new ConectaBanco();
			dgConsultas.DataSource = con.listaConsultas();
			lblmsgerro.Text = con.mensagem;
		}

		private void formPrincipal_Load(object sender, EventArgs e)
		{
			listaMedico();
			listaPaciente();
			listaConsulta();
		}

		private void iconButton1_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, color);
			painelPrincipal.SelectedTab = painelPrincipal.TabPages[0];
		}

		private void iconButton2_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, color);
			painelPrincipal.SelectedTab = painelPrincipal.TabPages[1];
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
			c.Datahora = Convert.ToDateTime(txtdatahora.Text);
			c.Motivo = txtmotivo.Text;
			c.Medicos = Convert.ToInt32(cbMedico.SelectedValue.ToString());
			c.Clientes = Convert.ToInt32(cbPaciente.SelectedValue.ToString());

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
		}
	}
}
