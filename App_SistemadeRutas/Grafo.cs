using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace App_SistemadeRutas
{
    public class Grafo  
    {
        Dictionary<string, int> map = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);// Para mayusculas o minusculas.
        int[,] matriz;

        public void InicializarMapa()
        {
            map.Add("Policia", 0);
            map.Add("Restaurante", 1);
            map.Add("Parqueo Restaurante", 2);
            map.Add("Dentista", 3);
            map.Add("Familia Rojas", 4);
            map.Add("Heladeria", 5);
            map.Add("Universidad", 6);
            map.Add("Gasolinera", 7);
            map.Add("Central de Autobuses", 8);
            map.Add("Familia Ruiz", 9);
            map.Add("Parque Central", 10);
            map.Add("Iglesia", 11);
            map.Add("Dulceria", 12);
            map.Add("Panaderia", 13);
            map.Add("Supermercado", 14);
            map.Add("Familia Diaz", 15);
            map.Add("Hospital", 16);
            map.Add("Parque Sur", 17);
            map.Add("Zapateria", 18);
            map.Add("Escuela", 19);



            List<(string, string, int)> list = new List<(string, string, int)>
                {
                    ("Policia","Restaurante",3),
                    ("Policia","Heladeria",5),
                    ("Policia","Dentista",1),

                    ("Parqueo Restaurante","Supermercado",3),

                    ("Dentista","Familia Rojas",1),
                    ("Heladeria","Universidad",1),

                    ("Universidad","Supermercado",2),
                    ("Familia Rojas","Escuela",2),

                    ("Supermercado","Parque Sur",2),
                    ("Supermercado","Familia Diaz",2),
                    ("Supermercado","Zapateria",2),
                    ("Supermercado","Gasolinera",4),

                    ("Gasolinera","Familia Diaz",1),
                    ("Gasolinera","Familia Ruiz",4),

                    ("Parque Central","Familia Diaz",1),
                    ("Parque Central","Central de Autobuses",5),
                    ("Parque Central","Familia Ruiz",2),
                    ("Iglesia","Parque Central",3),
                    ("Iglesia","Dulceria",1),

                    ("Zapateria","Hospital",2),
                    ("Zapateria","Iglesia",3),
                    ("Zapateria","Parque Central",4),

                    ("Panaderia","Iglesia",4),
                    ("Panaderia","Zapateria",3),

                    ("Dulceria","Hospital",2),
                    ("Dulceria","Escuela",1),
                    ("Dulceria","Familia Diaz",3),

                    ("Escuela","Central de Autobuses",1),
                    ("Familia Ruiz","Iglesia",3),
                    ("Familia Ruiz","Familia Rojas",4),
                    ("Familia Ruiz","Dulceria",5)
            };// final list


            int n = map.Count;
            matriz = new int[n, n];

            foreach (var item in list)
            {
                string origen = item.Item1;
                string destino = item.Item2;
                int peso = item.Item3;

                if (map.ContainsKey(origen) && map.ContainsKey(destino))
                {
                    int i = map[origen];
                    int j = map[destino];

                    matriz[j, i] = peso;
                    matriz[i, j] = peso;
                }
            }//final foreach
        }//final inicializar mapa

        public void Dikjstra(string inicio, string fin, Control txtMensaje)
        {
            int origen = map[inicio];
            int destino = map[fin];
            int n = map.Count;

            int[] dist = new int[n];
            bool[] visit = new bool[n];
            int[] prev = new int[n];// reconstruir ruta

            for (int i = 0; i < n; i++)
            {
                dist[i] = int.MaxValue;
                visit[i] = false;
                prev[i] = -1;
            }
            dist[origen] = 0;

            for (int count = 0; count < n - 1; count++)
            {
                int u = MinDistancia(dist, visit);
                if (u == -1) break;
                visit[u] = true;

                for (int v = 0; v < n; v++)
                {
                    int w = matriz[u, v];
                    if (!visit[v] && w > 0 && dist[u] != int.MaxValue && dist[u] + w < dist[v])
                    {
                        dist[v] = dist[u] + w;
                        prev[v] = u;
                    }
                }
            }

            var caminoNumeros = new List<int>();
            for (int nodoActual = destino; nodoActual != -1; nodoActual = prev[nodoActual])
            {
                caminoNumeros.Add(nodoActual);
            }
            caminoNumeros.Reverse();

            var indiceANombre = map.ToDictionary(kv => kv.Value, kv => kv.Key);
            var rutaFinal = string.Join(" -> ", caminoNumeros.Select(i => indiceANombre[i]));

            txtMensaje.Text = $"Ruta: {rutaFinal}\r\nPeso total: {dist[destino]}";

        }//final Dikjstra

        private int MinDistancia(int[] dist, bool[] visit)
        {
            int min = int.MaxValue, idx = -1;
            for (int i = 0; i < dist.Length; i++)
                if (!visit[i] && dist[i] <= min) { min = dist[i]; idx = i; }
            return idx;
        }

        public DataTable FloydTodasTabla()
        {
            int n = map.Count;
            int[,] dist = new int[n, n];
            int[,] next = new int[n, n];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    dist[i, j] = matriz[i, j] > 0 ? matriz[i, j] : (i == j ? 0 : int.MaxValue);
                    next[i, j] = matriz[i, j] > 0 ? j : -1;
                }

            for (int k = 0; k < n; k++)
                for (int i = 0; i < n; i++)
                {
                    if (dist[i, k] == int.MaxValue) continue;
                    for (int j = 0; j < n; j++)
                    {
                        if (dist[k, j] == int.MaxValue) continue;
                        int nueva = dist[i, k] + dist[k, j];
                        if (nueva < dist[i, j])
                        {
                            dist[i, j] = nueva;
                            next[i, j] = next[i, k];
                        }
                    }
                }

            var idxToName = map.ToDictionary(kv => kv.Value, kv => kv.Key); //buscar el nombre de un nodo a partir de su índice numérico

            DataTable tabla = new DataTable();
            tabla.Columns.Add("Origen");
            tabla.Columns.Add("Destino");
            tabla.Columns.Add("Ruta");
            tabla.Columns.Add("Peso Total");

            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                {
                    if (dist[i, j] == int.MaxValue)
                    {
                        tabla.Rows.Add(idxToName[i], idxToName[j], "Sin ruta", "∞");
                        continue;
                    }

                    var camino = new List<int> { i };
                    int u = i;
                    while (u != j && u != -1)
                    {
                        u = next[u, j];
                        if (u != -1) camino.Add(u);
                    }

                    string ruta = string.Join(" -> ", camino.Select(x => idxToName[x]));
                    tabla.Rows.Add(idxToName[i], idxToName[j], ruta, dist[i, j]);
                }

            return tabla;
        }// final de floyds
        public void WarshallExiste(string inicio, string fin, Control txtMensaje)
        {
            int n = map.Count;
            bool[,] A = new bool[n, n];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    A[i, j] = (i == j) || matriz[i, j] > 0;

            for (int k = 0; k < n; k++)
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        A[i, j] = A[i, j] || (A[i, k] && A[k, j]);

            int s = map[inicio], t = map[fin];
            txtMensaje.Text = A[s, t] ? "Sí existe camino." : "No existe camino.";
        }


        //final warshall

        public bool ExisteNodo(string nombre)// Si un nodo existe en el diccionario.
        {
            return map.ContainsKey(nombre);
        }


    }//final class grafo
}//final app sistemas
