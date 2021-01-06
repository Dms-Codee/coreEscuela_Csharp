using System;

namespace escuelaCore.Entidades
{
    public class Materia
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        
   

       public Materia()
       {
           UniqueId=Guid.NewGuid().ToString();
       }

    }
}