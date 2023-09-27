using System;
using System.Linq;

namespace Actividad4
{
    public class Arrays
    {
        static void Main(string[] args)
        {
        }

        public static int minValorArray(int[] array)
        { 
            
            int minValue = 0;
            if(array.Length > 1)
            {
                minValue = array[0];
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < minValue) minValue = array[i];
                }
            }
            
            /*
            if(array.Length == 0) return 0;
            int minValue = array.Min();
            */
            return minValue;
        }
        public static int[] invertirArray(int[] array)
        {
            int[] array2 = new int[array.Length];

            for(int i = array.Length - 1; i>= 0; i--)
           {
                array2[i] = array[i];
            }

            //Array.Reverse(array);
            return array2;
        }

        public static int comprobarValorEnArray(int[] array, int valor)
        {
            int position = 0;
            bool found = false;
            if(!array.Contains(valor)) position = -1;
            else
            {
                for(int i = 0; i < array.Length; i++)
                {
                    if (array[i] == valor && found != true)
                    {
                        position = i;
                        found = true;
                    }
                }
            }
            return position;
        }

        public static int calcularModa(int[] entrada)
        {

            int mode = 0;
            if(entrada.Length > 1 )
            {
                mode = entrada[0];
                int occurences = 0;
                for (int i = 0; i < entrada.Length; i++)
                {
                    if (entrada.Count(f => f == entrada[i]) > occurences)
                    {
                        mode = entrada[i];
                        occurences = entrada.Count(f => f == entrada[i]);
                    }
                }
            }
            return mode;
        }
    }
}
