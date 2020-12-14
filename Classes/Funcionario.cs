using System;

namespace POO_Polimosobrecarga.Classes
{
    public class Funcionario
    {
        public string[] lista = {"Ruan" , "carlos" , "Possarle"};

        public void Mostrar(){
            foreach (var item in lista){
                Console.WriteLine(item);
            }
        } 


        public void Mostrar(int índice){
            Console.WriteLine("Buscar pelo indíce : " + lista[índice]);
        }

        public void Mostrar(string Buscar){
            foreach (var item in lista){
                if (item == Buscar){
                    Console.WriteLine("Resultado : " + item);
                }
            }
        }
    }
}