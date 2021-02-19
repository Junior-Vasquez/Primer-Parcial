using System;

namespace Primer_Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cajero Automatico Banco FDP INVERSMENTS//

            int monto, cien, docientos, quinientos, mil;
            string nombre;

            Console.WriteLine("Bienvenido Banco FDP INVERSMENTS");
            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Por favor ingrese el monto a retirar: ");
            monto = int.Parse(Console.ReadLine());

            if (monto == 0) ;
            {
                mil = monto / 1000;
                monto = monto % 1000;
                quinientos = monto / 500;
                monto = monto % 500;
                docientos = monto / 200;
                monto = monto % 200;
                cien = monto / 100;
                monto = monto % 100;

                Console.WriteLine("El monto de billetes de mil es: " + mil);
                Console.WriteLine("El monto de billetes de quinientos es: " + quinientos);
                Console.WriteLine("El monto de billetes de docientos es: " + docientos);
                Console.WriteLine("El monto de billetes de mil cien: " + cien);


            }




            Console.ReadKey();

           

            

            
            










        }
    }
}
