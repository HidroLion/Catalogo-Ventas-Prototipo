namespace Facturadora_Form
{
    partial class Tienda
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tienda));
            this.TB_Cliente = new System.Windows.Forms.TextBox();
            this.CB_ClienteAlmacen = new System.Windows.Forms.CheckBox();
            this.L_Nombre = new System.Windows.Forms.Label();
            this.L_ListaClientes = new System.Windows.Forms.Label();
            this.LB_Clientes = new System.Windows.Forms.ListBox();
            this.LB_Mercancia = new System.Windows.Forms.ListBox();
            this.mercanciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.B_Comprar = new System.Windows.Forms.Button();
            this.L_Informacion = new System.Windows.Forms.Label();
            this.L1 = new System.Windows.Forms.Label();
            this.L2 = new System.Windows.Forms.Label();
            this.L3 = new System.Windows.Forms.Label();
            this.LB_Carrito = new System.Windows.Forms.ListBox();
            this.B_Carrito = new System.Windows.Forms.Button();
            this.L_Medio = new System.Windows.Forms.Label();
            this.CB_MedioPago = new System.Windows.Forms.ComboBox();
            this.L4 = new System.Windows.Forms.Label();
            this.LB_Productos = new System.Windows.Forms.ListBox();
            this.L7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.L_NombreC = new System.Windows.Forms.Label();
            this.L_ClienteC = new System.Windows.Forms.Label();
            this.L_MedioC = new System.Windows.Forms.Label();
            this.L_EstadoC = new System.Windows.Forms.Label();
            this.CB_Cuotas = new System.Windows.Forms.ComboBox();
            this.L_Cuotas = new System.Windows.Forms.Label();
            this.L_Productos = new System.Windows.Forms.Label();
            this.Background_Akashi = new System.Windows.Forms.PictureBox();
            this.L6 = new System.Windows.Forms.Label();
            this.L_CuotasC = new System.Windows.Forms.Label();
            this.L5 = new System.Windows.Forms.Label();
            this.L_CuotasPagadasC = new System.Windows.Forms.Label();
            this.L8 = new System.Windows.Forms.Label();
            this.L_ValorC = new System.Windows.Forms.Label();
            this.B_Catalogo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mercanciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background_Akashi)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_Cliente
            // 
            this.TB_Cliente.Location = new System.Drawing.Point(12, 37);
            this.TB_Cliente.Name = "TB_Cliente";
            this.TB_Cliente.Size = new System.Drawing.Size(167, 20);
            this.TB_Cliente.TabIndex = 0;
            // 
            // CB_ClienteAlmacen
            // 
            this.CB_ClienteAlmacen.AutoSize = true;
            this.CB_ClienteAlmacen.Location = new System.Drawing.Point(185, 37);
            this.CB_ClienteAlmacen.Name = "CB_ClienteAlmacen";
            this.CB_ClienteAlmacen.Size = new System.Drawing.Size(58, 17);
            this.CB_ClienteAlmacen.TabIndex = 1;
            this.CB_ClienteAlmacen.Text = "Cliente";
            this.CB_ClienteAlmacen.UseVisualStyleBackColor = true;
            // 
            // L_Nombre
            // 
            this.L_Nombre.AutoSize = true;
            this.L_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Nombre.Location = new System.Drawing.Point(12, 18);
            this.L_Nombre.Name = "L_Nombre";
            this.L_Nombre.Size = new System.Drawing.Size(57, 16);
            this.L_Nombre.TabIndex = 3;
            this.L_Nombre.Text = "Nombre";
            // 
            // L_ListaClientes
            // 
            this.L_ListaClientes.AutoSize = true;
            this.L_ListaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_ListaClientes.Location = new System.Drawing.Point(427, 13);
            this.L_ListaClientes.Name = "L_ListaClientes";
            this.L_ListaClientes.Size = new System.Drawing.Size(164, 24);
            this.L_ListaClientes.TabIndex = 4;
            this.L_ListaClientes.Text = "Ventas Realizadas";
            // 
            // LB_Clientes
            // 
            this.LB_Clientes.FormattingEnabled = true;
            this.LB_Clientes.Location = new System.Drawing.Point(431, 46);
            this.LB_Clientes.Name = "LB_Clientes";
            this.LB_Clientes.Size = new System.Drawing.Size(229, 407);
            this.LB_Clientes.TabIndex = 5;
            this.LB_Clientes.SelectedIndexChanged += new System.EventHandler(this.LB_Clientes_SelectedIndexChanged);
            // 
            // LB_Mercancia
            // 
            this.LB_Mercancia.DataSource = this.mercanciaBindingSource;
            this.LB_Mercancia.DisplayMember = "Exhibicion";
            this.LB_Mercancia.FormattingEnabled = true;
            this.LB_Mercancia.Location = new System.Drawing.Point(12, 174);
            this.LB_Mercancia.Name = "LB_Mercancia";
            this.LB_Mercancia.Size = new System.Drawing.Size(272, 121);
            this.LB_Mercancia.TabIndex = 8;
            // 
            // mercanciaBindingSource
            // 
            this.mercanciaBindingSource.DataSource = typeof(BC_Facturadora.Mercancia);
            // 
            // B_Comprar
            // 
            this.B_Comprar.Location = new System.Drawing.Point(293, 454);
            this.B_Comprar.Name = "B_Comprar";
            this.B_Comprar.Size = new System.Drawing.Size(94, 41);
            this.B_Comprar.TabIndex = 9;
            this.B_Comprar.Text = "Comprar";
            this.B_Comprar.UseVisualStyleBackColor = true;
            this.B_Comprar.Click += new System.EventHandler(this.B_Comprar_Click);
            // 
            // L_Informacion
            // 
            this.L_Informacion.AutoSize = true;
            this.L_Informacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Informacion.Location = new System.Drawing.Point(665, 13);
            this.L_Informacion.Name = "L_Informacion";
            this.L_Informacion.Size = new System.Drawing.Size(264, 20);
            this.L_Informacion.TabIndex = 10;
            this.L_Informacion.Text = "Información Detallada de Venta";
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L1.Location = new System.Drawing.Point(666, 46);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(60, 16);
            this.L1.TabIndex = 11;
            this.L1.Text = "Nombre:";
            // 
            // L2
            // 
            this.L2.AutoSize = true;
            this.L2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L2.Location = new System.Drawing.Point(666, 66);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(52, 16);
            this.L2.TabIndex = 12;
            this.L2.Text = "Cliente:";
            // 
            // L3
            // 
            this.L3.AutoSize = true;
            this.L3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L3.Location = new System.Drawing.Point(666, 90);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(104, 16);
            this.L3.TabIndex = 13;
            this.L3.Text = "Medio de Pago:";
            // 
            // LB_Carrito
            // 
            this.LB_Carrito.FormattingEnabled = true;
            this.LB_Carrito.Location = new System.Drawing.Point(15, 348);
            this.LB_Carrito.Name = "LB_Carrito";
            this.LB_Carrito.Size = new System.Drawing.Size(272, 147);
            this.LB_Carrito.TabIndex = 14;
            // 
            // B_Carrito
            // 
            this.B_Carrito.Location = new System.Drawing.Point(154, 301);
            this.B_Carrito.Name = "B_Carrito";
            this.B_Carrito.Size = new System.Drawing.Size(114, 41);
            this.B_Carrito.TabIndex = 15;
            this.B_Carrito.Text = "Añadir al Carrito";
            this.B_Carrito.UseVisualStyleBackColor = true;
            this.B_Carrito.Click += new System.EventHandler(this.B_Carrito_Click);
            // 
            // L_Medio
            // 
            this.L_Medio.AutoSize = true;
            this.L_Medio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Medio.Location = new System.Drawing.Point(13, 66);
            this.L_Medio.Name = "L_Medio";
            this.L_Medio.Size = new System.Drawing.Size(101, 16);
            this.L_Medio.TabIndex = 16;
            this.L_Medio.Text = "Medio de Pago";
            // 
            // CB_MedioPago
            // 
            this.CB_MedioPago.FormattingEnabled = true;
            this.CB_MedioPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta Debito",
            "Tarjeta Credito",
            "Compra Web",
            "Credito"});
            this.CB_MedioPago.Location = new System.Drawing.Point(12, 85);
            this.CB_MedioPago.Name = "CB_MedioPago";
            this.CB_MedioPago.Size = new System.Drawing.Size(272, 21);
            this.CB_MedioPago.TabIndex = 17;
            this.CB_MedioPago.SelectedIndexChanged += new System.EventHandler(this.CB_MedioPago_SelectedIndexChanged);
            // 
            // L4
            // 
            this.L4.AutoSize = true;
            this.L4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L4.Location = new System.Drawing.Point(666, 140);
            this.L4.Name = "L4";
            this.L4.Size = new System.Drawing.Size(124, 16);
            this.L4.TabIndex = 18;
            this.L4.Text = "Estado de Compra:";
            // 
            // LB_Productos
            // 
            this.LB_Productos.FormattingEnabled = true;
            this.LB_Productos.Location = new System.Drawing.Point(670, 241);
            this.LB_Productos.Name = "LB_Productos";
            this.LB_Productos.Size = new System.Drawing.Size(347, 212);
            this.LB_Productos.TabIndex = 19;
            // 
            // L7
            // 
            this.L7.AutoSize = true;
            this.L7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L7.Location = new System.Drawing.Point(668, 222);
            this.L7.Name = "L7";
            this.L7.Size = new System.Drawing.Size(122, 16);
            this.L7.TabIndex = 20;
            this.L7.Text = "Lista de Productos:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(468, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 26);
            this.button1.TabIndex = 21;
            this.button1.Text = "Realizar Pago";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // L_NombreC
            // 
            this.L_NombreC.AutoSize = true;
            this.L_NombreC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_NombreC.Location = new System.Drawing.Point(913, 46);
            this.L_NombreC.Name = "L_NombreC";
            this.L_NombreC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_NombreC.Size = new System.Drawing.Size(16, 16);
            this.L_NombreC.TabIndex = 22;
            this.L_NombreC.Text = "X";
            this.L_NombreC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_ClienteC
            // 
            this.L_ClienteC.AutoSize = true;
            this.L_ClienteC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_ClienteC.Location = new System.Drawing.Point(913, 66);
            this.L_ClienteC.Name = "L_ClienteC";
            this.L_ClienteC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_ClienteC.Size = new System.Drawing.Size(16, 16);
            this.L_ClienteC.TabIndex = 23;
            this.L_ClienteC.Text = "X";
            this.L_ClienteC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_MedioC
            // 
            this.L_MedioC.AutoSize = true;
            this.L_MedioC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_MedioC.Location = new System.Drawing.Point(913, 90);
            this.L_MedioC.Name = "L_MedioC";
            this.L_MedioC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_MedioC.Size = new System.Drawing.Size(16, 16);
            this.L_MedioC.TabIndex = 24;
            this.L_MedioC.Text = "X";
            this.L_MedioC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_EstadoC
            // 
            this.L_EstadoC.AutoSize = true;
            this.L_EstadoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_EstadoC.Location = new System.Drawing.Point(913, 140);
            this.L_EstadoC.Name = "L_EstadoC";
            this.L_EstadoC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_EstadoC.Size = new System.Drawing.Size(16, 16);
            this.L_EstadoC.TabIndex = 25;
            this.L_EstadoC.Text = "X";
            this.L_EstadoC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CB_Cuotas
            // 
            this.CB_Cuotas.FormattingEnabled = true;
            this.CB_Cuotas.Items.AddRange(new object[] {
            "3",
            "6",
            "12"});
            this.CB_Cuotas.Location = new System.Drawing.Point(208, 112);
            this.CB_Cuotas.Name = "CB_Cuotas";
            this.CB_Cuotas.Size = new System.Drawing.Size(76, 21);
            this.CB_Cuotas.TabIndex = 26;
            // 
            // L_Cuotas
            // 
            this.L_Cuotas.AutoSize = true;
            this.L_Cuotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Cuotas.Location = new System.Drawing.Point(12, 112);
            this.L_Cuotas.Name = "L_Cuotas";
            this.L_Cuotas.Size = new System.Drawing.Size(138, 16);
            this.L_Cuotas.TabIndex = 27;
            this.L_Cuotas.Text = "Cuotas (Solo Credito):";
            // 
            // L_Productos
            // 
            this.L_Productos.AutoSize = true;
            this.L_Productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Productos.Location = new System.Drawing.Point(19, 155);
            this.L_Productos.Name = "L_Productos";
            this.L_Productos.Size = new System.Drawing.Size(231, 16);
            this.L_Productos.TabIndex = 28;
            this.L_Productos.Text = "Seleccione los Productos Deseados:";
            // 
            // Background_Akashi
            // 
            this.Background_Akashi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Background_Akashi.Image = ((System.Drawing.Image)(resources.GetObject("Background_Akashi.Image")));
            this.Background_Akashi.Location = new System.Drawing.Point(139, 2);
            this.Background_Akashi.Name = "Background_Akashi";
            this.Background_Akashi.Size = new System.Drawing.Size(452, 493);
            this.Background_Akashi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Background_Akashi.TabIndex = 29;
            this.Background_Akashi.TabStop = false;
            // 
            // L6
            // 
            this.L6.AutoSize = true;
            this.L6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L6.Location = new System.Drawing.Point(666, 189);
            this.L6.Name = "L6";
            this.L6.Size = new System.Drawing.Size(200, 16);
            this.L6.TabIndex = 30;
            this.L6.Text = "Cuotas Restanres(Solo Credito):";
            // 
            // L_CuotasC
            // 
            this.L_CuotasC.AutoSize = true;
            this.L_CuotasC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_CuotasC.Location = new System.Drawing.Point(913, 189);
            this.L_CuotasC.Name = "L_CuotasC";
            this.L_CuotasC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_CuotasC.Size = new System.Drawing.Size(16, 16);
            this.L_CuotasC.TabIndex = 31;
            this.L_CuotasC.Text = "X";
            this.L_CuotasC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L5
            // 
            this.L5.AutoSize = true;
            this.L5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L5.Location = new System.Drawing.Point(668, 173);
            this.L5.Name = "L5";
            this.L5.Size = new System.Drawing.Size(194, 16);
            this.L5.TabIndex = 32;
            this.L5.Text = "Cuotas Pagadas(Solo Credito):";
            // 
            // L_CuotasPagadasC
            // 
            this.L_CuotasPagadasC.AutoSize = true;
            this.L_CuotasPagadasC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_CuotasPagadasC.Location = new System.Drawing.Point(913, 173);
            this.L_CuotasPagadasC.Name = "L_CuotasPagadasC";
            this.L_CuotasPagadasC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_CuotasPagadasC.Size = new System.Drawing.Size(16, 16);
            this.L_CuotasPagadasC.TabIndex = 33;
            this.L_CuotasPagadasC.Text = "X";
            this.L_CuotasPagadasC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L8
            // 
            this.L8.AutoSize = true;
            this.L8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L8.Location = new System.Drawing.Point(668, 456);
            this.L8.Name = "L8";
            this.L8.Size = new System.Drawing.Size(77, 16);
            this.L8.TabIndex = 34;
            this.L8.Text = "Valor Total:";
            // 
            // L_ValorC
            // 
            this.L_ValorC.AutoSize = true;
            this.L_ValorC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_ValorC.Location = new System.Drawing.Point(913, 456);
            this.L_ValorC.Name = "L_ValorC";
            this.L_ValorC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_ValorC.Size = new System.Drawing.Size(16, 16);
            this.L_ValorC.TabIndex = 35;
            this.L_ValorC.Text = "X";
            this.L_ValorC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // B_Catalogo
            // 
            this.B_Catalogo.Location = new System.Drawing.Point(22, 301);
            this.B_Catalogo.Name = "B_Catalogo";
            this.B_Catalogo.Size = new System.Drawing.Size(114, 41);
            this.B_Catalogo.TabIndex = 36;
            this.B_Catalogo.Text = "Mostrar productos";
            this.B_Catalogo.UseVisualStyleBackColor = true;
            this.B_Catalogo.Click += new System.EventHandler(this.B_Catalogo_Click);
            // 
            // Tienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1029, 507);
            this.Controls.Add(this.B_Catalogo);
            this.Controls.Add(this.L_ValorC);
            this.Controls.Add(this.L8);
            this.Controls.Add(this.L_CuotasPagadasC);
            this.Controls.Add(this.L5);
            this.Controls.Add(this.L_CuotasC);
            this.Controls.Add(this.L6);
            this.Controls.Add(this.L_Productos);
            this.Controls.Add(this.L_Cuotas);
            this.Controls.Add(this.CB_Cuotas);
            this.Controls.Add(this.L_EstadoC);
            this.Controls.Add(this.L_MedioC);
            this.Controls.Add(this.L_ClienteC);
            this.Controls.Add(this.L_NombreC);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.L7);
            this.Controls.Add(this.LB_Productos);
            this.Controls.Add(this.L4);
            this.Controls.Add(this.CB_MedioPago);
            this.Controls.Add(this.L_Medio);
            this.Controls.Add(this.B_Carrito);
            this.Controls.Add(this.LB_Carrito);
            this.Controls.Add(this.L3);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.L_Informacion);
            this.Controls.Add(this.B_Comprar);
            this.Controls.Add(this.LB_Mercancia);
            this.Controls.Add(this.LB_Clientes);
            this.Controls.Add(this.L_ListaClientes);
            this.Controls.Add(this.L_Nombre);
            this.Controls.Add(this.CB_ClienteAlmacen);
            this.Controls.Add(this.TB_Cliente);
            this.Controls.Add(this.Background_Akashi);
            this.MaximizeBox = false;
            this.Name = "Tienda";
            this.Text = "Pøwer Sports";
            ((System.ComponentModel.ISupportInitialize)(this.mercanciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background_Akashi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Cliente;
        private System.Windows.Forms.CheckBox CB_ClienteAlmacen;
        private System.Windows.Forms.Label L_Nombre;
        private System.Windows.Forms.Label L_ListaClientes;
        private System.Windows.Forms.ListBox LB_Clientes;
        private System.Windows.Forms.ListBox LB_Mercancia;
        private System.Windows.Forms.Button B_Comprar;
        private System.Windows.Forms.Label L_Informacion;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.Label L2;
        private System.Windows.Forms.Label L3;
        private System.Windows.Forms.ListBox LB_Carrito;
        private System.Windows.Forms.Button B_Carrito;
        private System.Windows.Forms.Label L_Medio;
        private System.Windows.Forms.ComboBox CB_MedioPago;
        private System.Windows.Forms.Label L4;
        private System.Windows.Forms.ListBox LB_Productos;
        private System.Windows.Forms.Label L7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label L_NombreC;
        private System.Windows.Forms.Label L_ClienteC;
        private System.Windows.Forms.Label L_MedioC;
        private System.Windows.Forms.Label L_EstadoC;
        private System.Windows.Forms.ComboBox CB_Cuotas;
        private System.Windows.Forms.Label L_Cuotas;
        private System.Windows.Forms.Label L_Productos;
        private System.Windows.Forms.PictureBox Background_Akashi;
        private System.Windows.Forms.Label L6;
        private System.Windows.Forms.Label L_CuotasC;
        private System.Windows.Forms.Label L5;
        private System.Windows.Forms.Label L_CuotasPagadasC;
        private System.Windows.Forms.Label L8;
        private System.Windows.Forms.Label L_ValorC;
        private System.Windows.Forms.Button B_Catalogo;
        private System.Windows.Forms.BindingSource mercanciaBindingSource;
    }
}

