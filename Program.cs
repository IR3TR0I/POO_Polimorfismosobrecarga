using System;
using POO_Polimosobrecarga.Classes;

namespace POO_Polimo_sobrecarga_
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario fun = new Funcionario();
            fun.Mostrar();
            fun.Mostrar("ruan");
            fun.Mostrar(2);
        }
    }
}
