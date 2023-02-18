using System;
using System.IO;
class Program
{
    //exibe o arquivo no console//
    static void LerDados()
    {
        StreamReader sr = new StreamReader(@"listaAlunos.txt");
        string line = sr.ReadLine();
        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        Console.WriteLine("~~Fim da lista~~");
        sr.Close();
        menuUsuario();
    }
    //Cadastra o alnuo//
    static void InserirAluno()
    {
        char op;
        do
        {
            string nomeAluno;
            string tellAluno;
            Console.WriteLine("Informe o nome do aluno:");
            nomeAluno = Console.ReadLine();
            Console.WriteLine("Informe o telefone do aluno:");
            tellAluno = Console.ReadLine();
            StreamWriter sw = new StreamWriter(@"listaAlunos.txt", true);
            sw.WriteLine("Nome: {0} Tell: {1}", nomeAluno, tellAluno);
            sw.Close();
            //menu basico para seguir para o proximo nome//
            Console.WriteLine("Deseja continuar para o proximo aluno? \n[s] para sim \n[n] para não.");
            op = char.Parse(Console.ReadLine());
        } while (op == 's');
        Console.Clear();
        menuUsuario();
    }
    //Menu do usuario com swtch case//
    static void menuUsuario()
    {
        char opção;
        Console.WriteLine("Escolha a ação desejada:");
        Console.WriteLine("[a] Inserir dados de Aluno. \n[b] Ler os alunos cadastrados. \n[c] Finalizar. ");

        opção = char.Parse(Console.ReadLine());
        switch (opção)
        {
            case 'a':
                InserirAluno();
                break;
            case 'b':
                LerDados();
                break;
            case 'c':
                break;
            default:
                Console.WriteLine("Opção invalida.");
                menuUsuario();
                break;
        }
    }
    public static void Main(string[] args)
    {
        menuUsuario();
    }
}