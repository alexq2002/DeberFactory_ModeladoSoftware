using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeberFactory_ModeladoSoftware;

internal class Program
{
    private static void Main(string[] args)
    {
        Audifono audifon0 = Creador.CreadorAudifono(Creador.ALAMBRICO);
        Console.WriteLine(audifon0.precio());
    }
}