using _2013144218_ENT.Entidades;
using _2013144218_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013144218_PER.Repositories
{
    public class CuentaRepository : Repository<Cuenta>, ICuentaRepository
    {
        public CuentaRepository(_2013144218_SLNDbContext context) : base(context)
        {

        }




        /*  private readonly _2013144218_SLNDbContext _Context;

          public CuentaRepository(_2013144218_SLNDbContext context)
          {
              _Context = context;
          }
          private CuentaRepository()
          {
          }

          public IEnumerable<Cuenta> getCuentaxBaseDatos(BaseDatos BaseDatos)
          {
              throw new NotImplementedException();

          }
          */
    }
}
