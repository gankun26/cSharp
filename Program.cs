using System;
using Teste.cs;

namespace EstruturaDoCodigo
{
    class Program
    {
       static void main()
       {
           var s = new Pilha();
           s.Empilha(1);
           s.Empilha(10);
           s.Empilha(100);
           console.WriteLine(s.Desempilha());
           console.WriteLine(s.Desempilha());
           console.WriteLine(s.Desempilha());
       }

    }
}
