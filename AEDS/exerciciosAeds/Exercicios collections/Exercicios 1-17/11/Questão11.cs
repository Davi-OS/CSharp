using System;
using System.Collections;

namespace ListaColections
{
    class Questão11
    {
        public static void Main(string[] args)
        {
            Al();
            fila();
            pilha();
        }

        static void Al()
        {
            int soma = 0;
            ArrayList AL = new ArrayList() { 1, 2, "AED", new Queue(), "teste", 3.14 };
            foreach (var n in AL)
            {
                soma = +n;
            }
        }

        static void fila()
        {
            Queue fila = new Queue();
            int soma = 0;
            fila.Enqueue(1);
            fila.Enqueue(2);
            fila.Enqueue("AED");
            fila.Enqueue(new Queue());
            fila.Enqueue("teste");
            fila.Enqueue(3.14);

            int count = fila.Count;

            foreach (var n in fila)
            {
                soma = +n;
            }
        }

        static void pilha()
        {
            int soma = 0;
            Stack pilha = new Stack();
            pilha.Push(1);
            pilha.Push(2);
            pilha.Push("AED");
            pilha.Push(new Queue());
            pilha.Push("teste");
            pilha.Push(3.14);
            // empilhando os valores sem os 5 e 13
            foreach (var n in pilha)
            {
                soma = +n;
            }
        }
        // Erros apresentados:

        // C:\Users\Droit\Desktop\CSHARP\CSharp\AEDS\exerciciosAeds\Exercicios collections\Exercicios 1-17\11\Program.cs(21,24): error CS0023: O operador "+" não pode ser aplicado ao operando do tipo "object" [C:\Users\Droit\Desktop\
        // CSHARP\CSharp\AEDS\exerciciosAeds\Exercicios collections\Exercicios 1-17\11\11.csproj]
        // C:\Users\Droit\Desktop\CSHARP\CSharp\AEDS\exerciciosAeds\Exercicios collections\Exercicios 1-17\11\Program.cs(40,24): error CS0023: O operador "+" não pode ser aplicado ao operando do tipo "object" [C:\Users\Droit\Desktop\
        // CSHARP\CSharp\AEDS\exerciciosAeds\Exercicios collections\Exercicios 1-17\11\11.csproj]
        // C:\Users\Droit\Desktop\CSHARP\CSharp\AEDS\exerciciosAeds\Exercicios collections\Exercicios 1-17\11\Program.cs(57,24): error CS0023: O operador "+" não pode ser aplicado ao operando do tipo "object" [C:\Users\Droit\Desktop\
        // CSHARP\CSharp\AEDS\exerciciosAeds\Exercicios collections\Exercicios 1-17\11\11.csproj]
    }
}
