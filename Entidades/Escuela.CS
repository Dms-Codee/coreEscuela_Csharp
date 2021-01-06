using System.Collections.Generic;

namespace escuelaCore.Entidades
{

    public class Escuela
    {
        public TiposEscuela TipoEscuela { get; set; }

        public List<Grupo> Grupo { get; set; }

        // public List<Materia> Materia { get; set; }

        private string nombre;
        public string Nombre { get { return "Enviado desde el getter " + nombre; } set { nombre = value; } }

        private int creacion;
        public int Creacion { get { return creacion - 2020; } set { creacion = value; } }



        // Constructor utilizando tuplas para asignación de parametros 
        public Escuela(string nombre, int creacion, TiposEscuela tipo)
                => (Nombre, Creacion, TipoEscuela) = (nombre, creacion, tipo);



        //    Sobrescribiendo metodo To String para observar el contenido de un objeto
        public override string ToString()
        {
            return $"Nombre: {nombre}, \n Tipo: {TipoEscuela},\n Creacion: {creacion}";
        }



    }
}