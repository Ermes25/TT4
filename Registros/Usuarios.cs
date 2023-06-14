using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registros;

namespace EL
{
    public class Usuer
    {
        public Usuer()
        {
            IDusuarios = 0;
            Nombrecompleto = string.Empty;
            Email = string.Empty;
            UserName = string.Empty;
            Password = 0;
            block = true;
            Fallidos = 0;
            IDroles = 0;
            Active = true;
            IDuser = 0;
            Fechita = DateTime.Now;
            IDUserAct = 0;
            FechitaAct = DateTime.Now;


        }
        

        public int IDusuarios { get; set; }
        public string Nombrecompleto { get; set; }
        public string? Email { get; set; }
        public string? UserName { get; set; }
        public byte? Password { get; set; }
        public bool block { get; set; }
        public int Fallidos { get; set; }
        public int IDroles { get; set; }
        public bool Active { get; set; }
        public int IDuser { get; set; }
        public DateTime Fechita { get; set; }
        public int IDUserAct { get; set; }
        public DateTime FechitaAct { get; set; }
    }
}
