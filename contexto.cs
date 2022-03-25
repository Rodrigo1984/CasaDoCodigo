using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;

namespace CasaDoCodigo
{
    public class contexto : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ItemPedido> itensPedidos  { get; set; }
    }
}
