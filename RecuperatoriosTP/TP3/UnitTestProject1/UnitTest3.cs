using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using EntidadesInstanciables;
using EntidadesAbstractas;
using Archivos;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest3
    {
        /// <summary>
        /// Test unitario para ver que los valores no sean nulos
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            Profesor p = new Profesor(3, "nombre", "apellido", "123123", Persona.ENacionalidad.Argentino);
            Jornada j = new Jornada(Universidad.EClases.Programacion, p);

            Assert.IsNotNull(p.DNI);
            Assert.IsNotNull(p.Apellido);
            Assert.IsNotNull(p.Nacionalidad);
            Assert.IsNotNull(p.Nombre);

            Assert.IsNotNull(j.Alumnos);
            Assert.IsNotNull(j.Clase);
            Assert.IsNotNull(j.Instructor);

               

        }
    }
}
