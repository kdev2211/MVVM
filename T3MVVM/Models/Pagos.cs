using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace T3MVVM.Models
{
   public class Pagos
    {
        [PrimaryKey, AutoIncrement]
        public int Id_empleados { get; set; }
        public String Apellidos { get; set; }
        public String Nombre { get; set; }
        public int Edad { get; set; }


        public String Direccion { get; set; }
        public String Puesto { get; set; }
    }
}
