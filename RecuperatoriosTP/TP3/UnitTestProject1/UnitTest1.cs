using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using EntidadesInstanciables;
using EntidadesAbstractas;
using Archivos;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// test unitario para dni invalido
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            string dni = "asda/d432dsa";

            try
            {
                Alumno alum = new Alumno(3, "prueba","yerror", dni, Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
                Assert.Fail("sin excepsion para dni invalido" + dni);
            }
            catch(Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(DniInvalidoException));
            }

        }
    }
}
