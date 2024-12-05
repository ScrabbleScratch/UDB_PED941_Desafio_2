using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Grafos
{
    public partial class MainForm : Form
    {
        private Mapas Grafos;
        public MainForm()
        {
            InitializeComponent();
            Grafos = new Mapas();
        }

        //Boton para cargar el mapa de El Salvador
        private void btnElSalvador_Click(object sender, EventArgs e)
        {
            LimpiarEntradas(); // Limpia las entradas y la lista antes de cambiar el grafo
            Grafos.ElSalvador(); // Cambia el grafo (Mapa) al de El Salvador
            Invalidate(); // Redibuja el formulario
        }

        //Boton para cargar el mapa de Guatemala
        private void btnGuatemala_Click(object sender, EventArgs e)
        {
            LimpiarEntradas(); // Limpia las entradas y la lista antes de cambiar el grafo
            Grafos.Guatemala(); // Cambia el grafo (Mapa) al de Guatemala
            Invalidate(); // Redibuja el formulario
        }

        //Boton para cargar el mapa de Honduras
        private void btnHonduras_Click(object sender, EventArgs e)
        {
            LimpiarEntradas(); // Limpia las entradas y la lista antes de cambiar el grafo
            Grafos.Honduras(); // Cambia el grafo (Mapa) al de Honduras
            Invalidate(); // Redibuja el formulario
        }

        // Evento para redibujar en nuestro formulario
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Dibuja las aristas
            foreach (var edge in Grafos.Aristas)
            {
                Point p1 = Grafos.Vertices[edge.Item1];
                Point p2 = Grafos.Vertices[edge.Item2];
                g.DrawLine(Pens.Black, p1, p2);

                // Dibuja la distancia en el punto medio de la arista
                Point midPoint = new Point((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);
                g.DrawString(edge.Item3.ToString(), DefaultFont, Brushes.Black, midPoint);
            }

            // Dibuja los vértices
            foreach (var vertex in Grafos.Vertices)
            {
                Point p = vertex.Value;
                g.FillEllipse(Brushes.Coral, p.X - 10, p.Y - 10, 20, 20);
                g.FillEllipse(Brushes.Black, p.X - 5, p.Y - 5, 10, 10);
                g.DrawString(vertex.Key, DefaultFont, Brushes.Black, p.X + 5, p.Y + 5);
            }
        }

        // Evento al hacer clic en el botón de búsqueda en anchura
        private void btnAnchura_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            // Normaliza el nombre del vértice (nodo) inicial
            string start = NormalizarNombre(txtRecorrido.Text.Trim());

            // Verifica si el vértice inicial existe en el grafo
            if (!Grafos.Vertices.ContainsKey(start))
            {
                MessageBox.Show("El nodo ingresado no existe en el grafo.");
                return;
            }

            // Algoritmo de búsqueda en anchura (BFS)
            var visited = new HashSet<string>();
            var queue = new Queue<string>();
            queue.Enqueue(start);
            visited.Add(start);

            while (queue.Count > 0)
            {
                string current = queue.Dequeue();
                listBox1.Items.Add(current);

                foreach (var edge in Grafos.Aristas)
                {
                    if (edge.Item1 == current && !visited.Contains(edge.Item2))
                    {
                        queue.Enqueue(edge.Item2);
                        visited.Add(edge.Item2);
                    }
                    else if (edge.Item2 == current && !visited.Contains(edge.Item1))
                    {
                        queue.Enqueue(edge.Item1);
                        visited.Add(edge.Item1);
                    }
                }
            }
        }

        // Evento al hacer clic en el botón de búsqueda en profundidad
        private void btnProfundidad_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            // Normaliza el nombre del vértice inicial
            string start = NormalizarNombre(txtRecorrido.Text.Trim());

            // Verifica si el vértice inicial existe en el grafo
            if (!Grafos.Vertices.ContainsKey(start))
            {
                MessageBox.Show("El nodo ingresado no existe en el grafo.");
                return;
            }

            // Algoritmo de búsqueda en profundidad (DFS)
            var visited = new HashSet<string>();
            var stack = new Stack<string>();
            stack.Push(start);
            visited.Add(start);

            while (stack.Count > 0)
            {
                string current = stack.Pop();
                listBox1.Items.Add(current);

                foreach (var edge in Grafos.Aristas)
                {
                    if (edge.Item1 == current && !visited.Contains(edge.Item2))
                    {
                        stack.Push(edge.Item2);
                        visited.Add(edge.Item2);
                    }
                    else if (edge.Item2 == current && !visited.Contains(edge.Item1))
                    {
                        stack.Push(edge.Item1);
                        visited.Add(edge.Item1);
                    }
                }
            }
        }

        // Normaliza el nombre del vértice (nodo)
        public string NormalizarNombre(string vertexName)
        {
            // Divide el nombre en palabras y capitaliza la primera letra de cada palabra
            var words = vertexName.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
            }
            return string.Join(" ", words);
        }

        // Evento para actualizar la posición del ratón en en una etiqueta para obtener las coordenadas de nuestro form.
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text=string.Format("{0}, {1}", e.Location.X, e.Location.Y);
        }

        // Método para limpiar el campo de texto y la lista
        private void LimpiarEntradas()
        {
            txtRecorrido.Text = string.Empty;
            listBox1.Items.Clear();
        }
    }
}

