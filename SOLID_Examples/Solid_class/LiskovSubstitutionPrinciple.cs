using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Examples.Solid_class
{
    // L – Liskov Substitution Principle (LSP)
    // 👉 Una clase hija debe poder reemplazar a la clase padre sin errores.
    // ✔ Todas las aves pueden usarse como Ave sin romper el programa.

    public abstract class Ave
    {
        public abstract void Moverse();
    }

    public class Pato : Ave
    {
        public override void Moverse()
        {
            Console.WriteLine("El pato nada");
        }
    }

    public class Gallina : Ave
    {
        public override void Moverse()
        {
            Console.WriteLine("La gallina camina");
        }
    }
}
