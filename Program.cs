using System;

namespace actividad4TP6_Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            string valor = "";

            Console.WriteLine("Presione el Número '1' si desea relizar una Suma");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);
            
            if (opcion == 1)
            {
                float resultado = 0;

                resultado = Suma();
                
                Console.WriteLine("El resultado de la Suma es {0}", resultado);
            }

            static float Suma()
            {
                float nro1 = 0;
                float nro2 = 0;
                float resultado = 0;
                string numero = "";

                Console.WriteLine("Dame el primer numero");
                numero = Console.ReadLine();
                nro1 = Convert.ToSingle(numero);

                Console.WriteLine("Dame el segundo numero");
                numero = Console.ReadLine();
                nro2 = Convert.ToSingle(numero);

                resultado = nro1 + nro2;

                return resultado;
            }
            
        }
    }
}