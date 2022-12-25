using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO_explorando.NET_C_.models
{
    public class Example
    {
        //Dictionary
        public void Dicionario()
        {
            Dictionary<string, string> estados = new Dictionary<string, string>();

            estados.Add("SP", "São Paulo");
            estados.Add("BA", "Bahia");
            estados.Add("MG", "Minas Gerais");
            estados.Add("RJ", "Rio de Janeiro");

            foreach (var item in estados) { Console.WriteLine($"Chave: {item.Key} | Valor: {item.Value}"); }
            estados.Remove("MG");
            foreach (var item in estados) { Console.WriteLine($"Chave: {item.Key} | Valor: {item.Value}"); }
        }

        /*//Pilha ou Stack
        public void Pilha()
        {
            Stack<string> pilha = new Stack<string>();

            pilha.Push("Pilha1");
            pilha.Push("Pilha2");
            pilha.Push("Pilha3");
            pilha.Push("Pilha4");
            pilha.Push("Pilha5");

            foreach (var item in pilha) { Console.WriteLine($"Conteudo: {item}"); }

            Console.WriteLine($"Removendo da Pilha {pilha.Pop()}");

            foreach (var item in pilha) { Console.WriteLine($"Conteudo: {item}"); }
        }*/


        /*//Fila ou Queue
        public void Fila()
        {
            Queue<string> fila = new Queue<string>();

            fila.Enqueue("example1 AB");
            fila.Enqueue("example2 BD");
            fila.Enqueue("example3 CG");
            fila.Enqueue("example4 DJ");

            Console.WriteLine("Exibindo sua Fila");

            foreach (var item in fila) { Console.WriteLine($"Conteudo: {item}"); }

            Console.WriteLine($"Removendo da Fila {fila.Dequeue()}");

            foreach (var item in fila) { Console.WriteLine($"Conteudo: {item}"); }
        }*/






        /*
        public void Metodo1(){
            try
            {
                Metodo2();        
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exceção tratada" + ex.Message);
            }
        }

        public void Metodo2(){ Metodo3(); }

        public void Metodo3(){ Metodo4(); }

        public void Metodo4()
        { 
            throw new Exception(" Ocorreu uma Exceção");
        }*/
    }
}