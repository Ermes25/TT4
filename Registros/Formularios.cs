using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registros;

namespace EL
{
    public class formularios  
    { 
        public formularios()
        {
            IdFormularios = 0;
            Formularia = string.Empty;
            Active = true;
            IDuser = 0;
            Fechita = DateTime.Now;
            IDUserAct = 0;
            FechitaAct = DateTime.Now;

        }
        public int IdFormularios { get; set; }
        public string Formularia { get; set;}
        public bool Active { get; set; }
        public int IDuser { get; set; }
        public DateTime Fechita { get; set; }
        public int IDUserAct { get; set; }
        public DateTime FechitaAct { get; set; }
    }

   
}
