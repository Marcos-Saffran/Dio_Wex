using ExemploPOO.Models;


//vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
// Polimorfismo
Aluno aluno1 = new Aluno();
aluno1.Nome = "Maria";
aluno1.Idade = 20;
aluno1.Email = "teste@teste.com";
aluno1.Nota = 10;
aluno1.Apresentar();

Professor professor1 = new Professor();
professor1.Nome = "João";
professor1.Idade = 30;
professor1.Salario = 50000;
professor1.Apresentar();

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
