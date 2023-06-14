namespace Registros;

public class Roles
{
        public Roles()
        {
            IDroles = 0;
            Rol = string.Empty;
            Active = true;
            IDuser = 0;
            Fechita = DateTime.Now;
            IDUserAct = 0;
            FechitaAct = DateTime.Now;
        }

        public int IDroles { get; set; }
        public string Rol { get; set; }
        public bool Active { get; set; }
        public int IDuser { get; set; }
        public DateTime Fechita { get; set; }
        public int IDUserAct { get; set; }
        public DateTime FechitaAct { get; set;}

}
