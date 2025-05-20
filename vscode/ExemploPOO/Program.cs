using ExemploPOO.Models;
using ExemploPOO.Interfaces;

//vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
// Intefaces
// Contrato que pode ser implementado por qualquer classe
// Uma interface não pode ter implementação, apenas declarações

// ICalculadora calculadora = new ICalculadora(); // Não é possível instanciar uma interface
ICalculadora calculadora = new Calculadora();
Console.WriteLine(calculadora.Somar(10, 20));
Console.WriteLine(calculadora.Dividir(10, 3));

//vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
// classe object -> classe base de todas as classes
// todas as classes herdam de object, mesmo que não declare
// Métodos da classe object:
// ToString() -> retorna o nome da classe
// GetType() -> retorna o tipo da classe
// GetHashCode() -> retorna o hash code do objeto
// Equals() -> compara dois objetos
// Finalize() -> método chamado pelo garbage collector para liberar recursos
// Equals(Object, Object) -> compara dois objetos pelas instâncias
// ReferenceEquals(Object, Object) -> compara se dois objetos são o mesmo objeto na memória
// Equals(Object) -> compara se dois objetos são iguais
// MemberwiseClone() -> cria uma cópia do objeto

// Computador computador1 = new Computador();
// Console.WriteLine(computador1.ToString());




//vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
// Classe selada () -> impedir que outras classes facam herança
// nenhuma classe pode herdar de uma classe selada, ser sua derivada
// também existem métodos e propriedades seladas


//vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
// Construtor por herança
// Pessoa pessoa1 = new Pessoa("João");
// Aluno aluno1 = new Aluno("Maria");
// aluno1.Apresentar();

// Aluno aluno2 = new Aluno();


//vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
// Classe abstrata na prática

// // Conta conta1 = new Conta(); // Não é possível instanciar uma classe abstrata
// Conta conta1 = new Corrente();
// conta1.Creditar(1000);
// conta1.ExibirSaldo();


//vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
// Polimorfismo
// Aluno aluno1 = new Aluno();
// aluno1.Nome = "Maria";
// aluno1.Idade = 20;
// aluno1.Email = "teste@teste.com";
// aluno1.Nota = 10;
// aluno1.Apresentar();

// Professor professor1 = new Professor();
// professor1.Nome = "João";
// professor1.Idade = 30;
// professor1.Salario = 50000;
// professor1.Apresentar();

//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
//vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
// Herança

// Aluno aluno1 = new Aluno();
// aluno1.Nome = "Maria";
// aluno1.Idade = 20;
// aluno1.Email = "teste@teste.com";
// aluno1.Apresentar();

//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

// ContaCorrente conta1 = new ContaCorrente(12345, 1000);
// conta1.ExibirSaldo();
// conta1.Sacar(5100);

// conta1.ExibirSaldo();


// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "João";
// pessoa1.Idade = 30;
// pessoa1.Apresentar();
