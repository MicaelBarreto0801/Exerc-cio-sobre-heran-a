using ExercicioHeranca.Entities;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Conta> list = new List<Conta>();

        Console.Write("Enter the number of tax payers: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Tax payers #{i} data: ");
            Console.Write("Individual or company (i/c)? ");
            char c = char.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Anual income: ");
            double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (c == 'i')
            {
                Console.Write("Health expenditures: ");
                double gastSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new ContaFisica(name, rendaAnual, gastSaude));
            }
            else
            {
                Console.Write("Number of employees: ");
                int numFuncionarios = int.Parse(Console.ReadLine());
                list.Add(new ContaJuridica(name, rendaAnual, numFuncionarios));
            }
        }

        Console.WriteLine();
        Console.WriteLine("TAXES PAIND: ");

        double calcImposto = 0.0;
        foreach (Conta item in list)
        {
            Console.WriteLine(item);
            calcImposto += item.Imposto();
        }

        Console.WriteLine();
        Console.WriteLine("TOTAL TAXE: $ " + calcImposto.ToString("F2", CultureInfo.InvariantCulture));
    }
}