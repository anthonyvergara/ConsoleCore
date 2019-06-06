using System;
using Cadastro.Lib;

namespace Cadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa("vixithony","Anthony",22);
            Console.WriteLine(p.Cadastrar("jhen","Jhenifer",18));
            Console.WriteLine(p.Listar());
        }
    }
}
