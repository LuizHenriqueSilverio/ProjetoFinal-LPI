using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMedica
{
	internal class Consulta
	{
		DateTime datahora;
		string motivo;
		int medicos, clientes;

		public DateTime Datahora { get => datahora; set => datahora = value; }
		public string Motivo { get => motivo; set => motivo = value; }
		public int Medicos { get => medicos; set => medicos = value; }
		public int Pacientes { get => clientes; set => clientes = value; }
	}
}
