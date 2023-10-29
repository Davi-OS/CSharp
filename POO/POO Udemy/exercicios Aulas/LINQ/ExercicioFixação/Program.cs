using ExercicioFixação.Entities;
using System.Globalization;
using System.IO;
namespace ExercicioFixação
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            string Path = @"C:\Users\davio\OneDrive\Documentos\CloneGit\CSHARP\CSharp\POO\POO Udemy\exercicios Aulas\LINQ\ExercicioFixação\Entities\TextFile1.txt";
            StreamReader reader = new StreamReader(Path);
            Console.WriteLine("Informe o salario base:");
            double salarioBase = double.Parse(Console.ReadLine());

            while (!reader.EndOfStream)
            {
                string[] line = reader.ReadLine().Split(',');

                string name = line[0];
                string email = line[1];
                double salario = double.Parse(line[2],CultureInfo.InvariantCulture);
                funcionarios.Add(new Funcionario(name, email, salario));
            }

            // busca 
        
            var emails = funcionarios.Where(f => f.Salario > salarioBase).OrderBy(f=> f.Email).Select(f=> f.Email);
            Console.WriteLine($"email de Pessoas que ganham mais que {salarioBase.ToString("F2",CultureInfo.InvariantCulture)}:");
            foreach (string item in emails)
            {
                Console.WriteLine(item);
            }
            var R2 = funcionarios.Where(f => f.Name.StartsWith('M')).Sum(f => f.Salario);
            Console.WriteLine($"A soma dos salarios de quem o nome começa com M: ${R2.ToString("F2",CultureInfo.InvariantCulture)} ");

        }
    }
}