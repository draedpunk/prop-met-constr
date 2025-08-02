using ExemploExplorando.Models;
using Models;
using Newtonsoft.Json;

List<Venda> listaVendas = new List<Venda>();

Venda v1 = new Venda(1, "Martelo", 25.00M);
Venda v2 = new Venda(2, "Consolo", 85.00M);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);




// desconstruir
// Pessoa p1 = new Pessoa("P", "UTA");

// (string nome, string sobrenome) = p1;
// Console.WriteLine($"{nome} e {sobrenome}");

// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {
//     Console.WriteLine("Qtd linhas do arquivo" + quantidadeLinhas);
//     foreach (string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("falhou");
// }

// (int, string, string, decimal) tupla = (1, "Porra", "Raiva", 61.4M);
// ValueTuple<int, decimal> tupla2 = (1, 56.7M);
// Console.WriteLine($"Nova tupla: {tupla2.Item1}");

// Console.WriteLine($"ID: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");
// Console.WriteLine($"Dinheiro: {tupla.Item4}");


// Dictionary<string, string> estados = new Dictionary<string, string>();
// estados.Add("PE", "Pernambuco");
// estados.Add("TJ", "Tiro de Janeiro");
// estados.Add("SC", "São Culo");

// foreach (var estad in estados)
// {
//     Console.WriteLine($"Chave: {estad.Key}, Valor: {estad.Value}");
// }


// Stack<int> pilha = new Stack<int>();

// pilha.Push(90);
// pilha.Push(89);
// pilha.Push(78);
// pilha.Push(61);

// foreach (int i in pilha)
// {
//     Console.WriteLine(i);
// }

// pilha.Pop();


// Queue<int> file = new Queue<int>();

// file.Enqueue(24);
// file.Enqueue(69);
// file.Enqueue(6);

// foreach (int item in file)
// {
//     Console.WriteLine(item);
// }
// Console.WriteLine($"deletando o elemento: {file.Dequeue()}");

// foreach (int item in file)
// {
//     Console.WriteLine(item);
// }

// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linhasLine in linhas)
//     {
//         Console.WriteLine(linhasLine);
//     }

// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção geneérica:{ex.Message}");
// }

// decimal valorMonetario = 10500.00M;
// Console.WriteLine($"Quero ganhar um salário de {valorMonetario:C} mensalmente no meu futuro emprego.");  // c de currancy

// //usando o segundo construtor
// Pessoa p1 = new Pessoa("Pamela", "Rodrigues");
// Pessoa p2 = new Pessoa("Cícero", "Gleyton");

// Curso cursoIngles = new Curso();
// cursoIngles.NomeCurso = "Ingles Avançado";
// cursoIngles.Alunos = new List<Pessoa> { };

// cursoIngles.AdicionarAluno(p1);
// cursoIngles.AdicionarAluno(p2);
// cursoIngles.ListarAlunos();