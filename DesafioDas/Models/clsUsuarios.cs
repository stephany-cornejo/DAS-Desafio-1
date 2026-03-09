using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DesafioDas.Models
{
    public class clsUsuarios
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;

        private bool DatosCompletos;
        private string ultimoError = string.Empty;

        public bool datosCompletos_aceptados => DatosCompletos;
        public string UltimoError => ultimoError;

        public clsUsuarios(string nom, string correo)
        {
            ValidarDatos(nom, correo);
        }

        public bool ValidarDatos(string nom, string correo)
        {
            ultimoError = string.Empty;
            DatosCompletos = false;

            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(correo))
            {
                ultimoError = "Faltan datos obligatorios";
                return false;
            }

            FullName = nom.Trim();
            Correo = correo.Trim();

            DatosCompletos = true;
            return true;
        }

        public override string ToString()
        {
            return FullName;
        }
    }
}
