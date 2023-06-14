using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registros;

namespace EL
{
    public class RolFormularios
    {
        public RolFormularios()
        {
            IdRolformularios = 0;
            IdRol = 0;
            IdFormularios = 0;
            Active = true;
            IDuserregistre = 0;
            Fechita = DateTime.Now;
            IDUserAct = 0;
            FechitaAct = DateTime.Now;


        }

        public int IdRolformularios { get; set; }
        public int IdRol {  get; set; }
        public int IdFormularios { get; set; }
        public bool Active { get; set; }
        public int IDuserregistre { get; set; }
        public DateTime Fechita { get; set; }
        public int IDUserAct { get; set; }
        public DateTime FechitaAct { get; set; }


    }
}
