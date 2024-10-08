﻿using SistemaPedidos.ValueObjects;
using System;

namespace SistemaPedidos.Domain
{
    public class Pedido
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime IniciadoEm { get; set; }
        public DateTime FinalizadoEm { get; set; }
        public TipoFrete TipoFrete { get; set; }
        public StatusPedido StatusPedido { get; set; }
        public String Observacao { get; set; }
        public ICollection<PedidoItem> Itens { get; set; }
    }
}