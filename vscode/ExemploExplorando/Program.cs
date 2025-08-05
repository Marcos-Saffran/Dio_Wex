using ExemploExplorando.Models;
using Newtonsoft.Json;
using System.Globalization;


// \/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/
// tipos nulos
bool? desejaReceberEmail = null; // Nullable boolean
if (desejaReceberEmail == true)
{
    Console.WriteLine("O usuário deseja receber e-mails.");
}
else if (desejaReceberEmail == false)
{
    Console.WriteLine("O usuário não deseja receber e-mails.");
}
else
{
    Console.WriteLine("O usuário não informou se deseja receber e-mails.");
}

if (desejaReceberEmail.HasValue && desejaReceberEmail.Value) // ou (desejaReceberEmail != null && desejaReceberEmail.Value)
{
    Console.WriteLine("O usuário deseja receber e-mails.");
}
else
{
    Console.WriteLine("O usuário não informou ou não deseja receber e-mails.");
}





// /\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\


// \/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/

// IF ternário

// int numero = 15;
// string resultado = numero % 2 == 0 ? $"O número {numero} é par" : $"O número {numero} é ímpar";
// Console.WriteLine(resultado);

// bool isEven = numero % 2 == 0; // Usando o operador ternário para verificar se o número é par ou ímpar
// // Outra forma de usar o operador ternário
// Console.WriteLine($"O número {numero} é " + (isEven ? "par" : "ímpar"));

// /\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\






// vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
// Tuplas na prática
// Tuplas são estruturas de dados que permitem agrupar diferentes tipos de dados em uma única estrutura.

// Pessoa pessoa = new Pessoa("João", "Silva");

// (string nome, string sobrenome) = pessoa; // Desconstrução de tupla
// Console.WriteLine($"Nome: {nome}, Sobrenome: {sobrenome}");

// LeituraArquivo leituraArquivo = new LeituraArquivo();
// var resultado = leituraArquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (resultado.Sucesso)
// {
//     Console.WriteLine($"Total de linhas lidas: {resultado.TotalLinhas}");
//     foreach (var linha in resultado.Linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo.");
// }

// var (sucesso, linhas, totalLinhas) = leituraArquivo.LerArquivo("Arquivos/arquivoLeitura.txt");
// if (sucesso)
// {
//     Console.WriteLine($"Total de linhas lidas: {totalLinhas}");
//     foreach (var linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo.");
// }

// // usando descarte de informações para total de linhas
// Console.WriteLine("usando descarte de informações para total de linhas");
// var (sucessoDescarte, linhasDescarte, _) = leituraArquivo.LerArquivo("Arquivos/arquivoLeitura.txt");
// if (sucessoDescarte)
// {
//     foreach (var linha in linhasDescarte)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo.");
// }

// // usando desconstrução de tuplas
// Console.WriteLine("usando desconstrução de tuplas");
// var resultadoDesconstrucao = leituraArquivo.LerArquivo("Arquivos/arquivoLeitura.txt");
// var (sucessoDesconstrucao, linhasDesconstrucao, totalLinhasDesconstrucao) = resultadoDesconstrucao;
// if (sucessoDesconstrucao)
// {
//     Console.WriteLine($"Total de linhas lidas: {totalLinhasDesconstrucao}");
//     foreach (var linha in linhasDesconstrucao)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo.");
// }

// (int id, string Nome, string Sobrenome, decimal Salario) tupla = (1, "João", "Silva", 105m);
// Console.WriteLine($"ID: {tupla.id}, Nome: {tupla.Nome}, Sobrenome: {tupla.Sobrenome}, Salário: {tupla.Salario.ToString("C", CultureInfo.CurrentCulture)}");

// // Outra sintaxe de tuplas
// ValueTuple<int, string, string, decimal> tupla1 = (1, "Ana", "Souza", 2000.75m);
// Console.WriteLine($"ID: {tupla1.Item1}, Nome: {tupla1.Item2}, Sobrenome: {tupla1.Item3}, Salário: {tupla1.Item4.ToString("C", CultureInfo.CurrentCulture)}");

// var outroExemploTuplaCreate = Tuple.Create(3, "Carlos", "Pereira", 3000.00m);
// Console.WriteLine($"ID: {outroExemploTuplaCreate.Item1}, Nome: {outroExemploTuplaCreate.Item2}, Sobrenome: {outroExemploTuplaCreate.Item3}, Salário: {outroExemploTuplaCreate.Item4.ToString("C", CultureInfo.CurrentCulture)}");

// var tupla2 = (Id: 2, Nome: "Maria", Sobrenome: "Oliveira", Salario: 1500.50m);
// Console.WriteLine($"ID: {tupla2.Id}, Nome: {tupla2.Nome}, Sobrenome: {tupla2.Sobrenome}, Salário: {tupla2.Salario.ToString("C", CultureInfo.CurrentCulture)}");

// tuplas em métodos
// (int, string) ObterDadosPessoa()
// {
//     return (1, "João");
// }


// ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^


// vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
// Exceções e Coleções com C#

