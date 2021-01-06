using System;
using escuelaCore.App;
using escuelaCore.Util;
using escuelaCore.Entidades;

namespace escuelaCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            Print.Titulos();
            ImprimirMateriaEscuela(engine.escuela);

        }

        private static void ImprimirMateriaEscuela(Escuela escuela)
        {
            Console.WriteLine(escuela.Nombre);
            if (escuela?.Grupo != null)
            {
                foreach (var grupo in escuela.Grupo)
                {
                    System.Console.WriteLine($"Nombre: {grupo.Nombre}, Horario: {grupo.horario} , Id:  {grupo.UniqueId}");
                    foreach (var materia in grupo.Materias)
                    {
                        System.Console.WriteLine($"    Materia: {materia.Nombre}, Id Materia: {materia.UniqueId}");
                    }
                }
            }
        }
    }
}
