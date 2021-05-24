using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TallerEje3MVC.Models;

namespace TallerEje3MVC.Data
{
    public class TallerEje3MVCContext : DbContext
    {
        public TallerEje3MVCContext (DbContextOptions<TallerEje3MVCContext> options)
            : base(options)
        {
        }

        public DbSet<TallerEje3MVC.Models.CandidatosModel> Candidatos{ get; set; }
        public DbSet<TallerEje3MVC.Models.VotosModel> Votos { get; set; }
    }
}
