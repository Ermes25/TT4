using EL;
using Registros;

class ID
{
    static void Main(string[] args)
    {
        Roles usuarios = new();
        usuarios.IDroles = 1;
        usuarios.Rol = "Desarrollador WebSite";
        usuarios.Active = true;
        usuarios.IDuser = 248;
        usuarios.Fechita = DateTime.Today;
        usuarios.IDUserAct = 248;
        usuarios.FechitaAct = DateTime.Now;

        Console.WriteLine("bienvenidos a los Roles \n");
        Console.WriteLine("Este es tu ID:" + usuarios.IDroles);
        Console.WriteLine("Tu rol es:" + usuarios.Rol);
        Console.WriteLine("Tu rol esta Activo:" + usuarios.Active);
        Console.WriteLine("Tu Usuario es:" + usuarios.IDuser);
        Console.WriteLine("La ultima fecha de registro:" + usuarios.Fechita);
        Console.WriteLine("El usuario Actualizado es:" + usuarios.IDUserAct);
        Console.WriteLine("Fecha de actualizacion: "+usuarios.FechitaAct);


        Usuer user = new();
        user.IDusuarios = 234;
        user.Nombrecompleto = "Ernesto Gamez";
        user.Email = "jose1725@gmail.com";
        user.Password = byte.MaxValue;
        user.block = false;
        user.Fallidos = 0;
        user.IDroles = 2;
        user.Active = true;
        user.IDuser = user.IDusuarios;
        user.Fechita = DateTime.Today;
        user.IDUserAct = 2;
        user.FechitaAct = DateTime.Now;


        Console.WriteLine("\n");
        Console.WriteLine("bienvenidos a los Usuarios");
        Console.WriteLine("\n");
        Console.WriteLine("Tu usuario es: "+user.IDusuarios);
        Console.WriteLine("Tu Datos de nombres:" + user.Nombrecompleto);
        Console.WriteLine("tu correo Electronico es:" + user.Email);
        Console.WriteLine("contraseña:" + user.Password);
        Console.WriteLine("paso:" + user.block);
        Console.WriteLine("intentos fallidos: " + user.Fallidos);
        Console.WriteLine("ID de tus roles:" + user.IDroles);
        Console.WriteLine("Esta Activo: " + user.Active);
        Console.WriteLine("ID del usuario:" + user.IDuser);
        Console.WriteLine("la fecha ingresada del usuario fue:" + user.Fechita);
        Console.WriteLine("El ID del usuario Actualizada:" + user.IDUserAct);
        Console.WriteLine("la fecha de hoy en: "+ user.FechitaAct);


        formularios formulario = new();
        formulario.IdFormularios = 3;
        formulario.Formularia = "Como estas viajero";
        formulario.Active = true;
        formulario.IDuser = 4;
        formulario.Fechita = DateTime.Today;
        formulario.IDUserAct = 4;
        formulario.FechitaAct = DateTime.Now;

        Console.WriteLine("\n");
        Console.WriteLine("Bienvenidos a los formularios:" );
        Console.WriteLine("\n");
        Console.WriteLine(formulario.IdFormularios);
        Console.WriteLine(formulario.Formularia);
        Console.WriteLine("activo: " + formulario.Active);
        Console.WriteLine("tu ID es:" + formulario.IDuser);
        Console.WriteLine("La fecha de registro fue: " + formulario.Fechita);
        Console.WriteLine("El ID del usuario Actualizada:" + user.IDUserAct);
        Console.WriteLine("la fecha de hoy en: " + user.FechitaAct);

        Permiso probality = new();
        probality.Idpermisos = 3;
        probality.Permisos = "negado";
        probality.Active=true;
        probality.IDuserregistre = 5;
        probality.Fechita = DateTime.Today;
        probality.IDUserAct = 5;
        probality.FechitaAct = DateTime.Now;



        Console.WriteLine("\n");
        Console.WriteLine("Bienvenidos a los permisos:" );
        Console.WriteLine("\n");
        Console.WriteLine(probality.Idpermisos);
        Console.WriteLine("activo: " + probality.Active);
        Console.WriteLine("tu ID es:" + probality.IDuserregistre);
        Console.WriteLine("La fecha de registro fue: " + probality.Fechita);
        Console.WriteLine("El ID del usuario Actualizada:" + probality.IDUserAct);
        Console.WriteLine("la fecha de hoy en: " + probality.FechitaAct);

        RolFormularios pdf = new();
        pdf.IdFormularios = 6;

        Console.WriteLine("\n");
        Console.WriteLine("Bienvenidos a los Roles de los Formularios:" );
        Console.WriteLine("\n");
        Console.WriteLine("Id de los roles y Formularios: " + pdf.IdFormularios);
        Console.WriteLine(pdf.IdRol);
        Console.WriteLine(pdf.IdFormularios);
        Console.WriteLine("tu ID es:" + probality.IDuserregistre);
        Console.WriteLine("La fecha de registro fue: " + probality.Fechita);
        Console.WriteLine("El ID del usuario Actualizada:" + probality.IDUserAct);
        Console.WriteLine("la fecha de hoy en: " + probality.FechitaAct);


        Rolespermisos dd = new();
        dd.IDrolpermisos = 8;

        Console.WriteLine("\n");
        Console.WriteLine("Bienvenidos a los Roles de los permisos:");
        Console.WriteLine("\n");
        Console.WriteLine(dd.IDrolpermisos);
        Console.WriteLine(dd.Rol);
        Console.WriteLine(dd.IDrolpermisos);
        Console.WriteLine(dd.IdFormularios);
        Console.WriteLine("activo: " + dd.Active);
        Console.WriteLine("tu ID es:" + dd.IDuserregistre);
        Console.WriteLine("La fecha de registro fue: " + dd.Fechita);
        Console.WriteLine("El ID del usuario Actualizada:" + dd.IDUserAct);
        Console.WriteLine("la fecha de hoy en: " + dd.FechitaAct);



        Console.ReadKey();


    }


}