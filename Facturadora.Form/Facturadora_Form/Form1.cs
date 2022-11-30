using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BC_Facturadora;
using Facturadora_Form.Clases;

namespace Facturadora_Form
{
    public partial class Tienda : Form
    {
        public Tienda()
        {
            InitializeComponent();
            L_Cuotas.Enabled = false;
            CB_Cuotas.Enabled = false;
        }

        private void B_Catalogo_Click(object sender, EventArgs e)
        {
            try
            {
                string Lista_Productos = " ";

                Archivos_Catalogo Catalogo = new Archivos_Catalogo();

                OpenFileDialog Archivo = new OpenFileDialog();
                Archivo.Filter = "TXT|*.txt";

                if (Archivo.ShowDialog() == DialogResult.OK)
                {
                    Lista_Productos = Archivo.FileName;
                    LB_Mercancia.DataSource = Catalogo.Catalogo_Archivos(Lista_Productos);
                }
            }
            catch(Exception E)
            {
                MessageBox.Show("Ha ocurrido un error: " + E.Message);
            }
        }

        private void B_Carrito_Click(object sender, EventArgs e)
        {
            try
            {
                Mercancia Compra = (Mercancia)LB_Mercancia.SelectedItem;
                Cliente comprador = new Cliente();

                LB_Carrito.DisplayMember = "Exhibicion";

                LB_Carrito.Items.Add(Compra);
            }
            catch(Exception E)
            {
                MessageBox.Show("Ha ocurrido un error: " + E.Message);
            }
        }

        private void B_Comprar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Mercancia> Carrito_Usuario = new List<Mercancia>();

                bool Cuenta_Registrada;
                string Nombre_Cliente = TB_Cliente.Text;
                string Medio_Pago = CB_MedioPago.Text;

                if (CB_ClienteAlmacen.Checked)
                {
                    Cuenta_Registrada = true;
                }
                else
                {
                    Cuenta_Registrada = false;
                }

                for (int i = 0; i < LB_Carrito.Items.Count; i++)
                {
                    Carrito_Usuario.Add((Mercancia)LB_Carrito.Items[i]);
                }

                if (!string.IsNullOrEmpty(Nombre_Cliente) && !string.IsNullOrEmpty(Medio_Pago))
                {
                    Cliente Comprador = new Cliente(Nombre_Cliente, Cuenta_Registrada);
                    if (!Medio_Pago.Equals("Credito"))
                    {
                        Comprador.Realizar_Compra(Carrito_Usuario, Medio_Pago, Cuenta_Registrada);
                    }
                    else
                    {
                        short Cuotas_Deseadas = short.Parse(CB_Cuotas.Text);
                        Comprador.Realizar_Compra(Carrito_Usuario, Medio_Pago, Cuotas_Deseadas, Cuenta_Registrada);
                    }

                    LB_Carrito.Items.Clear();

                    LB_Clientes.DisplayMember = "Nombre";
                    LB_Clientes.Items.Add(Comprador);
                }
                else
                {
                    throw new Exception("Debe ingresar un nombre");
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Ha ocurrido un error al comprar: " + E.Message);
            }
        }

        private void LB_Clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Cliente C_Selecionado;
                C_Selecionado = (Cliente)LB_Clientes.SelectedItem;

                L_CuotasC.Text = " ";
                L_CuotasPagadasC.Text = " ";

                if (!C_Selecionado.Compra.Tipo.Equals("Credito"))
                {
                    LB_Productos.DisplayMember = "Exhibicion";

                    L_NombreC.Text = C_Selecionado.Nombre;
                    L_MedioC.Text = C_Selecionado.Compra.Tipo;

                    L_CuotasC.Enabled = false;
                    L_CuotasPagadasC.Enabled = false;

                    L5.Enabled = false;
                    L6.Enabled = false;

                    if (C_Selecionado.Compra.Pagado)
                    {
                        L_EstadoC.Text = "Pagado";
                    }
                    else 
                    {
                        L_EstadoC.Text = "En Deuda";
                    }

                    if (C_Selecionado.Cuenta)
                    {
                        L_ClienteC.Text = "Registrada";
                    }
                    else
                    {
                        L_ClienteC.Text = "No Registrada";
                    }

                    LB_Productos.Items.Clear();
                    foreach (Mercancia M in C_Selecionado.Compra.Producto)
                    {
                        LB_Productos.Items.Add(M);
                    }

                    L_ValorC.Text = "$ " + C_Selecionado.Compra.Valor.ToString();
                }
                else
                {
                    Credito C_Seleccionado_Credito;
                    C_Seleccionado_Credito = (Credito)C_Selecionado.Compra;

                    LB_Productos.DisplayMember = "Exhibicion";

                    L_NombreC.Text = C_Selecionado.Nombre;
                    L_MedioC.Text = C_Selecionado.Compra.Tipo;

                    L5.Enabled = true;
                    L6.Enabled = true;

                    L_CuotasC.Enabled = true;
                    L_CuotasPagadasC.Enabled = true;

                    L_CuotasPagadasC.Text = C_Seleccionado_Credito.C_Pagadas.ToString();
                    L_CuotasC.Text = C_Seleccionado_Credito.Plazo.ToString();

                    if (C_Selecionado.Compra.Pagado)
                    {
                        L_EstadoC.Text = "Pagado";
                    }
                    else
                    {
                        L_EstadoC.Text = "En Deuda";
                    }

                    if (C_Selecionado.Cuenta)
                    {
                        L_ClienteC.Text = "Registrada";
                    }
                    else
                    {
                        L_ClienteC.Text = "No Registrada";
                    }

                    LB_Productos.Items.Clear();
                    foreach (Mercancia M in C_Selecionado.Compra.Producto)
                    {
                        LB_Productos.Items.Add(M);
                    }

                    L_ValorC.Text = "$ " + C_Seleccionado_Credito.Valor.ToString();
                }
            }
            catch(Exception E)
            {
                MessageBox.Show("Ha ocurrido un erro al revisar el cliente: " + E.Message);
            }           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente C_Seleccionado;
                C_Seleccionado = (Cliente)LB_Clientes.SelectedItem;

                C_Seleccionado.Compra.Realizar_Pago();

                LB_Clientes.SelectedItem = C_Seleccionado;
            }
            catch(Exception E)
            {
                MessageBox.Show("Ha ocurrido un error: " + E.Message);
            }
        }

        private void CB_MedioPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Opcion = " ";

                Opcion = CB_MedioPago.Text;

                if (Opcion.Equals("Credito"))
                {
                    L_Cuotas.Enabled = true;
                    CB_Cuotas.Enabled = true;
                }
                else
                {
                    L_Cuotas.Enabled = false;
                    CB_Cuotas.Enabled = false;
                }
            }
            catch(Exception E)
            {
                MessageBox.Show("Ha ocurrido un error: " + E.Message);
            }
        }
    }
}
