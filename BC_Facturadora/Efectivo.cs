using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_Facturadora
{
    public class Efectivo : Venta
    {
        public Efectivo() : base()
        {

        }

        public Efectivo(float valor, string tipo) : base(valor, tipo)
        {
            
        }
    }
}
