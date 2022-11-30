using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_Facturadora
{
    public abstract class Venta
    {
        private List<Mercancia> producto;
        private float valor;
        private string tipo;
        private bool pagado;
        private float descuento;

        public Venta()
        {
            producto = new List<Mercancia>();
            valor = 0;
            tipo = "Contado";
            pagado = false;
            descuento = 0;
        }

        public Venta(float valor, string tipo)
        {
            try
            {
                producto = new List<Mercancia>();

                this.valor = valor;
                this.tipo = tipo;
                pagado = false;
                descuento = 0.03f;
            }
            catch(Exception E)
            {
                throw new Exception("Ha ocurrido un errror al realizar la compra: \n" + E.Message);
            }
        }

        public float Valor { get => valor; set => valor = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public bool Pagado { get => pagado; set => pagado = value; }
        public List<Mercancia> Producto { get => producto; set => producto = value; }
        public float Descuento { get => descuento; set => descuento = value; }

        public virtual void Realizar_Pago()
        {
            try
            {
                pagado = true;
            }
            catch(Exception E)
            {
                throw new Exception("Ha ocurrido un error al realizar el pago: \n" + E.Message);
            }
        }
    }
}
