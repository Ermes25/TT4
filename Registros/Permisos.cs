using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registros;

namespace EL
{
    public class Permiso
    {
        public Permiso() 
        {
            Idpermisos = 0;
            Permisos = string.Empty;
            Active = false;
            IDuserregistre = 0;
            Fechita = DateTime.Now;
            IDUserAct = 0;
            FechitaAct = DateTime.Now;
        }
        public int Idpermisos { get; set; }
        public string Permisos { get; set;}
        public bool Active { get; set; }
        public int IDuserregistre { get; set; }
        public DateTime Fechita { get; set; }
        public int IDUserAct { get; set; }
        public DateTime FechitaAct { get; set; }

    }
}
