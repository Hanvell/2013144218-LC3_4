using _2013144218_ENT.Entidades;
using _2013144218_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013144218_PER.Repositories
{
    public class ATMRepository : Repository<ATM>, IATMRepository
    {

        public ATMRepository(_2013144218_SLNDbContext context) : base(context)
        {

        }





        /* private readonly _2013144218_SLNDbContext _Context;

         private ATMRepository()
         {

         }
         public ATMRepository(_2013144218_SLNDbContext context )
         {
             _Context = context;
         }

         public IEnumerable<ATM> getATMxRanura(RanuraDeposito RanuraDeposito)
         {
             throw new NotImplementedException();
         }

         public IEnumerable<ATM> getATMxTeclado(Teclado Teclado)
         {
             throw new NotImplementedException();
         }

         public IEnumerable<ATM> getATMxDispensadorEfectivo(DispensadorEfectivo DispensadorEfectivo)
         {
             throw new NotImplementedException();
         }

         public IEnumerable<ATM> getATMxPantalla(Pantalla Pantalla)
         {
             throw new NotImplementedException();
         }

         public IEnumerable<ATM> getATMxRetiro(Retiro Retiro)
         {
             throw new NotImplementedException();
         }

         public IEnumerable<ATM> getATMxBaseDatos(BaseDatos BaseDatos)
         {
             throw new NotImplementedException();

     */
    }
    }

