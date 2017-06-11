using _2013144218_ENT.Entidades;
using _2013144218_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013144218_PER.Repositories
{
    public class BaseDatosRepository : Repository<BaseDatos>, IBaseDatosRepository
    {
        public BaseDatosRepository(_2013144218_SLNDbContext context) : base(context)
        {

        }



        /*  private readonly _2013144218_SLNDbContext _Context;

          private BaseDatosRepository()
          {
          }

          public BaseDatosRepository(_2013144218_SLNDbContext context)
          {
              _Context = context;
          }

          public IEnumerable<BaseDatos> getBaseDatosxATM(ATM ATM)
          {
              throw new NotImplementedException();
          }

          public IEnumerable<BaseDatos> getBaseDatosxCuenta(Cuenta Cuenta)
          {
              throw new NotImplementedException();
          }

          public IEnumerable<BaseDatos> getBaseDatosxRetiro(Retiro Retiro)
          {
              throw new NotImplementedException();
              */
    }
    }

