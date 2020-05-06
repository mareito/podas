using System;
using System.Collections.Generic;
using System.Text;

namespace PodasApi.Entities
{
    public class ConvertirEstados
    {
        public static string ConvertirEstado(Estados estado)
        {

            switch (estado)
            {
                case Estados.ACTIVO:
                    return "A";
                case Estados.PENDIENTE:
                    return "P";
                case Estados.INACTIVO:
                    return "I";
                case Estados.RECHAZADO:
                    return "R";
                default:
                    throw new Exception("Estado no Definido");
            }
        }

        public static Estados ConvertirEstado(string estado)
        {
            switch (estado)
            {
                case "A":
                    return Estados.ACTIVO;
                case "P":
                    return Estados.PENDIENTE;
                case "I":
                    return Estados.INACTIVO;
                case "R":
                    return Estados.RECHAZADO;
                default:
                    throw new Exception("Estado no Definido");
            }
        }
    }
}
