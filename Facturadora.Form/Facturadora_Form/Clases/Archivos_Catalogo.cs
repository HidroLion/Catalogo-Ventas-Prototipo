using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC_Facturadora;
using System.IO;

namespace Facturadora_Form.Clases
{
    class Archivos_Catalogo
    {
        List<Mercancia> productos = new List<Mercancia>();

        public List<Mercancia> Catalogo_Archivos(string Lista_Productos)
        {
            Mercancia Producto;

            StreamReader lector;
            string linea;
            string[] vectorSplit;

            lector = new StreamReader(Lista_Productos);
            linea = lector.ReadLine();

            while (linea != null)
            {
                vectorSplit = linea.Split('|');
                Producto = new Mercancia(vectorSplit[0], vectorSplit[1], int.Parse(vectorSplit[2]));
                productos.Add(Producto);

                linea = lector.ReadLine();
            }

            return productos;
        }
    }
}
