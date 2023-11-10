using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static SOINTEC.CalcularPresupuestos;

namespace SOINTEC
{
    public partial class Sointec : Form
    {
        private CalcularPresupuestos calcularPresupuestos;
        private List<CalcularPresupuestos> listaPresupuestos = new List<CalcularPresupuestos>();
        public Sointec()
        {
            InitializeComponent();
            this.FormClosing += Sointec_FormClosing;  // Agregar el manejador para el evento FormClosing
        }
        private void Sointec_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Borrar la lista al cerrar la aplicacion
            listaPresupuestos.Clear();
        }
        //boton para guardar los datos y mostrar el mensaje con el MessageBox
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumPersonas.Text, out int numeroPersonas))
            {
                CalcularPresupuestos presupuesto = CalculadoraPresupuesto.CalcularPresupuesto(numeroPersonas);
                presupuesto.NumCotizacion = GenerarNumeroCotizacion();
                listaPresupuestos.Add(presupuesto);

                MessageBox.Show($"Número de Cotización: {presupuesto.NumCotizacion}\nMonto por persona: ${presupuesto.CostoPersona}\nTotal Presupuesto: ${presupuesto.TotalPresupuesto}", "Resultado del Presupuesto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido de personas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Generar numero de cotizacio aleatoria del 1 al 100
        private int GenerarNumeroCotizacion()
        {
            return new Random().Next(1, 100);
        }
        //ajustar ancho de las columnas en listview
        private void AjustarAncho()
        {
            lvwDatos.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvwDatos.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        //cambiarle el color a las filas del listview
        private void ColorFilas()
        {
            for (int i = 0; i < lvwDatos.Items.Count; i++)
            {
                lvwDatos.Items[i].BackColor = i % 2 == 0 ? Color.LightGray : Color.White;
            }
        }
        //boton para mostrar los datos almacenados en el listview
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lvwDatos.Items.Clear();

            foreach (CalcularPresupuestos presupuesto in listaPresupuestos)
            {
                ListViewItem item = new ListViewItem(presupuesto.NumCotizacion.ToString());
                item.SubItems.Add(presupuesto.NumPersonas.ToString());
                item.SubItems.Add("$" + presupuesto.TotalPresupuesto.ToString("N2"));
                lvwDatos.Items.Add(item);
            }
            AjustarAncho();
            ColorFilas();

        }
        //boton para limpiar textbox
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumPersonas.Clear();
        }
        //boton para cerrar el formulario
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
