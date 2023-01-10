using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeberFactory_ModeladoSoftware
{
    internal class Creador
    {
        public const int ALAMBRICO = 1;
        public const int INALAMBRICO = 2;

        public static Audifono CreadorAudifono(int tipo)
        {
            switch (tipo)
            {
                case ALAMBRICO:
                    return new Alambrico();
                case INALAMBRICO:
                    return new Inalambrico();
                default: return null;
            }


        }
    }
}
