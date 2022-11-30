using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_Facturadora
{
    public class Tarjeta : Venta
    {
        private string tipo_Tarjeta;

        public Tarjeta(string tipo_Tarjeta, float valor, string tipo):base(valor, tipo)
        {
            try
            {
                this.tipo_Tarjeta = tipo_Tarjeta;
            }
            catch(Exception E)
            {
                throw new Exception("Ha ocurrido un eror al realizar la compra: \n" + E.Message);
            }
        }

        public string Tipo_Tarjeta { get => tipo_Tarjeta; set => tipo_Tarjeta = value; }
    }
}
