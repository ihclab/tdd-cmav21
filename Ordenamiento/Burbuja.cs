using System;

namespace Ordenamiento
{
    public class Burbuja {
        public void Ordenar(int[] enteros) {
             for (int i = 1; i < enteros.Length; i++)
            {
                for (int j = enteros.Length - 1; j >= i; j--)
                {
                    if (enteros[j - 1] > enteros[j])
                    {
                        int aux = enteros[j - 1];
                        enteros[j - 1] = enteros[j];
                        enteros[j] = aux;
                    }
                }
            }
        }
    }
}
