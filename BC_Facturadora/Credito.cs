using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_Facturadora
{
    public class Credito : Venta
    {
        private int plazo;
        private float cuotas;
        private int c_Pagadas;
        private bool cancelado;

        readonly float recargo;

        public Credito(short plazo, float valor, string tipo) : base(valor, tipo)
        {
            try
            {
                this.plazo = plazo;

                c_Pagadas = 0;
                cancelado = false;
                recargo = 0.12f;
            }
            catch(Exception E)
            {
                throw new Exception("Ha ocurrido un errror al realizar la compra: \n" + E.Message);
            }
        }

        public float Cuotas { get => cuotas; set => cuotas = value; }
        public int C_Pagadas { get => c_Pagadas; set => c_Pagadas = value; }
        public bool Cancelado { get => cancelado; set => cancelado = value; }
        public int Plazo { get => plazo; set => plazo = value; }

        public float Recargo => recargo;

        public override void Realizar_Pago()
        {
            try
            {
                if (cancelado == false)
                {
                    c_Pagadas = c_Pagadas + 1;
                    if(c_Pagadas == plazo)
                    {
                        cancelado = true;
                        Pagado = true;
                    }
                }
            }
            catch(Exception E)
            {
                throw new Exception("Ha ocurrido un error al realizar el pago: \n" + E.Message);
            }
        }
    }
}
