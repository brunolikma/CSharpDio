using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
         public delegate void Operacao(int x, int y);
         static void Main(string[] args)
         {
            Matematica m = new Matematica(20, 10);
            m.Somar();

        //     Operacao op = new Operacao(Calculadora.Somar);
        //     op += Calculadora.Subtrair;
        //     op.Invoke(10,10);
            



         //Data data = new Data();
         //data.SetMes(20);

         //data.Mes = 20;
         //System.Console.WriteLine(data.Mes);

         //data.ApresentarMes();
            // Aluno p1 = new Aluno("Bruno", "Lima", "Matematica");
            // p1.Apresentar();
        }
    }
}