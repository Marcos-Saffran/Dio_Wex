using ExemploExplorando.Models;
using System.Globalization;


// vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
// Exceções e Coleções com C#

// Dictionary - Dicionário - chave-valor
Dictionary<string, string> estados = new Dictionary<string, string>();
estados.Add("SP", "São Paulo");
estados.Add("RJ", "Rio de Janeiro");
estados.Add("MG", "Minas Gerais");
estados.Add("BA", "Bahia");
estados.Add("PR", "Paraná");
estados.Add("mg", "minas gerais");
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

Console.WriteLine(estados["mg".ToUpper()]); // Acessando o valor do estado de Minas Gerais

foreach (var estado in estados)
{
    Console.WriteLine($"Chave: {estado.Key} - Valor: {estado.Value}");
}

Console.WriteLine("========================================");

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

