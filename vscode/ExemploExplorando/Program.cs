using ExemploExplorando.Models;
using System.Globalization;

// formatando o tipo DateTime
DateTime data = DateTime.Now;

Console.WriteLine(data); // Data e hora atual
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm")); // Data e hora atual formatada"

Console.WriteLine(data.ToShortDateString()); // Data atual formatada
Console.WriteLine(data.ToShortTimeString()); // Hora atual formatada

DateTime data2 = DateTime.Parse("17/04/2022 18:00"); // Data e hora atual formatada
Console.WriteLine(data2); // Data e hora atual formatada


string dataString = "2022-24-17 18:00";
DateTime data3 = DateTime.TryParseExact(dataString,
                                        "yyyy-MM-dd HH:mm",
                                        CultureInfo.InvariantCulture,
                                        DateTimeStyles.None,
                                        out DateTime data4) ? data4 : DateTime.MinValue;
Console.WriteLine(data3); // Data e hora atual formatada

DateTime.TryParseExact(dataString,
                        "yyyy-MM-dd HH:mm",
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None,
                        out DateTime data5);
Console.WriteLine(data5); // Data e hora atual formatada

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 12382.40M;

// Console.WriteLine($"{valorMonetario:C}"); // Formato de moeda padrão
// Console.WriteLine($"{valorMonetario:C2}"); // Formato de moeda com 2 casas decimais
// Console.WriteLine(valorMonetario.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))); // Formato de moeda em inglês
// Console.WriteLine(valorMonetario.ToString("C2", CultureInfo.CreateSpecificCulture("fr-FR"))); // Formato de moeda em francês
// Console.WriteLine(valorMonetario.ToString("C2", CultureInfo.InvariantCulture)); // Formato de moeda neutro

// // formatações personalizadas
// Console.WriteLine(valorMonetario.ToString("N8"));

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P2")); // Formato de porcentagem com 2 casas decimais

// int numero = 1234556;

// Console.WriteLine(numero.ToString("##-##-##"));



// string numero1 = "10";
// string numero2 = "20";

// string resultado = numero1 + numero2;
// Console.WriteLine(resultado);


// Pessoa pessoa1 = new Pessoa("Pessoa1", "Sobrenome1");
// // pessoa1.Nome = "Pessoa1";
// // pessoa1.Sobrenome = "Sobrenome1";

// Pessoa pessoa2 = new Pessoa(nome: "Pessoa2", sobrenome: "Sobrenome2");
// // pessoa2.Nome = "pessoa2";
// // pessoa2.Sobrenome = "Sobrenome2";

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Curso de Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(pessoa1);
// cursoDeIngles.AdicionarAluno(pessoa2);
// cursoDeIngles.ListarAlunos();
// Console.WriteLine($"Total de alunos matriculados: {cursoDeIngles.ObterAlunosMatriculados()}");

