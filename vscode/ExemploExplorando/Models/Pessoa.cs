using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        // por padrão os contrutores estão no início da classe
        // Construtores são métodos especiais que inicializam os objetos
        public Pessoa()
        {
            Nome = "Nome Padrão";
            Sobrenome = "Sobrenome Padrão";

        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public void Deconstruct(out string nome, out string sobrenome)
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }

        private string _nome = "";

        public string Nome
        {
            // Body Expression
            get => _nome.ToUpper(); // Retorna o nome em letras maiúsculas
            
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Nome não pode ser vazio");
                }
                _nome = value;

            }
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper(); // Propriedade somente leitura

        private int _idade;

        public int Idade
        {
            // Expression Body
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Idade não pode ser negativa");
                }
                _idade = value;
            }
        }


        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}