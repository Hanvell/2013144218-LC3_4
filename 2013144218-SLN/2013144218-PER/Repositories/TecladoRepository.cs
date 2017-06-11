
using _2013144218_ENT.Entidades;
using _2013144218_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013144218_PER.Repositories
{
    public class TecladoRepository : Repository<Teclado>, ITecladoRepository
    {
        public TecladoRepository(_2013144218_SLNDbContext context) : base(context)
        {

        }

        /*  private readonly _2013144218_SLNDbContext _Context;

          public TecladoRepository(_2013144218_SLNDbContext context)
          {
              _Context = context;
          }
          private TecladoRepository()
          {
          }

          public IEnumerable<Teclado> getTecladoporATM(ATM ATM)
          {
              throw new NotImplementedException();
          }

          public IEnumerable<Teclado> getTecladoporRetiro(Retiro Retiro)
          {
              throw new NotImplementedException();
          }

      */
    }
}
