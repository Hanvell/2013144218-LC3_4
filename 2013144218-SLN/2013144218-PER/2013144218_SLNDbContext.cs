using _2013144218_ENT.Entidades;
using _2013144218_PER.EntitiesConfigurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013144218_PER
{
    
        public class _2013144218_SLNDbContext : DbContext
    {

        public DbSet<ATM> ATMs { get; set; }
        public DbSet<BaseDatos> BaseDatos_s { get; set; }
        public DbSet<Cuenta> Cuentas { get; set; }
        public DbSet<DispensadorEfectivo> DispensadorEfectivo_s { get; set; }
        public DbSet<Pantalla> Pantallas { get; set; }
        public DbSet<RanuraDeposito> RanuraDeposito_s { get; set; }
        public DbSet<Retiro> Retiros { get; set; }
        public DbSet<Teclado> Teclados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ATMConfiguration());
            modelBuilder.Configurations.Add(new BaseDatosConfiguration());
            modelBuilder.Configurations.Add(new CuentaConfiguration());
            modelBuilder.Configurations.Add(new DispensadorEfectivoConfiguration());
            modelBuilder.Configurations.Add(new PantallaConfiguration());
            modelBuilder.Configurations.Add(new RanuraDepositoConfiguration());
            modelBuilder.Configurations.Add(new RetiroConfiguration());
            modelBuilder.Configurations.Add(new TecladoConfiguration());


            base.OnModelCreating(modelBuilder);

        }



    }

}
