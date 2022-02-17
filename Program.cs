using System;

namespace Sueldo_Quincenal
{
    /// <summary>
    /// Oswaldo Duran Renteria
    /// 16/02/2022
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Definimos las Variables
            int TieneTituloUniversitario;
            double BonoAlimentacion, BonoProfesionalizacion, BonoTransporte, CajaAhorro, ParoForzoso;
            double SeguroColectivo, EPS, diasLaborados, sueldoBase, sueldoQuincenal;
            diasLaborados = 15;
            //Convertimos cadena de un número en su numérico
            Console.WriteLine("Selecciona el valor de tiene titulo universitario.");
            Console.WriteLine("\t1.- SI");
            Console.WriteLine("\t2.- No");
            Console.Write("\t: ");
            //Seleccionamos 
            //Creamos la estructura repetitiva do while
            do
            {
                TieneTituloUniversitario = int.Parse(Console.ReadLine());
                if (TieneTituloUniversitario < 1 || TieneTituloUniversitario > 2)
                    Console.Write("Valor incorrecto. Ingresalo nuevamente.: ");
            } while (TieneTituloUniversitario < 1 || TieneTituloUniversitario > 2);
            sueldoBase = 1050000;
            //Función booleana
            if (TieneTituloUniversitario == 1)
                BonoProfesionalizacion = sueldoBase * 0.10;
            else
                BonoProfesionalizacion = 0;
            //Definimos los valores de cada varaible
            BonoTransporte = 120000; ;
            BonoAlimentacion = diasLaborados * 25000;
            SeguroColectivo = sueldoBase * 0.02;
            ParoForzoso = sueldoBase * 0.01;
            EPS = sueldoBase * 0.02;
            CajaAhorro = sueldoBase * 0.02;
           
           
            sueldoQuincenal = sueldoBase + BonoProfesionalizacion + BonoTransporte + BonoAlimentacion - SeguroColectivo - ParoForzoso - CajaAhorro - EPS;
            //Sumamos 
            Console.WriteLine("Valor de bono alimentacion: " + BonoAlimentacion);
            Console.WriteLine("Valor de bono profesionalizacion: " + BonoProfesionalizacion);
            Console.WriteLine("Valor de bono transporte: " + BonoTransporte);
            Console.WriteLine("Valor de deduccion caja de ahorro: " + CajaAhorro);
            Console.WriteLine("Valor de deduccion paro forzoso: " + ParoForzoso);
            Console.WriteLine("Valor de deduccion seguro colectivo: " + SeguroColectivo);
            Console.WriteLine("Valor de deduccion EPS: " + EPS);
            Console.WriteLine("Valor de sueldo base: " + sueldoBase);
            Console.WriteLine("Valor de sueldo quincenal: " + sueldoQuincenal);
            Console.WriteLine();
            //Imprime los valores  
            Console.Write("Presiona una tecla para terminar . . . ");
            Console.ReadKey();
            //Termnia el programa
        }
    }
}

