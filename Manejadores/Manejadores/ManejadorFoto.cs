using System;
using System.Collections.Generic;
using System.Text;
using Dominio.Entidades;
using Dominio.Interfaces;
using Repositorios;
using Manejadores.IManejadores;

namespace Manejadores.Manejadores
{
    public class ManejadorFoto : IManejadorFoto
    {
        public IRepositorioFoto RepoFoto { get; set; }
        public ManejadorFoto(IRepositorioFoto repoFoto)
        {
            RepoFoto = repoFoto;
        }


        public string CambiarNombreFoto(Producto producto)
        {
            throw new NotImplementedException();
        }

        public bool DarDeAltaFoto(Foto foto, int idProducto)
        {
            throw new NotImplementedException();
        }

        public bool EliminarFoto(int idFoto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Foto> obtenerFotosPorIdProducto(int idPRoducto)
        {
            throw new NotImplementedException();
        }
    }
}
