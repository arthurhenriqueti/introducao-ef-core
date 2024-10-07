using SistemaPedidos.Domain;
using System;
using SistemaPedidos.ValueObjects;
using SistemaPedidos.Data;

namespace SistemaPedidos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            InserirDados();
            ConsultarDados();
            AtualizarDados();
            RemoverDados();
        }

        private static void InserirDados()
        {
            var produto = new Produto()
            {
                Descricao = "Teste",
                CodigoBarras = "12345678910",
                Valor = 10m,
                TipoProduto = TipoProduto.MercadoriaParaRevenda,
                Ativo = true
            };

            using var db = new ApplicationContext();

            db.Produtos.Add(produto);

            var registros = db.SaveChanges();

            Console.WriteLine($"Total Registro(s) = {registros}");
        }

        private static void ConsultarDados()
        {
            using var db = new ApplicationContext();

            var consultaPorSintaxe = (from c in db.Clientes where c.Id > 0 select c).ToList();

            foreach (var cliente in consultaPorSintaxe)
            {
                Console.WriteLine($"Consultando Cliente: {cliente.Id}");
                db.Clientes.Find(cliente.Id);
            }
        }

        private static void AtualizarDados()
        {
            using var db = new ApplicationContext();
            var cliente = db.Clientes.Find(1);
            cliente.Nome = "Cliente Alterado Passo 1";

            db.Clientes.Update(cliente);
            db.SaveChanges();
        }

        private static void RemoverDados()
        {
            using var db = new ApplicationContext();
            var cliente = db.Clientes.Find(2);

            db.Clientes.Remove(cliente);
            db.SaveChanges();
        }
    }
}