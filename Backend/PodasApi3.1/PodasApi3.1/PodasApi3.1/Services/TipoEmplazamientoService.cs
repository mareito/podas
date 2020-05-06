using PodasApi.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PodasApi3._1.Services
{
    public class TipoEmplazamientoService : ITipoEmplazamiento
    {
        public void deleteTipoEmplazamiento(TipoEmplazamientoDTO tipoEmplazamiento)
        {            
        }

        public TipoEmplazamientoDTO getTipoEmplazamiento(int id)
        {
            return new TipoEmplazamientoDTO
            {
                
            };
        }

        public List<TipoEmplazamientoDTO> getTiposEmplazamientos()
        {
            return new List<TipoEmplazamientoDTO>() {
                new TipoEmplazamientoDTO{}
            };
        }

        public void saveTipoEmplazamiento(TipoEmplazamientoDTO tipoEmplazamiento)
        {            
        }

        public void updateTipoEmplazamiento(TipoEmplazamientoDTO tipoEmplazamiento)
        {          
        }
    }
}
