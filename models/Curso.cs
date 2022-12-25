using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO_explorando.NET_C_.models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AddAluno (Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
    
        public int ObterAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Listar alunos do Curso de {Nome}");
            for (int i = 0; i < Alunos.Count; i++)
            {
                //string text = "N° " + i + " - " + Alunos[i].NomeCompleto; //Concatenando
                string text = $"N° {i+1} - {Alunos[i].NomeCompleto}"; //Interpolando
                Console.WriteLine(text);
            }
            
            /*foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }*/
        }
    }
}