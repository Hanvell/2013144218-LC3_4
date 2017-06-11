using _2013144218_ENT.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013144218_PER.EntitiesConfigurations
{
    public class CuentaConfiguration : EntityTypeConfiguration<Cuenta>
    {
        public CuentaConfiguration()
        {

            ToTable("Cuenta");

            HasKey(a => a.idCuenta);
            HasRequired(c => c.BaseDatos).WithMany(g => g.listaCuentas).HasForeignKey(v => v.idBaseDatos);

        }

    }
}
