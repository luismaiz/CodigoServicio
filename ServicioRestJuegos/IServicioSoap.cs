using System;
using System.ComponentModel;
using System.ServiceModel;
using ServicioWcfSoapRest.Core;

namespace ServicioWcfSoapRest
{
    [ServiceContract]
    [Description("Interfaz para los metodos expuestos por SOAP")]
    public interface IServicioSoap
    {
        [OperationContract]
        [Description("Recibe el id y devuelve la informacion de la persona.")]
        ResponseJuego GetJuego(String nombre);
    }
}
