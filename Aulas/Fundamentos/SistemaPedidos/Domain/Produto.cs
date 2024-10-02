using SistemaPedidos.ValueObjects;
using System;

namespace SistemaPedidos.Domain
{
    public class Produto
    {
        public int Id { get; set; }
        public String CodigoBarras { get; set; }
        public String Descricao { get; set; }
        public decimal Valor { get; set; }
        public TipoProduto TipoProduto { get; set; }
        public bool Ativo { get; set; }
    }
}