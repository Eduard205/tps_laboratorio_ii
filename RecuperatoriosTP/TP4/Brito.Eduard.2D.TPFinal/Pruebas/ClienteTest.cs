using Biblioteca;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Pruebas
{
    [TestClass]
    public class ClienteTest
    {
        [TestMethod]
        public void BuscarCliente_CuandoNoEncuentraAlCliente_DeberiaRetornarNul()
        {
            Random ranDni = new Random();
            int dni = ranDni.Next(1, 99999999);
            List<Cliente> listaClientes = new List<Cliente>();
            Cliente resultadoEsperado = null;

            Cliente resultado = Cliente.BuscarCliente(listaClientes, dni);

            Assert.AreEqual(resultadoEsperado, resultado);  
        }
    }
}
