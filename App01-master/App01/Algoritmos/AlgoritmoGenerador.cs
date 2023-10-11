using App01.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace App01.Algoritmos
{
    public class AlgoritmoGenerador
    {
        public List<Viaje> lista = new List<Viaje>();
        public List<int> numerosGenerados = new List<int>();

        public List<Viaje> GenerarLista(int dimension)
        {
            List<Viaje> lista = new List<Viaje>();
            for (int i = 0; i < dimension; i++)
            {
                Viaje viaje = new Viaje();
                viaje.Costo = i;
                lista.Add(viaje);
            }
            return lista;
        }

        public double CalcularMedia(List<Viaje> listaViajes)
        {
            double media = 0, suma = 0;
            foreach (Viaje viaje in listaViajes)
            {
                suma = suma + viaje.Costo;
            }
            if (listaViajes.Count > 0)
            {
                media = suma / listaViajes.Count;
            }
            return media;
        }

        public double AlgoritmoMedia(int totalValores)
        {
            double media = 0;
            lista = GenerarLista(totalValores);
            media = CalcularMedia(lista);
            return media;
        }

        public List<int> AlgoritmoCongruenciaLineal(int a, int m, int c, int x0, int totalValores)
        {
            List<int> listaSalida = new List<int>();
            listaSalida.Add(x0);
            numerosGenerados.Add(x0);

            for (int i = 0; i < totalValores; i++)
            {
                int x = (a * listaSalida[i] + c) % m;

                if (numerosGenerados.Contains(x))
                {
                    // El algoritmo ha entrado en un ciclo
                    MessageBox.Show("El algoritmo ha entrado en un ciclo.");
                    break;  // Detener el algoritmo
                }

                listaSalida.Add(x);
                numerosGenerados.Add(x);
            }
            return listaSalida;
        }
    }
}

