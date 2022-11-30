using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_Facturadora
{
    public class Mercancia
    {
        private string nombre;
        private string codigo;
        private int precio;
        private float precio_total;
        private string exhibicion;

        readonly float iva;

        public Mercancia()
        {
            nombre = " ";
            codigo = " ";
            precio = 0;
            precio_total = 0;
            exhibicion = "";

            iva = 0.19f;
        }

        public Mercancia(string nombre, string codigo, int precio)
        {
            try
            {
                this.nombre = nombre;
                this.codigo = codigo;
                this.precio = precio;

                iva = 0.19f;
                exhibicion = nombre + "\t$" + precio + "\t" + codigo;

                precio_total = precio + (precio * iva);
            }
            catch (Exception E)
            {
                throw new Exception("Ha ocurrido un error al crear el producto: \n" + E.Message);
            }
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public int Precio { get => precio; set => precio = value; }
        public float Precio_total { get => precio_total; set => precio_total = value; }

        public float Iva => iva;

        public string Exhibicion { get => exhibicion; set => exhibicion = value; }
    }
}
