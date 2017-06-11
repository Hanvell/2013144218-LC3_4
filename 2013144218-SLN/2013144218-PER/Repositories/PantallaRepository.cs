using _2013144218_ENT.Entidades;
using _2013144218_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013144218_PER.Repositories
{
    public class PantallaRepository : Repository<Pantalla>, IPantallaRepository
    {

        public PantallaRepository(_2013144218_SLNDbContext context) : base(context)
        {

        }

        /* private readonly _2013144218_SLNDbContext _Context;

        public PantallaRepository(_2013144218_SLNDbContext context)
        {
            _Context = context;
        }

        private PantallaRepository()
        {
        }

        public IEnumerable<Pantalla> getPantallaxATM(ATM ATM)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pantalla> getPantallaxRetiro(Retiro Retiro)
        {
            throw new NotImplementedException();
        }
        */
    }
}
