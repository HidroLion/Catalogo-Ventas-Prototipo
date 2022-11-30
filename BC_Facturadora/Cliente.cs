using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_Facturadora
{
    public class Cliente
    {
        private string nombre;
        private bool cuenta;
        private Venta compra;

        public Cliente()
        {
            nombre = " ";
            cuenta = false;
        }

        public Cliente(string nombre, bool cuenta)
        {
            try
            {
                this.nombre = nombre;
                this.cuenta = cuenta;
            }
            catch(Exception E)
            {
                throw new Exception("Ha ocurrido un eror al crear la Base de datos de Cliente: \n" + E.Message);
            }
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public bool Cuenta { get => cuenta; set => cuenta = value; }
        public Venta Compra { get => compra; set => compra = value; }

        public void Realizar_Compra(List<Mercancia> mercancias, string tipo_compra, bool cuenta)
        {
            try
            {
                float valor_total = 0;

                switch (tipo_compra)
                {
                    case "Efectivo":
                        Efectivo Compra_Efectivo = new Efectivo(valor_total, tipo_compra);

                        foreach (Mercancia S in mercancias)
                        {
                            valor_total = valor_total + S.Precio_total;
                            Compra_Efectivo.Producto.Add(S);
                        }
                        if (!cuenta)
                        {
                            Compra_Efectivo.Valor = valor_total;
                        }
                        else
                        {
                            Compra_Efectivo.Descuento = 0.05f;
                            Compra_Efectivo.Valor = valor_total - (valor_total * Compra_Efectivo.Descuento);
                        }
                        compra = Compra_Efectivo;
                        break;

                    case "Tarjeta Debito":
                        Tarjeta Compra_TD = new Tarjeta("Debito", valor_total, tipo_compra);

                        foreach(Mercancia M in mercancias)
                        {
                            valor_total = valor_total + M.Precio_total;
                            Compra_TD.Producto.Add(M);
                        }
                        if (!cuenta)
                        {
                            Compra_TD.Valor = valor_total;
                        }
                        else
                        {
                            Compra_TD.Valor = valor_total - (valor_total * Compra_TD.Descuento);
                        }
                        compra = Compra_TD;
                        break;

                    case "Tarjeta Credito":
                        Tarjeta Compra_TC = new Tarjeta("Credito", valor_total, tipo_compra);

                        foreach (Mercancia M in mercancias)
                        {
                            valor_total = valor_total + M.Precio_total;
                            Compra_TC.Producto.Add(M);
                        }
                        if (!cuenta)
                        {
                            Compra_TC.Valor = valor_total;
                        }
                        else
                        {
                            Compra_TC.Valor = valor_total - (valor_total * Compra_TC.Descuento);
                        }
                        compra = Compra_TC;
                        break;

                    case "Compra Web":
                        Internet Compra_Web = new Internet(valor_total, tipo_compra);

                        foreach (Mercancia S in mercancias)
                        {
                            valor_total = valor_total + S.Precio_total;
                            Compra_Web.Producto.Add(S);
                        }
                        if (!cuenta)
                        {
                            Compra_Web.Valor = valor_total;
                        }
                        else
                        {
                            Compra_Web.Valor = valor_total - (valor_total * Compra_Web.Descuento);
                        }
                        compra = Compra_Web;
                        break;
                }
            }
            catch(Exception E)
            {
                throw new Exception("Ha ocurrido un error al realizar la compra: \n " + E.Message);
            }
        }

        public void Realizar_Compra(List<Mercancia> mercancias, string tipo_venta, short plazo, bool cuenta)
        {
            try
            {
                float valor_total = 0;

                Credito Compra_Credito = new Credito(plazo, valor_total, tipo_venta);

                foreach(Mercancia M in mercancias)
                {
                    valor_total = valor_total + M.Precio_total;
                    Compra_Credito.Producto.Add(M);
                }
                valor_total = (valor_total) + (valor_total * Compra_Credito.Recargo);

                if (!cuenta)
                {
                    Compra_Credito.Valor = valor_total;
                }
                else
                {
                    Compra_Credito.Valor = valor_total - (valor_total * Compra_Credito.Descuento);
                }

                Compra_Credito.Cuotas = (Compra_Credito.Valor / plazo);

                compra = Compra_Credito;
            }
            catch(Exception E)
            {
                throw new Exception("Ha ocurrido un error al realizar la compra: \n" + E.Message);
            }
        }
    }
}
