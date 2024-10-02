using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaPedidos.Domain
{
    [Table("Clientes")] // DataAnnotations
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Nome { get; set; }
        [Column("Phone")]
        public String Telefone { get; set; }
        public String CEP { get; set; }
        public String Estado { get; set; }
        public String Cidade { get; set; }
    }
}