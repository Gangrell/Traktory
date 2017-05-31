using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traktory
{
    class Autor
    {

        private static Autor instance = new Autor();

        string S = "Mateusz Pałyska";

        private Autor() { }

        public static Autor Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Autor();
                }
                return instance;
            }
        }

        public string Tworca()
        {
            return S;
        }

    }
}
