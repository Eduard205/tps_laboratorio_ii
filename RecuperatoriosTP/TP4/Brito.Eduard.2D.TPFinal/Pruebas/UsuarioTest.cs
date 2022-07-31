using Biblioteca;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    
    [TestClass]
    public class UsuarioTest
    {
        [TestMethod]
        public void ComprobarPassword_CuandoDatoIngresadoEsNull_RetornarFalse()
        {
            string datoIngresado = null;
            Usuario usuarioAux = new Usuario(1,"xxx",datoIngresado);
            bool resultadoEsperado = false;

            bool resultado = usuarioAux.ComprobarPassword(datoIngresado);

            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
