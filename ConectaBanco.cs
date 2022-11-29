using System.Data;
using MySqlConnector;

namespace AgendaMedica
{
	internal class ConectaBanco

	{
		MySqlConnection conexao = new MySqlConnection("server=localhost;user id = root;password=;database=psf_luizedaiana");
		public String mensagem;

		public DataTable listaMedicos()
		{
			MySqlCommand cmd = new MySqlCommand("proc_listaMedicos", conexao);
			cmd.CommandType = CommandType.StoredProcedure;
			try
			{
				conexao.Open();
				MySqlDataAdapter da = new MySqlDataAdapter(cmd);
				DataTable tabela = new DataTable();
				da.Fill(tabela);
				return tabela;
			}
			catch (MySqlException e)
			{
				mensagem = "Erro: " + e.Message;
				return null;
			}
			finally
			{
				conexao.Close();
			}
		}// fim lista_medicos

		public DataTable listaPacientes()
		{
			MySqlCommand cmd = new MySqlCommand("proc_listaPacientes", conexao);
			cmd.CommandType = CommandType.StoredProcedure;
			try
			{
				conexao.Open();
				MySqlDataAdapter da = new MySqlDataAdapter(cmd);
				DataTable tabela = new DataTable();
				da.Fill(tabela);
				return tabela;
			}
			catch (MySqlException e)
			{
				mensagem = "Erro: " + e.Message;
				return null;
			}
			finally
			{
				conexao.Close();
			}
		}// fim lista_pacientes
	}
}
