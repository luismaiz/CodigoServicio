using System;
using System.ComponentModel;
using System.ServiceModel;
using System.ServiceModel.Web;
using ServicioWcfSoapRest.Core;

namespace ServicioWcfSoapRest
{
    [ServiceContract]
    [Description("Interfaz para los metodos expuestos por REST")]
    public interface IServicioRest
    {
        //Contratos para Obtener informacion en Xml.

        [OperationContract]
        [WebInvoke(
            Method = "GET",
            UriTemplate = "GetJuegoXml/{nombre}",
            RequestFormat = WebMessageFormat.Xml,
            ResponseFormat = WebMessageFormat.Xml,
            BodyStyle = WebMessageBodyStyle.WrappedRequest),
        Description("Recibe el nombre y retorna la informacion del Juego en formato XML.")]
        ResponseJuego GetJuegoXml(String nombre);

    }
}