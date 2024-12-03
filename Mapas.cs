using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Grafos
{
    public class Mapas
    {
        public Dictionary<string, Point> Vertices { get; private set; } // Diccionario para almacenar los vértices y sus posiciones
        public List<Tuple<string, string, int>> Aristas { get; private set; } // Lista para almacenar las aristas del grafo (conexiones entre vértices y sus pesos)

        // Constructor de la clase Mapas
        public Mapas()
        {
            Honduras();// Inicializa los datos del mapa de Honduras
            Guatemala(); // Inicializa los datos del mapa de Guatemala
            ElSalvador(); // Inicializa los datos del mapa de El Salvador
        }

        // Método para inicializar los datos del mapa de El Salvador
        public void ElSalvador()
        {
            // Inicializa los vértices con sus respectivas posiciones
            Vertices = new Dictionary<string, Point>
        {
            { "Ahuachapan", new Point(50, 200) },
            { "Santa Ana", new Point(150, 100) },
            { "Sonsonate", new Point(150, 300) },
            { "La Libertad", new Point(300, 250) },
            { "San Salvador", new Point(300, 150) },
            { "Cuscatlan", new Point(450, 150) },
            { "Chalatenango", new Point(450, 50) },
            { "Cabanas", new Point(600, 100) },
            { "San Vicente", new Point(600, 200) },
            { "La Paz", new Point(450, 250) },
            { "Usulutan", new Point(750, 300) },
            { "San Miguel", new Point(750, 200) },
            { "Morazan", new Point(900, 100) },
            { "La Union", new Point(900, 250) }
        };

            // Inicializa las aristas con sus conexiones y pesos

            Aristas = new List<Tuple<string, string, int>>
        {
            Tuple.Create("Ahuachapan", "Santa Ana", 83),
            Tuple.Create("Ahuachapan", "Sonsonate", 53),
            Tuple.Create("Santa Ana", "Sonsonate", 38),
            Tuple.Create("Santa Ana", "Chalatenango", 76),
            Tuple.Create("Santa Ana", "La Libertad", 70),
            Tuple.Create("Sonsonate", "La Libertad", 38),
            Tuple.Create("La Libertad", "San Salvador", 44),
            Tuple.Create("San Salvador", "Cuscatlan", 55),
            Tuple.Create("San Salvador", "La Paz", 72),
            Tuple.Create("San Salvador", "Chalatenango", 72),
            Tuple.Create("Cuscatlan", "Cabanas", 39),
            Tuple.Create("Cuscatlan", "San Vicente", 63),
            Tuple.Create("La Paz", "San Vicente", 48),
            Tuple.Create("Chalatenango", "Cabanas", 43),
            Tuple.Create("San Vicente", "San Miguel", 77),
            Tuple.Create("Usulutan", "San Miguel", 57),
            Tuple.Create("San Miguel", "La Union", 54),
            Tuple.Create("San Miguel", "Morazan", 66),
            Tuple.Create("Usulutan", "La Union", 60)
            };
        }

        // Método para inicializar los datos del mapa de Guatemala
        public void Guatemala()
        {
            // Inicializa los vértices con sus respectivas posiciones
            Vertices = new Dictionary<string, Point>
            {
                { "Peten", new Point(50, 200) },
                { "Alta Verapaz", new Point(190, 200) },
                { "Izabal", new Point(290, 60) },
                { "Baja Verapaz", new Point(330, 150) },
                { "Huehuetenango", new Point(250, 280) },
                { "San Marcos", new Point(300, 320) },
                { "Quetzaltengango", new Point(520, 280) },
                { "Quiche", new Point(500, 190) },
                { "Escuintla", new Point(660, 280) },
                { "El Progreso", new Point(630, 70) },
                { "Guatemala", new Point(680, 180) },

            };

            // Inicializa las aristas con sus conexiones y pesos
            Aristas = new List<Tuple<string, string, int>>
            {
                Tuple.Create("Peten", "Alta Verapaz", 75),
                Tuple.Create("Alta Verapaz", "Izabal", 83),
                Tuple.Create("Alta Verapaz", "Baja Verapaz", 56),
                Tuple.Create("Alta Verapaz", "Huehuetenango", 30),
                Tuple.Create("Huehuetenango", "San Marcos", 25),
                Tuple.Create("San Marcos", "Quetzaltengango", 127),
                Tuple.Create("Quetzaltengango", "Quiche", 43),
                Tuple.Create("Quiche", "Baja Verapaz", 42),
                Tuple.Create("Quiche", "Escuintla", 75),
                Tuple.Create("Quiche", "Guatemala", 59),
                Tuple.Create("Quiche", "El Progreso", 27),
                Tuple.Create("Izabal", "El Progreso", 230),
                Tuple.Create("El Progreso", "Guatemala", 48)
            };
        }

        // Método para inicializar los datos del mapa de Honduras

        public void Honduras()
        {
            // Inicializa los vértices con sus respectivas posiciones
            Vertices = new Dictionary<string, Point>
            {
                { "Olancho", new Point(800, 160) },
                { "Colon", new Point(690, 75) },
                { "El Paraiso", new Point(725, 260) },
                { "Yoro", new Point(450, 170) },
                { "Cortes", new Point(290, 85) },
                { "Atlantida", new Point(440, 65) },
                { "Intibuca", new Point(330, 205) },
                { "Francisco Morazan", new Point(620, 230) },
                { "Choluteca", new Point(600, 320) },
                { "Valle", new Point(520, 320) },
                { "La Paz", new Point(400, 260) },
                { "Lempira", new Point(250, 240) },
                { "Ocotepeque", new Point(160, 200) },
                { "Santa Barbara", new Point(160, 110) },
                { NormalizarNombre("Gracias a Dios"), new Point(835, 70) },
            };

            // Inicializa las aristas con sus conexiones y pesos
            Aristas = new List<Tuple<string, string, int>>
            {
                 Tuple.Create("Olancho", "Colon", 75),
                 Tuple.Create("Olancho", "El Paraiso", 83),
                 Tuple.Create("Olancho", "Francisco Morazan", 56),
                 Tuple.Create("Francisco Morazan", "Yoro", 56),
                 Tuple.Create("Yoro", "Cortes", 30),
                 Tuple.Create("Yoro", "Intibuca", 30),
                 Tuple.Create("Intibuca", "Lempira", 30),
                 Tuple.Create("Yoro", "Atlantida", 25),
                 Tuple.Create("Colon", "Atlantida", 70),
                 Tuple.Create("Atlantida", "Cortes", 55),
                 Tuple.Create("Cortes", "Santa Barbara", 25),
                 Tuple.Create("Colon", "Yoro", 25),
                 Tuple.Create("El Paraiso", "Choluteca", 43),
                 Tuple.Create("Choluteca", "Valle", 42),
                 Tuple.Create("Valle", "La Paz", 75),
                 Tuple.Create("La Paz", "Lempira", 59),
                 Tuple.Create("Lempira", "Ocotepeque", 25),
                 Tuple.Create("Ocotepeque", "Santa Barbara", 48),

                 Tuple.Create(NormalizarNombre("Gracias a Dios"), NormalizarNombre("Olancho"), 36),
                 Tuple.Create(NormalizarNombre("Gracias a Dios"), NormalizarNombre("Colon"), 43)
            };
        }

        // Método para normalizar el nombre de los vértices (capitaliza la primera letra de cada palabra)
        private string NormalizarNombre(string vertexName)
        {
            // Divide el nombre en palabras y capitaliza la primera letra de cada palabra
            var words = vertexName.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
            }
            return string.Join(" ", words);
        }

    }
}
