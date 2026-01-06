using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Examples.Solid_class
{
    // S – Single Responsibility Principle (SRP)
    // 👉 Una clase debe tener una sola responsabilidad.
    // Clase que solo se encarga de manejar datos del usuario
    // ✔ Cada clase tiene una única razón para cambiar.
    public class Usuario
    {
        public string Nombre { get; set; }
    }

    // Clase que solo se encarga de guardar el usuario
    public class UsuarioRepositorio
    {
        public void Guardar(Usuario usuario)
        {
            Console.WriteLine("Usuario guardado en la base de datos");
        }
    }
}
