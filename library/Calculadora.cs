using System;
using System.Collections.Generic;

namespace library
{
    public class Calculadora
    {
        public int Suma(int num1, int num2)
        {
           return num1 + num2;
        }

        public int Resta(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiplicacion(int num1, int num2)
        {
           return num1 * num2;
        }
        
        public int Division(int num1, int num2)
        {
           if(num2==0) return 0;

           return num1/num2;
        }

        public int[] GetPares()
        {
            List<int> pares = new List<int>();
            for (int i = 1; i < 1000; i++)
            {
                if(i%2 == 0) pares.Add(i);
            }

            return pares.ToArray();
        }
    }
}