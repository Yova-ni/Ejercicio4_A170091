using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Areas1
{
    /// <summary>
    /// Descripción breve de Areacalculo
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Areacalculo : System.Web.Services.WebService
    {

       
        [WebMethod]
        public decimal Cuadrado(decimal lado)
        {
            Areacalculo1 c = new Areacalculo1();
            return c.areacuadrado(lado);
        }

        [WebMethod]
        public decimal Triangulo(decimal base1, decimal altura)
        {
            Areacalculo1 c = new Areacalculo1();
            return c.areatriangulo(base1, altura);
        }

        [WebMethod]
        public decimal Areacirculo(decimal radio)
        {
            Areacalculo1 c = new Areacalculo1();
            return c.areacirculo(radio);
        }
    }
}
