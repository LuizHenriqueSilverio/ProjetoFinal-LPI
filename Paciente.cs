using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMedica
{
	internal class Paciente
	{
		string cpf, nome, telefone, endereco;

		public string Cpf { get => cpf; set => cpf = value; }
		public string Nome { get => nome; set => nome = value; }
		public string Telefone { get => telefone; set => telefone = value; }
		public string Endereco { get => endereco; set => endereco = value; }
	}
}
