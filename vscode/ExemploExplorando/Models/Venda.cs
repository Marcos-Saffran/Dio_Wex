using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExemploExplorando.Models
{
    public class Venda
    {
        public int Id { get; set; }

        [JsonProperty("Produto")]
        public string? Produto { get; set; }
        public decimal Preco { get; set; }

        public DateTime DataVenda { get; set; } = DateTime.Now;

        public Venda(int id, string produto, decimal preco, DateTime? dataVenda = null)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            DataVenda = dataVenda ?? DateTime.Now; // Se dataVenda for nulo, usa a data atual
        }

        // tostring para exibir informações da venda
        public override string ToString()
        {
            return $"Venda ID: {Id}, Produto: {Produto}, Preço: {Preco:C}, Data da Venda: {DataVenda:dd/MM/yyyy HH:mm:ss}";
        }

    }
}