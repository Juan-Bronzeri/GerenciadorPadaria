using System;

namespace Padaria_DTO
{
    public class Login_DTO
    {
        public string User { get; set; }
        public string Senha { get; set; }
    }
    public class Cliente_DTO
    {
        public int Id { get; set; }
        public int IdTaxa { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Rua { get; set; }
        public int NumeroCasa { get; set; }
        public string CEP { get; set; }
        public string Complemento { get; set; }
        public DateTime DataCadastro { get; set; }
        public string HorarioEntrega { get; set; }

    }

    public class Produto_DTO
    {
        public int Id { get; set; }
        public string NomeProduto { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
    }

    public class Itens_DTO
    {
        public int IdPedido { get; set; }
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public string Observacao { get; set; }
        public decimal PrecoProduto { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Total { get; set; }
        public decimal SomaTotal { get; set; }
    }

    public class Pedido_DTO
    {
        public string NomeCliente { get; set; }
        public int IdPedido { get; set; }
        public int IdCliente { get; set; }
        public DateTime DataAbertura { get; set; }
        public int Estado { get; set; }
        public string MetodoPagamento { get; set; }

        //Dados do Cliente
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Rua { get; set; }
        public int NumeroCasa { get; set; }
        public string CEP { get; set; }
        public string Complemento { get; set; }
        public DateTime DataAberturaCliente { get; set; }
        public int IdTaxa { get; set; }
        public string HorarioEntrega { get; set; }
    }

    public class Taxa_DTO
    {
        public int Id { get; set; }
        public string NomeBairro { get; set; }
        public decimal Valor { get; set; }
    }
}
