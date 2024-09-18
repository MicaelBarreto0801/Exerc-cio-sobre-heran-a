using System.Globalization;

namespace ExercicioHeranca.Entities
{
    abstract internal class Conta
    {
        public string Name { get; set; }
        public double RendaAnual { get; set; }

        public Conta(string name, double rendaAnual)
        {
            Name = name;
            RendaAnual = rendaAnual;
        }

        public abstract double Imposto();

        public override string ToString()
        {
            return Name
                + ": $ "
                + Imposto().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
