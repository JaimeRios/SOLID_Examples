using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Examples.Solid_class
{
    // O – Open/Closed Principle (OCP)
    // 👉 El código debe estar abierto para extensión, pero cerrado para modificación.
    // ✔ Puedes agregar nuevos descuentos sin modificar el código existente.

    public abstract class Descuento
    {
        public abstract double Calcular(double precio);
    }

    public class DescuentoNormal : Descuento
    {
        public override double Calcular(double precio)
        {
            return precio * 0.9;
        }
    }

    public class DescuentoVIP : Descuento
    {
        public override double Calcular(double precio)
        {
            return precio * 0.8;
        }
    }

    
}
