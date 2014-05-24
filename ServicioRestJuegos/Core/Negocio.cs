using System;
using System.Collections.Generic;
using System.Linq;

namespace ServicioWcfSoapRest.Core
{
    internal static class Negocio
    {
        //Objeto base para la respuesta del metodo de consulta.
        private static ResponseJuego _response;

        //Consulta los datos basicos de un juego.
        internal static ResponseJuego ConsultarJuego(String nombre)
        {
            _response = new ResponseJuego()
            {
                ResponseCode = String.Empty,
                ResponseMessage = String.Empty,
                CantJuegosEncontrados = "0",
                JuegoEncontrado = new Juego()
            };

            try
            {
                //Se consulta el juego.
                var juego = JuegoDataSource.Juegos.FirstOrDefault(j => j.Nombre == nombre);

                if (juego == null)
                {
                    //Si no se encuentra el juego se envia el mensaje correspondiente.
                    _response.ResponseCode = Mensajes.JuegoNoEncontrado;
                    _response.ResponseMessage = String.Format(Mensajes.MensajesJuegoNoEncontrado, nombre);
                }
                else
                {
                    //Si se encuentra el juego se envia en la respuesta.
                    _response.ResponseCode = Mensajes.OK;
                    _response.ResponseMessage = Mensajes.MensajeOK;
                    _response.CantJuegosEncontrados = "1";
                    _response.JuegoEncontrado = juego;
                }
            }
            catch (Exception ex)
            {
                //Si ocurre una excepcion se envia un mensaje indicandolo.
                _response.ResponseCode = Mensajes.Error;
                _response.ResponseMessage = String.Format(Mensajes.MensajeError, ex.Message);
            }

            return _response;
        }
    }
}