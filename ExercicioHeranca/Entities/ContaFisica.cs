using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHeranca.Entities
{
    internal class ContaFisica : Conta
    {
        public double GastSaude { get; set; }

        public ContaFisica(string name, double rendaAnual, double gastSaude) : base(name, rendaAnual)
        {
            GastSaude = gastSaude;
        }

        public override double Imposto()
        {
            double imposto;

            if (RendaAnual >= 20000.0)
            {
                imposto = RendaAnual / 100 * 25;
            }
            else
            {
                imposto = RendaAnual / 100 * 15;
            }

            if (GastSaude != 0.0)
            {
                imposto = (imposto) - (GastSaude / 100 * 50);
            }
            return imposto;
        }
    }
}
