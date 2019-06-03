using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_11
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Gestionador gestionador;
            gestionador = new Gestionador();

            if(gestionador.Locales.Count == 0)
            {
                List<Local> locales = new List<Local>();
                Cine cine = new Cine(1, "16:30", "Cine", 20);
                Tienda tienda = new Tienda(2, "12:30", "tienda", "ropa");
                Restaurante restaurante = new Restaurante(3, "13:00", "restaurante", true);
                Recreacion recreacion = new Recreacion(4, "22:00", "Disco", "Barra libre");

                locales.Add(cine);
                locales.Add(tienda);
                locales.Add(restaurante);
                locales.Add(recreacion);

                gestionador.Locales = locales;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(gestionador));
        }
    }
}
