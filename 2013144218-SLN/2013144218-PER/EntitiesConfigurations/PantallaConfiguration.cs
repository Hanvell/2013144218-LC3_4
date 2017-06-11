using _2013144218_ENT.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013144218_PER.EntitiesConfigurations
{
    public class PantallaConfiguration : EntityTypeConfiguration<Pantalla>
    {

        public PantallaConfiguration()
        {

            ToTable("Pantalla");

            HasKey(a => a.idPantalla);
            HasOptional(c => c.Retiro).WithRequired(c => c.Pantalla);

        }

    }
}
