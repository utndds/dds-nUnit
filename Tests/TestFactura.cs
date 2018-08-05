using System;
using NUnit.Framework;
using NUnit;

namespace Tests
{
    [TestFixture]
    public class TestFactura
    {
        /// <summary>
        /// Este test prueba el constructor de la clase Factura
        /// Este test esta fallando a proposito, puesto que no se puede crear una factura sin pasar el nombre del cliente. Para hacerlo andar, pasar un string en vez de null
        /// </summary>
        [Test]
        public void Test_CrearFactura()
        {
            //instanciando un objeto Factura 
            //Arrange
            int numFactura = 1;
            string nombreCliente = null;

            //Act
            Factura fac = new Factura(numFactura, nombreCliente);

            //Assert
            Assert.NotNull(fac);
            Assert.AreEqual(fac.NombreCliente, nombreCliente);
        }

        /// <summary>
        /// Este test, a pesar de levantar la excepcion porque el nombre del cliente es null, no falla porque esta precisamente esperando que el constructor de 
        /// la clase factura levante una excepcion
        /// </summary>
        [Test]
        public void Test_CrearFactura_Control_Excepcion()
        {
            //instanciando un objeto Factura 
            //Arrange
            int numFactura = 1;
            string nombreCliente = null;

            //Act &
            //Assert
            Assert.Throws<ArgumentNullException>(
                () => {
                    Factura fac = new Factura(numFactura, nombreCliente); ;
                });
        }

        /// <summary>
        /// Este test prueba el constructor de la clase Factura
        /// </summary>
        [Test]
        public void Test_CrearFactura_Sin_Fallar()
        {
            //instanciando un objeto Factura 
            //Arrange
            int numFactura = 1;
            string nombreCliente = "Adriana";

            //Act
            Factura fac = new Factura(numFactura, nombreCliente);

            //Assert
            Assert.NotNull(fac);
            Assert.AreEqual(fac.NombreCliente, "Adriana");
        }

        /// <summary>
        /// Este test agrega items a una factura y chequea que se hayan agregado
        /// </summary>
        [Test]
        public void Test_Agregar_Items()
        {
            //instanciando un objeto Factura 
            //Arrange
            int numFactura = 1;
            string nombreCliente = "Adriana";

            Producto prod = new Producto { IdProducto = 1, Nombre = "TestProduct", Precio = 200 };
            Item it = new Item { Cantidad = 2, Producto = prod };
            Factura fac = new Factura(numFactura, nombreCliente);

            //Act
            fac.AddItem(it);

            //Assert
            Assert.NotNull(fac.Items);
            Assert.AreEqual(fac.Items.Count, 1);
        }


    }
}
