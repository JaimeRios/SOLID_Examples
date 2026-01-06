using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Examples.Solid_class
{
    // D – Dependency Inversion Principle (DIP)
    // 👉 Depender de abstracciones, no de implementaciones concretas.
    // ✔ Puedes cambiar Email por SMS sin modificar ServicioNotificacion.

    public interface INotificacion
    {
        void Enviar(string mensaje);
    }

    public class EmailNotificacion : INotificacion
    {
        public void Enviar(string mensaje)
        {
            Console.WriteLine("Enviando email: " + mensaje);
        }
    }

    public class ServicioNotificacion
    {
        private INotificacion _notificacion;

        public ServicioNotificacion(INotificacion notificacion)
        {
            _notificacion = notificacion;
        }

        public void Notificar(string mensaje)
        {
            _notificacion.Enviar(mensaje);
        }
    }

}
