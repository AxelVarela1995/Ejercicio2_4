using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2_4.Models
{
    public class Video
    {
        [PrimaryKey, AutoIncrement]
        public int codigo { get; set; }

        [MaxLength(100)]
        public String nombre { get; set; }

        [MaxLength(255)]
        public String descripcion { get; set; }

        public String ruta { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
