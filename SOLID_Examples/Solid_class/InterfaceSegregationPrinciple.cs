using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Examples.Solid_class
{
    // I – Interface Segregation Principle (ISP)
    // 👉 Es mejor muchas interfaces pequeñas que una grande.
    // ✔ La clase solo implementa lo que realmente necesita.

    public interface IImprimir
    {
        void Imprimir();
    }

    public interface IEscanear
    {
        void Escanear();
    }

    public class ImpresoraSimple : IImprimir
    {
        public void Imprimir()
        {
            Console.WriteLine("Imprimiendo...");
        }
    }

}
