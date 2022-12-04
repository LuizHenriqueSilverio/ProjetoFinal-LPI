using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaMedica
{
	public partial class FrmAddPaciente : Form
	{
		public FrmAddPaciente()
		{
			InitializeComponent();
		}

		private void limpaCamposPac()
		{
			txtcpfPaciente.Text = "";
			txtnomePaciente.Text = "";
			txttelPaciente.Text = "";
			txtendPaciente.Text = "";
		}

		private void btnFechar_Click(object sender, EventArgs e)
		{
			formPrincipal formPrincipal = new formPrincipal();
			this.Hide();
			formPrincipal.ShowDialog();
			this.Close();
		}

		private void btnAddPaciente_Click(object sender, EventArgs e)
		{
			Paciente p = new Paciente();
			p.Cpf = txtcpfPaciente.Text;
			p.Nome = txtnomePaciente.Text;
			p.Telefone = txttelPaciente.Text;
			p.Endereco = txtendPaciente.Text;

			ConectaBanco conecta = new ConectaBanco();
			bool retorno = conecta.inserePaciente(p);
			if (retorno)
			{
				MessageBox.Show("Dados inseridos com sucesso!");
				limpaCamposPac();
			}
			else
			{
				MessageBox.Show(conecta.mensagem);
			}
		}
	}
}
