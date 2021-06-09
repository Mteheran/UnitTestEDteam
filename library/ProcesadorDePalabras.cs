using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library
{
    public class ProcesadorDePalabras
    {
        ILectorArchivo lectorArchivo;

        public ProcesadorDePalabras(ILectorArchivo lector)
        {
            this.lectorArchivo = lector;
        }

        public int ContarPalabras()
        {
            return lectorArchivo.LeerArchivo("C:/EDteam/filetest.txt").Split(" ").Count();
        }

        public int ContarCaracteres()
        {
            return lectorArchivo.LeerArchivo("C:/EDteam/filetest.txt").Length;
        }
    }
}