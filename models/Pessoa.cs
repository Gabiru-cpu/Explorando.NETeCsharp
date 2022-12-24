using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO_explorando.NET_C_.models
{
    public class Pessoa
    {
        //public Pessoa() { }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome;
        private int _idade;
        public string Nome 
        { 
            get => _nome;

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O Nome não pode ser vazio");
                }
                _nome = value;
            } 
        }
        public string Sobrenome { get; set; }
        //prop ou propriedade recebendo nome e sobre nome only get
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public int Idade 
        { 
            get => _idade;

            set            
            {
                if (value < 0)
                {
                    throw new ArgumentException("A Idade não pode ser negativa");
                }
                _idade = value;
            } 
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto} | Idade: {Idade}");
        }
    }
}