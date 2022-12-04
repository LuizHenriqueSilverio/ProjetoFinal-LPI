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

		public bool insereMedico(Medico m)
		{
			MySqlCommand cmd = new MySqlCommand("proc_insereMedico", conexao);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("nomemed", m.Nome);
			cmd.Parameters.AddWithValue("crmmed", m.Crm);
			cmd.Parameters.AddWithValue("espmed", m.Especialidade);
			try
			{
				conexao.Open();
				cmd.ExecuteNonQuery();
				return true;
			}
			catch (MySqlException e)
			{
				mensagem = "Erro: " + e.Message;
				return false;
			}
			finally
			{
				conexao.Close();
			}
		}

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

		public bool inserePaciente(Paciente p)
		{
			MySqlCommand cmd = new MySqlCommand("proc_inserePaciente", conexao);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("cpfpaciente", p.Cpf);
			cmd.Parameters.AddWithValue("nomepaciente", p.Nome);
			cmd.Parameters.AddWithValue("telefone", p.Telefone);
			cmd.Parameters.AddWithValue("endereco", p.Endereco);
			try
			{
				conexao.Open();
				cmd.ExecuteNonQuery();
				return true;
			}
			catch (MySqlException e)
			{
				mensagem = "Erro: " + e.Message;
				return false;
			}
			finally
			{
				conexao.Close();
			}
		}

		public DataTable listaConsultas()
		{
			MySqlCommand cmd = new MySqlCommand("proc_listaConsultas", conexao);
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
		}// fim lista_consultas

		public bool insereConsulta(Consulta c)
		{
			MySqlCommand cmd = new MySqlCommand("proc_insereConsulta", conexao);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("datahora", c.Datahora.ToString("yyyy-MM-dd HH:mm:ss"));
			cmd.Parameters.AddWithValue("motivo", c.Motivo);
			cmd.Parameters.AddWithValue("medicos_codmedicos", c.Medicos);
			cmd.Parameters.AddWithValue("paciente_codpacientes", c.Pacientes);
			try
			{
				conexao.Open();
				cmd.ExecuteNonQuery();
				return true;
			}
			catch (MySqlException e)
			{
				mensagem = "Erro: " + e.Message;
				return false;
			}
			finally
			{
				conexao.Close();
			}// fim insere_consultas
		}

		public bool deletaConsulta(int codConsulta)
		{
			MySqlCommand cmd = new MySqlCommand("proc_deletaConsulta", conexao);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("codcons", codConsulta);
			try
			{
				conexao.Open();
				cmd.ExecuteNonQuery(); // executa o comando
				return true;
			}
			catch (MySqlException e)
			{
				mensagem = "Erro:" + e.Message;
				return false;
			}
			finally
			{
				conexao.Close();
			}
		}// fim deleta_consulta

		public bool alteraConsulta(Consulta c, int codcons)
		{
			MySqlCommand cmd = new MySqlCommand("proc_alteraConsulta", conexao);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("codcons", codcons);
			cmd.Parameters.AddWithValue("datahora", c.Datahora.ToString("yyyy-MM-dd HH:mm:ss"));
			cmd.Parameters.AddWithValue("motivo", c.Motivo);
			cmd.Parameters.AddWithValue("pacientes_codpacientes", c.Pacientes);
			cmd.Parameters.AddWithValue("medicos_codmedicos", c.Medicos);
			try
			{
				conexao.Open();
				cmd.ExecuteNonQuery();
				return true;
			}
			catch (MySqlException e)
			{
				mensagem = "Erro: " + e.Message;
				return false;
			}
			finally
			{
				conexao.Close();
			}// fim altera_consulta
		}


	}
}
