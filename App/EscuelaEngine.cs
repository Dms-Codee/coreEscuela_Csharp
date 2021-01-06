using System;
using System.Collections.Generic;
using escuelaCore.Entidades;

namespace escuelaCore.App
{
    public class EscuelaEngine
    {


        // Propiedad que tiene como función ser un contenedor de tipo escuela 
        public Escuela escuela { get; set; }

        public void Inicializar()
        {
            escuela = new Escuela("16 de Septiembre ", 1984, TiposEscuela.MediaSuperior);
            CargarGrupos();
            CargarMaterias();
        }

        private void CargarGrupos()
        {
            escuela.Grupo = new List<Grupo>(){
                new Grupo(){Nombre = "101",horario=TipoHorario.Matutino},
                new Grupo(){Nombre = "201",horario=TipoHorario.Matutino},
                new Grupo(){Nombre = "301",horario=TipoHorario.Matutino},
                new Grupo(){Nombre = "161",horario=TipoHorario.Intermedio}
           };
        }

        private void CargarMaterias()
        {
            foreach (var grupo in escuela.Grupo)
            {
                 grupo.Materias  = new List<Materia>(){
                    //  Se crea colección - Lista Generica
                    new Materia { Nombre = "Biologia"},
                    new Materia{ Nombre = "Matematicas"},
                    new Materia{ Nombre = "Electronica"},
                    new Materia{ Nombre = "Programación"}
                  };
                   
            }
        }



        private void CargarAlumnos()
        {




        }

    }
}