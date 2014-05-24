using System;
using System.ServiceModel.Activation;
using ServicioWcfSoapRest.Core;

namespace ServicioWcfSoapRest
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class Servicio : IServicioSoap, IServicioRest
    {
        //Metodos expuestos en SOAP.

        public ResponseJuego GetJuego(String nombre)
        {
            return Negocio.ConsultarJuego(nombre);
        }
        
        //Metodos expuestos en REST.

        public ResponseJuego GetJuegoXml(String nombre)
        {
            return Negocio.ConsultarJuego(nombre);
        }
        
    }
}
