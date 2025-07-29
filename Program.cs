using ExemploExplorando.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Pamela";
p1.Sobrenome = "Rodrigues";

Pessoa p2 = new Pessoa();
p2.Nome = "Cícero";
p2.Sobrenome = "Gleyton";

Curso cursoIngles = new Curso();
cursoIngles.NomeCurso = "Ingles Avançado";
cursoIngles.Alunos = new List<Pessoa> { };

cursoIngles.AdicionarAluno(p1);
cursoIngles.AdicionarAluno(p2);
cursoIngles.ListarAlunos();