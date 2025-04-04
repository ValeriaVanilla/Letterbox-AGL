using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalAlgoritmos
{
    public partial class Form1 : Form
    {
        private LinkedList<Pelicula> peliculas = new LinkedList<Pelicula>();

        public Form1()
        {            
            InitializeComponent();
            
        }

        private void insercion(List<int> a)
        {
            for (int i = 1; i < a.Count(); i++)
            {
                int aux = a[i]; //guardamos el elemento
                /* indice j es para explorar la sublista a[i-1]..a[0] buscando
                la posición correcta del elemento destino*/
                int j = i - 1;
                // se localiza el punto de inserción explorando hacia abajo
                while (j >= 0 && aux < a[j])
                {
                    // desplazar elementos hacia arriba para hacer espacio
                    a[j + 1] = a[j];
                    j--;
                }
                a[j + 1] = aux; //colocamos elemento en su sitio
            }
        }

        static void quicksort(List<int> a, int primero, int ultimo)
        {
            int central = (primero + ultimo) / 2;
            int pivote = a[central];
            int i = primero;
            int j = ultimo;
            do
            {
                while (a[i] < pivote) i++;
                while (a[j] > pivote) j--;
                if (i <= j)
                {
                    intercambiar(a, i, j);
                    i++;
                    j--;
                }
            } while (i <= j);
            if (primero < j)
                quicksort(a, primero, j); // mismo proceso con sublista izquierda
            if (i < ultimo)
                quicksort(a, i, ultimo); // mismo proceso con sublista derecha
        }
        static void intercambiar(List<int> inputArray, int i, int j)
        {
            int aux = inputArray[i];
            inputArray[i] = inputArray[j];
            inputArray[j] = aux;
        }

            static int BusquedaBinInt(int[] a, int clave, int bajo, int alto)
        {
            if (bajo <= alto)
            {
                int central = (bajo + alto) / 2; // índice de elemento central
                int valorCentral = a[central]; // valor del índice central
                if (clave.CompareTo(valorCentral) == 0)
                    return central; // encontrado, devuelve posición
                else if (clave.CompareTo(valorCentral) < 0)
                    alto = central - 1; // ir a sublista inferior
                else
                    bajo = central + 1;
                // ir a sublista superior
                return BusquedaBinInt(a, clave, bajo, alto);
            }
            return -1; //elemento no encontrado}
        }

        private void lblOpenFileDialog_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBoxCaratulaPreview.Image = Image.FromFile(openFileDialog1.FileName);            
        }
    }
}
