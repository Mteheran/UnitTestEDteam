using System;

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
    }
}