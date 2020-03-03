using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FuncionarioApp
{
    public class Funcionario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public enum Sexo { MASCULINO, FEMININO };
        public int PIS { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }
        public string Email { get; set; }
        public DateTime DataAdmissao { get; set; }
    }
}
