using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMedica
{
	internal class Medico
	{
		string nome, crm, especialidade;

		public string Nome { get => nome; set => nome = value; }
		public string Crm { get => crm; set => crm = value; }
		public string Especialidade { get => especialidade; set => especialidade = value; }
	}
}
