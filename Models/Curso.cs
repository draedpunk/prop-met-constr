using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string NomeCurso { get; set; }

        public List<Pessoa> Alunos { get; set; }

        // assinatura de metodo
        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int QtdAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public void RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos matriculados no curso de {NomeCurso}:");

            for (int i = 0; i < Alunos.Count; i++)
            {
                string texto = $"Nº {i+1} - {Alunos[i].NomeCompleto}";
                Console.WriteLine(texto);
            }

        }
    }
}