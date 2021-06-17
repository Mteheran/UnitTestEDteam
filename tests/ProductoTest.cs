using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using library;
using AutoFixture;

namespace tests
{
    public class ProductoTest
    {


        [Fact]
        public void ProductoEntityTest()
        {               
            Fixture fixture = new Fixture();
            Producto producto = fixture.Build<Producto>()
                                .With(p=> p.Nombre, "Nevera")
                                .Without(p=> p.Descripcion).Create();

            decimal impuesto = producto.Precio * Convert.ToDecimal(0.19);
            string fulldescripcion = producto.Nombre + " - " + producto.Descripcion;


            Assert.Equal(impuesto, producto.Impuesto);
            Assert.Equal(fulldescripcion, producto.FullDescripcion);           

        }
        
    }
}