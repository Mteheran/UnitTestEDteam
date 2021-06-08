using System;
using library;
using Xunit;

namespace tests
{
    public class CalculadoraTest
    {
        [Fact]
        public void Suma()
        {
            //Arrange
            Calculadora cal = new Calculadora();
            int result= 0;

            //Act 
            result = cal.Suma(3,4);

            //Assert
            Assert.Equal(7, result);
        }

        [Fact]
        public void Resta()
        {
            //Arrange
            Calculadora cal = new Calculadora();
            int result= 0;

            //Act 
            result = cal.Resta(3,4);

            //Assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Resta_10_5()
        {
            //Arrange
            Calculadora cal = new Calculadora();
            int result= 0;

            //Act 
            result = cal.Resta(10,5);

            //Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Multiplicacion()
        {
            //Arrange
            Calculadora cal = new Calculadora();
            int result= 0;

            //Act 
            result = cal.Multiplicacion(3,4);

            //Assert
            Assert.Equal(12, result);
        }

        [Fact]
        public void Division()
        {
            //Arrange
            Calculadora cal = new Calculadora();
            int result= 0;

            //Act 
            result = cal.Division(4,2);

            //Assert
            Assert.Equal(2, result);
        }

        
        [Fact]
        public void Division_by0()
        {
            //Arrange
            Calculadora cal = new Calculadora();
            int result= 0;

            //Act 
            result = cal.Division(2, 0);

            //Assert
            Assert.Equal(0, result);
        }

        [Theory]
        [ClassData(typeof(TestParesClassData))]
        public void ParesArray(int numImpar)
        {
            Calculadora cal = new Calculadora();            
            
            int[] result = cal.GetPares();

            Assert.DoesNotContain(numImpar, result);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(8)]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(800)]
        [InlineData(940)]
        public void ParesArray_ContainsPar(int numPar)
        {
            Calculadora cal = new Calculadora();            
            
            int[] result = cal.GetPares();

            Assert.Contains(numPar, result);
        }
    }
}
