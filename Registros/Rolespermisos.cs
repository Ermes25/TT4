using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Rolespermisos
    {
        public Rolespermisos() 
        {
            IDrolpermisos = 0;
            Rol = string.Empty;
            IdFormularios = 0;
            Active = false;
            IDuserregistre = 0;
            Fechita = DateTime.Now;
            IDUserAct = 0;
            FechitaAct = DateTime.Now;

        }
        public int IDrolpermisos { get; set; }
        public string Rol { get; set; }
        public bool Active { get; set; }
        public int IDuserregistre { get; set; }
        public DateTime Fechita { get; set; }
        public int IDUserAct { get; set; }
        public DateTime FechitaAct { get; set; }

        public int IdFormularios { get; set; }
    }
}
