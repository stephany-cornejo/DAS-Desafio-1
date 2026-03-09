using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioDas.Models
{
    public class clsPrestamos
    {
        public int Id { get; set; }
        public int IdLibro { get; set; }
        public int IdUsuario { get; set; }
        public string NombreLibro { get; set; }
        public string NombreUsuario { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }

        public clsPrestamos(int idLibro, int idUsuario, string nombreLibro, string nombreUsuario, DateTime fechaPre, DateTime fechaDe)
        {
            IdLibro = idLibro;
            IdUsuario = idUsuario;
            NombreLibro = nombreLibro;
            NombreUsuario = nombreUsuario;
            FechaPrestamo = fechaPre;
            FechaDevolucion = fechaDe;
        }

        public override string ToString()
        {
            return $"{NombreLibro} - {NombreUsuario}";
        }
    }
}
