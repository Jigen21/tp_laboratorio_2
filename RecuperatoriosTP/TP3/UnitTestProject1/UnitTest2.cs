using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using EntidadesInstanciables;
using EntidadesAbstractas;
using Archivos;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        /// <summary>
        /// test unitario para nacionalidad invalida
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            string dni = "121";

            try
            {
                Alumno alum = new Alumno(3, "prueba","yerror", dni, Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio);
                Assert.Fail("sin excepcion para dni invalido" + dni);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(NacionalidadInvalidaException));
            }
        }
    }
}
