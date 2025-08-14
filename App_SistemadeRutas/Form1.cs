using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace App_SistemadeRutas
{
    public partial class Form1 : Form

    {
        private Grafo grafo;
        public Form1()
        {
            InitializeComponent();
            grafo = new Grafo();
            grafo.InicializarMapa();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (rdbtnFlyod.Checked)  
            {
                var datos = grafo.FloydTodasTabla();    
                var ventanaFloyd = new FormFloyd();
                ventanaFloyd.CargarDatos(datos);        
                ventanaFloyd.ShowDialog();
                return;
            }

            string inicio = txtOrigen.Text.Trim();
            string fin = txtDestino.Text.Trim();

            if (string.IsNullOrWhiteSpace(inicio) || string.IsNullOrWhiteSpace(fin) ||
                !inicio.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)) ||
                !fin.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                txtMensaje.Text = "Error: Origen y destino deben contener solo letras y no números ni símbolos";
                return;
            }

            if (!grafo.ExisteNodo(inicio) || !grafo.ExisteNodo(fin))
            {
                txtMensaje.Text = "Uno o ambos puntos no existen en el mapa.";
                return;
            }

            if (rdbtnDijkstra.Checked)
            {
                grafo.Dikjstra(inicio, fin, txtMensaje);
            }
            else if (rdbtnWarshall.Checked)
            {
                grafo.WarshallExiste(inicio, fin, txtMensaje);
            }
            else
            {
                txtMensaje.Text = "Seleccione un algoritmo antes de calcular.";
            }
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDestino.Clear();
            txtOrigen.Clear();
             
        }
    }
}
