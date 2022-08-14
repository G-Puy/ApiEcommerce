using System;
using System.Collections.Generic;
using System.Text;
using Dominio.Entidades;

namespace Manejadores.IManejadores
{
    public interface IManejadorFoto
    {
        bool DarDeAltaFoto(Foto foto, int idProducto);
        IEnumerable<Foto> obtenerFotosPorIdProducto(int idPRoducto);
        string CambiarNombreFoto(Producto producto);
        bool EliminarFoto(int idFoto);

    }
}
