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
	public partial class FrmLogin : Form
	{
		public FrmLogin()
		{
			InitializeComponent();
		}

		private void btnFechar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			ConectaBanco conecta = new ConectaBanco();
			if(conecta.verificaLogin(txtuserlogin.Text, txtsenhalogin.Text) == true)
			{
				formPrincipal sistema = new formPrincipal();
				this.Hide();
				sistema.ShowDialog();
				this.Close();
			}
			else
			{
				MessageBox.Show("Senha e/ou usuário incorretos!");
			}
		}
	}
}
