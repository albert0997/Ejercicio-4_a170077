using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Calculararea
{
    /// <summary>
    /// Descripción breve de Areasdefiguras
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Areasdefiguras : System.Web.Services.WebService
    {

        
        [WebMethod]
        public decimal AreadeCuadrado(decimal lado)
        {
            Figuras c = new Figuras();
            return c.calcularcuadrado(lado);
        }

        [WebMethod]
        public decimal AreadeTriangulo(decimal lado, decimal altura)
        {
            Figuras c = new Figuras();
            return c.calculatriangulo(lado, altura);
        }

        [WebMethod]
        public decimal AreadeunCirculo(decimal radio)
        {
            Figuras c = new Figuras();
            return c.calcularcirculo(radio);
        }
    }
}