// Dictionary - Dicionário - chave-valor
// Dictionary<string, string> estados = new Dictionary<string, string>();
// estados.Add("SP", "São Paulo");
// estados.Add("RJ", "Rio de Janeiro");
// estados.Add("MG", "Minas Gerais");
// estados.Add("BA", "Bahia");
// estados.Add("PR", "Paraná");
// estados.Add("mg", "minas gerais");
// estados.Add("RS", "Rio Grande do Sul");
// estados.Add("ES", "Espírito Santo");
// estados.Add("GO", "Goiás");
// estados.Add("DF", "Distrito Federal");
// estados.Add("MS", "Mato Grosso do Sul");
// estados.Add("MT", "Mato Grosso");
// estados.Add("TO", "Tocantins");
// estados.Add("MA", "Maranhão");
// estados.Add("PI", "Piauí");
// estados.Add("CE", "Ceará");
// estados.Add("RN", "Rio Grande do Norte");
// estados.Add("PB", "Paraíba");
// estados.Add("PE", "Pernambuco");
// estados.Add("AL", "Alagoas");
// estados.Add("SE", "Sergipe");

// Console.WriteLine(estados["mg".ToUpper()]); // Acessando o valor do estado de Minas Gerais

// foreach (var estado in estados)
// {
//     Console.WriteLine($"Chave: {estado.Key} - Valor: {estado.Value}");
// }

// Console.WriteLine("========================================");

// estados.Remove("BA"); // Remove o estado da Bahia
// estados["SP"] = "São Paulo - SP"; // Atualiza o valor do estado de São Paulo

// foreach (var estado in estados)
// {
//     Console.WriteLine($"Chave: {estado.Key} - Valor: {estado.Value}");
// }

// string chave = "SP";
// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"O estado {chave} existe no dicionário.");
// }
// else
// {
//     Console.WriteLine($"O estado {chave} não existe no dicionário.");
// }





// ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^




// Pilhas (stacks) (LIFO - Last In First Out - Último a entrar, primeiro a sair)
// Stack<int> pilha = new Stack<int>();
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine($"Adicionando : {i + 1}");
//     pilha.Push(i + 1);
//     Console.WriteLine($"Pilha após adicionar {i + 1}");
//     pilha.ToList().ForEach(x => Console.WriteLine(x));
//     Console.WriteLine("--------------");
// }
// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }
// for (int i = 0; i < 5; i++)
// {
//     Console.WriteLine($"Removendo : {pilha.Pop()}");
// }
// Console.WriteLine("Pilha depois de remover 5 itens:");
// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }




// Fila (queue) (FIFO - First In First Out - Primeiro a entrar, primeiro a sair)
// Queue<int> fila = new Queue<int>();

// for (int i = 0; i < 10; i++)
// {
//     fila.Enqueue(i + 1);
// }

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// for (int i = 0; i < 5; i++)
// {
//     Console.WriteLine(fila.Dequeue());
// }

// Console.WriteLine("Fila depois de remover 5 itens:");
// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }


// Usando o throw
// ExemploExcecao exemploExcecao = new ExemploExcecao();
// exemploExcecao.Metodo1();

// new ExemploExcecao().Metodo1();

// Realizando a leitura de um arquivo
// Tratando exceções
// Exceções são eventos que ocorrem durante a execução de um programa e que podem interromper o fluxo normal do programa.
// Exceções podem ser tratadas usando blocos try-catch-finally.
// O bloco try contém o código que pode gerar uma exceção.
// O bloco catch contém o código que trata a exceção.
// O bloco finally contém o código que será executado independentemente de uma exceção ter ocorrido ou não.

// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Arquivo não encontrado: {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Diretório não encontrado: {ex.Message}");
// }
// catch (IOException ex)
// {
//     Console.WriteLine($"Erro de I/O: {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Erro inesperado: {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Execução finalizada.");
// }




// ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^




// // formatando o tipo DateTime
// DateTime data = DateTime.Now;

// Console.WriteLine(data); // Data e hora atual
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm")); // Data e hora atual formatada"

// Console.WriteLine(data.ToShortDateString()); // Data atual formatada
// Console.WriteLine(data.ToShortTimeString()); // Hora atual formatada

// DateTime data2 = DateTime.Parse("17/04/2022 18:00"); // Data e hora atual formatada
// Console.WriteLine(data2); // Data e hora atual formatada


// string dataString = "2022-24-17 18:00";
// DateTime data3 = DateTime.TryParseExact(dataString,
//                                         "yyyy-MM-dd HH:mm",
//                                         CultureInfo.InvariantCulture,
//                                         DateTimeStyles.None,
//                                         out DateTime data4) ? data4 : DateTime.MinValue;
// Console.WriteLine(data3); // Data e hora atual formatada

// DateTime.TryParseExact(dataString,
//                         "yyyy-MM-dd HH:mm",
//                         CultureInfo.InvariantCulture,
//                         DateTimeStyles.None,
//                         out DateTime data5);
// Console.WriteLine(data5); // Data e hora atual formatada

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

