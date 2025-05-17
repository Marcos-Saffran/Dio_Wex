using ExemploExplorando.Models;

Pessoa pessoa1 = new Pessoa("Pessoa1", "Sobrenome1");
// pessoa1.Nome = "Pessoa1";
// pessoa1.Sobrenome = "Sobrenome1";

Pessoa pessoa2 = new Pessoa(nome: "Pessoa2", sobrenome: "Sobrenome2");
// pessoa2.Nome = "pessoa2";
// pessoa2.Sobrenome = "Sobrenome2";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Curso de Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(pessoa1);
cursoDeIngles.AdicionarAluno(pessoa2);
cursoDeIngles.ListarAlunos();
Console.WriteLine($"Total de alunos matriculados: {cursoDeIngles.ObterAlunosMatriculados()}");
