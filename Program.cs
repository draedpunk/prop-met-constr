using ExemploExplorando.Models;
//usando o segundo construtor
Pessoa p1 = new Pessoa("Pamela", "Rodrigues");
Pessoa p2 = new Pessoa("Cícero", "Gleyton");

Curso cursoIngles = new Curso();
cursoIngles.NomeCurso = "Ingles Avançado";
cursoIngles.Alunos = new List<Pessoa> { };

cursoIngles.AdicionarAluno(p1);
cursoIngles.AdicionarAluno(p2);
cursoIngles.ListarAlunos();