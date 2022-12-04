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
	public partial class FrmAddMedico : Form
	{
		public FrmAddMedico()
		{
			InitializeComponent();
		}

		private void limpaCamposMed()
		{
			txtnomeMedico.Text = "";
			txtcrmMedico.Text = "";
			txtespMedico.Text = "";
		}

		private void btnFechar_Click(object sender, EventArgs e)
		{
			formPrincipal formPrincipal = new formPrincipal();
			this.Hide();
			formPrincipal.ShowDialog();
			this.Close();
		}

		private void btnAddMedico_Click(object sender, EventArgs e)
		{
			Medico m = new Medico();
			m.Nome = txtnomeMedico.Text;
			m.Crm = txtcrmMedico.Text;
			m.Especialidade = txtespMedico.Text;

			ConectaBanco conecta = new ConectaBanco();
			bool retorno = conecta.insereMedico(m);
			if (retorno)
			{
				MessageBox.Show("Dados inseridos com sucesso!");
				limpaCamposMed();
			}
			else
			{
				MessageBox.Show(conecta.mensagem);
			}
		}
	}
}
