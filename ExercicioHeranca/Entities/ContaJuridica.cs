using ExercicioHeranca.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHeranca.Entities
{
    internal class ContaJuridica : Conta
    {
        public int NumFuncionarios { get; set; }

        public ContaJuridica(string name, double rendaAnual, int numFuncionarios) : base(name, rendaAnual)
        {
            NumFuncionarios = numFuncionarios;
        }

        public override double Imposto()
        {
            double imposto;

            if (NumFuncionarios > 10)
            {
                imposto = RendaAnual / 100 * 14;
            }
            else
            {
                imposto = RendaAnual / 100 * 16;
            }
            return imposto;
        }
    }
}
