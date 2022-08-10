using ControleDeUsuarios.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleDeUsuarios.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext (DbContextOptions<BancoContext>options) : base(options)
        {

        }
        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
