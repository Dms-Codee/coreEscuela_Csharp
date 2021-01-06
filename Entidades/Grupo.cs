using System.Collections.Generic;

using System;

namespace escuelaCore.Entidades
{
    public class Grupo
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public List<Materia> Materias { get; set; }      
        public List<Alumno> Alumnos { get; set; }      


        public TipoHorario horario { get; set; }

       public Grupo() =>  UniqueId=Guid.NewGuid().ToString();
       

    }
}