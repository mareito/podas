using PodasApi.Entities.Tables;
using System.Collections.Generic;

namespace PodasApi3._1.Services
{
    public interface ITipoEmplazamiento
    {
        public List<TipoEmplazamientoDTO> getTiposEmplazamientos();
        public TipoEmplazamientoDTO getTipoEmplazamiento(int id);
        public void saveTipoEmplazamiento(TipoEmplazamientoDTO tipoEmplazamiento);
        public void updateTipoEmplazamiento(TipoEmplazamientoDTO tipoEmplazamiento);
        public void deleteTipoEmplazamiento(TipoEmplazamientoDTO tipoEmplazamiento);
    }
}
