using ExemploFundamentos.Models;


string opcao;
bool continuar = true;

while(continuar){
    // Console.Clear();
    Console.WriteLine("Digite uma opção: ");
    Console.WriteLine("1 - Cadastrar Cliente");
    Console.WriteLine("2 - Buscar Cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");
    opcao = Console.ReadLine() ?? string.Empty;

    switch(opcao){
        case "1":
            Console.WriteLine("Cadastrar Cliente");
            break;
        case "2":
            Console.WriteLine("Buscar Cliente");
            break;
        case "3":
            Console.WriteLine("Apagar Cliente");
            break;
        case "4":
            Console.WriteLine("Encerrar");
            continuar = false;
            // Environment.Exit(0);
            // return;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

}
Console.WriteLine("Sistema encerrado com sucesso!");

// Calculadora calculadora = new Calculadora();

// int soma = 0, numero = 0;

// do {
//     Console.WriteLine("Digite um número (0 para parar): ");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;
// } while (numero != 0);

// Console.WriteLine($"A soma dos números digitados é: {soma}");





// int numero = 7;
// for (int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} * {contador} = {numero * contador}");
// }
// int contador = 1;
// while (contador <= 10)
// {
//     Console.WriteLine($"{contador}° Execução: {numero} * {contador} = {numero * contador}");
//     contador++;

//     if (contador == 6)
//     {
//         Console.WriteLine("Contador chegou a 6, saindo do loop.");
//         break;
//     }
// }

// contador = 0;
// do
// {
//     Console.WriteLine($"{contador + 1}° Execução: {numero} * {contador} = {numero * contador}");
//     contador++;
// } while (contador <= 10);



// calculadora.Somar(10, 20);
// calculadora.Subtrair(20, 10);
// calculadora.Multiplicar(10, 20);
// calculadora.Dividir(20, 10);
// calculadora.Potencia(2, 3);
// calculadora.RaizQuadrada(16);
// calculadora.Media(10, 20);
// calculadora.modulo(-10);
// calculadora.Porcentagem(200, 10);
// calculadora.Porcentagem(2, 10);
// calculadora.RestoQue(10, 3);
// calculadora.Seno(30);
// calculadora.Coseno(30);
// calculadora.Tangente(30);

// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine() ?? string.Empty;

// switch (letra.ToLower())
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o": 
//     case "u":
//         Console.WriteLine("Vogal");
//         break;
//     default:
//         Console.WriteLine("Consoante");
//         break;
// }

// if (letra == "a" || 
//     letra == "e" || 
//     letra == "i" || 
//     letra == "o" || 
//     letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Consoante");
// }

// if (letra == "a"){
//     Console.WriteLine("Vogal");
// } else if (letra == "e"){
//     Console.WriteLine("Vogal");
// } else if (letra == "i"){
//     Console.WriteLine("Vogal");
// } else if (letra == "o"){
//     Console.WriteLine("Vogal");
// } else if (letra == "u"){
//     Console.WriteLine("Vogal");
// } else {
//     Console.WriteLine("Consoante");
// }


// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 40;

// if (quantidadeCompra > quantidadeEmEstoque)
// {
//     Console.WriteLine("Não há estoque suficiente para realizar a compra.");
// }
// else
// {
//     Console.WriteLine("Compra realizada com sucesso!");
// }


// // convertendo de maneira segura
// string a = "15a";
// // int b = Convert.ToInt32(a); // conversão segura
// // int b = 0;
// // int.TryParse(a, out b); // conversão segura
// int.TryParse(a, out int b); // conversão segura
// Console.WriteLine(b);
// Console.WriteLine("Conversão segura realizada com sucesso!");


// // cast implicito
// int a = 10;
// double b = a; // conversão implícita

// Console.WriteLine(b);
// // cast explicito
// double c = 10.5;
// int d = (int)c; // conversão explícita
// Console.WriteLine(d);

// long e = long.MaxValue;
// Console.WriteLine(e);






// int inteiro = 10;
// string a = inteiro.ToString();

// Console.WriteLine(a);


// int a = Convert.ToInt32(null); // casting
// // int a = int.Parse(null); // parsing

// Console.WriteLine(a);



// int a = 10; 
// int b = 20;

// int c = a + b;

// // c = c + 5;
// c += 5;
// c -= 5;
// c *= 5;
// c /= 5;

// Console.WriteLine(c);

// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine($"Data atual: {dataAtual.ToString("dd/MM/yyyy HH:mm:ss")}");

// string apresentacao = "Olá, seja bem-vindo ao sistema de cadastro de pessoas!";
// int quantidade = 1;
// double altura = 1.80;
// double peso = 80;
// decimal salario = 2500.50m;
// float temperatura = 36.50f;
// char letra = 'A';
// bool ativo = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine($"Quantidade: {quantidade}");
// Console.WriteLine($"Altura: {altura.ToString("0.00 ")}");
// Console.WriteLine($"Peso: {peso}");
// Console.WriteLine($"Salário: {salario}");
// Console.WriteLine($"Temperatura: {temperatura}");
// Console.WriteLine($"Letra: {letra}");
// Console.WriteLine($"Ativo: {ativo}");



// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "João";
// pessoa1.Idade = 30;
// pessoa1.Apresentar();

// Pessoa pessoaFisicaRepresentacao = new Pessoa();
// pessoaFisicaRepresentacao.Nome = "Maria";
// pessoaFisicaRepresentacao.Idade = 25;
// pessoaFisicaRepresentacao.Apresentar();
