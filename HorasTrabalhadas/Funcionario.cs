using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorasTrabalhadas
{
    public class Funcionario
    {
        public string Nome { get; set; } = string.Empty;
        public int Cpf { get; set; } 
        public int ValorHora { get; set; }
        public int Horas { get; set; }
        public double Salario { get; private set; }
        public void CalculaSalario()
        {
            Salario = ValorHora * Horas;
        }
        public static string FormatCPF(string Cpf)
        {
            return Convert.ToUInt64(Cpf).ToString(@"000\.000\.000\-00");
        }

    }
}
