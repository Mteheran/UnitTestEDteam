using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using library;
using Moq;
using Xunit;

namespace tests
{
    public class ProcesadorDePalabrasTest
    {
        
        [Fact]
        public void ContarPalabras()
        {                       
           var mock = new Mock<ILectorArchivo>();
           mock.Setup(mock=> mock.LeerArchivo(It.IsAny<string>())).Returns("hola mundo");
           ProcesadorDePalabras procesador = new ProcesadorDePalabras(mock.Object);

           var result =  procesador.ContarPalabras();

           Assert.Equal(2, result);

        }

         [Fact]
        public void ContarDeCaracteres()
        {                       
           var mock = new Mock<ILectorArchivo>();
           mock.Setup(mock=> mock.LeerArchivo(It.IsAny<string>())).Returns("hola mundo");
           ProcesadorDePalabras procesador = new ProcesadorDePalabras(mock.Object);

           var result =  procesador.ContarCaracteres();

           Assert.Equal(10, result);

        }
        
    }
}