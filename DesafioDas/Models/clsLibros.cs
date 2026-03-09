using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DesafioDas.Models
{
    public class clsLibros
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public string Anio { get; set; } = string.Empty;

        private bool DatosCompletos;
        private string ultimoError = string.Empty;

        public bool datosCompletos_aceptados => DatosCompletos;
        public string UltimoError => ultimoError;

        public clsLibros(string titulo, string autor, string anio)
        {
            ValidarDatos(titulo, autor, anio);
        }

        public bool ValidarDatos(string titulo, string autor, string anio)
        {
            ultimoError = string.Empty;
            DatosCompletos = false;

            if (string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(autor) || string.IsNullOrWhiteSpace(anio))
            {
                ultimoError = "Faltan datos obligatorios";
                return false;
            }

            Titulo = titulo.Trim();
            Autor = autor.Trim();
            Anio = anio.Trim();

            DatosCompletos = true;
            return true;
        }

        public override string ToString()
        {
            return Titulo;
        }
    }
}
