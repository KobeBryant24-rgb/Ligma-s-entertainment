using System;

namespace funciones
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Ingrese dos numeros a evaluar");
            Evaluar(Int32.Parse(Console.ReadLine()),Int32.Parse(Console.ReadLine()));
           
        }

        ///Evaluar cual numero es mayor, menor o igual
        public static int Evaluar(int numero1, int numero2){
        if(numero1>numero2){
            Console.WriteLine("Resultado");
            Console.WriteLine(numero1 +  ">"  + numero2);
        }
        else
        {
            if(numero1<numero2){
                Console.WriteLine("Resultado");
                Console.WriteLine(numero1 +  "<"  + numero2);
            }
            else{
                Console.WriteLine("Resultado");
                Console.WriteLine(numero1 +  "="  + numero2);
            }
        }
       

           
         return numero1;
         

         }
         
    }

    
}
