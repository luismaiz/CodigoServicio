using System;
using System.Runtime.Serialization;

namespace ServicioWcfSoapRest.Core
{
    [DataContract]
    public class ResponseJuego
    {
        [DataMember]
        public String ResponseCode { get; set; }

        [DataMember]
        public String ResponseMessage { get; set; }

        [DataMember]
        public String CantJuegosEncontrados { get; set; }

        [DataMember]
        public Juego JuegoEncontrado { get; set; }
    }

    [DataContract]
    public class Juego
    {
        [DataMember]
        public String Ruta { get; set; }

        [DataMember]
        public String Nombre { get; set; }

        [DataMember]
        public String Descripcion { get; set; }

        [DataMember]
        public byte[] Imagen { get; set; }

    }
}