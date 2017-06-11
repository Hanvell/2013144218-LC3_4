using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013144218_ENT.Entidades
{
    public class RanuraDeposito
    {

        public int idRanuraDeposito { set; get; }

        public int idATM { set; get; }
        public ATM ATM { set; get; }
    }
}
