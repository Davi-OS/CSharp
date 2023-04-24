using System;
using System.Collections;

namespace ListaColections
{
    class Questão13
    {
        public static void Main(string[] args)
        {
            int QNT = int.Parse(Console.ReadLine());
            int[] Aleatorio = new int[QNT];
            Random R = new Random();
            for (int i = 0; i < QNT; i++)
            {
                Aleatorio[i] = R.Next(50,100);
                Console.Write(" - {0}", Aleatorio[i]);
            }
        }
    }
}
