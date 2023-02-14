using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedscanQTD
{
    internal class Conexao
    {
        //encapsulamento para chegar no banco
        private static string _ROTA = "Data Source = 192.168.108.16\\SQLEXPRESS; Initial Catalog = ROTA; Persist Security Info=True;User ID = eduardo_ucb; Password=3DSONICeu@";
        public static string ROTA
        {
            get { return _ROTA; }
            set { _ROTA = value; }

        }
    }
}
