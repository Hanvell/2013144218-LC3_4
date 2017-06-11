using _2013144218_ENT.Entidades;
using _2013144218_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013144218_PER.Repositories
{
    public class RanuraDepositoRepository : Repository<RanuraDeposito>, IRanuraDepositoRepository
    {

        public RanuraDepositoRepository(_2013144218_SLNDbContext context) : base(context)
        {

        }
        /*  private  readonly _2013144218_SLNDbContext _Context;

          public RanuraDepositoRepository(_2013144218_SLNDbContext context)
          {
              _Context = context;
          }


          private RanuraDepositoRepository()
          {
          }

          public IEnumerable<RanuraDeposito> getRanuraporATM(ATM ATM)
          {
              throw new NotImplementedException();
          }
          */
    }

}
