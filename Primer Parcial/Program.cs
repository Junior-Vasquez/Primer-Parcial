using System;

namespace Primer_Parcial
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Cajero Automatico Banco FDP INVERSMENTS//
            Inicio();
        }

        static void Inicio()
        {
            int b100 = 50, b200 = 23, b500 = 19, b1000 = 18;
            string nombre;
            Console.WriteLine("\nBienvenido al Banco FDP INVERSMENTS\n");
            Console.WriteLine("\nIngrese su nombre: \n");
            nombre = Console.ReadLine();
            Retirar();
            void Retirar()
            {
                int monto = 0, dinero = 0, cien = 0, docientos = 0, quinientos = 0, mil = 0;
                Console.WriteLine("Por favor ingrese el monto a retirar: ");
                monto = int.Parse(Console.ReadLine());

               

                if (monto > 0) 
                {
                    Console.WriteLine("\nMonto:\n ");
                    mil = monto / 1000;
                    if(mil <= b1000)
                    {
                        Console.WriteLine("El monto de billetes de mil es: " + mil);
                        monto = monto % 1000;
                    }
                    quinientos = monto / 500;
                    if (quinientos <= b500)
                    {
                        Console.WriteLine("El monto de billetes de quinientos es: " + quinientos);
                        monto = monto % 500;
                    }
                    docientos = monto / 200;
                    if (docientos <= b200)
                    {
                        Console.WriteLine("El monto de billetes de docientos es: " + docientos);
                        monto = monto % 200;
                    }
                    cien = monto / 100;
                    if (cien <= b100)
                    {
                        Console.WriteLine("El monto de billetes de mil cien: " + cien);
                        monto = monto % 100;
                    }
                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine("MENU");
                    Console.WriteLine("\n1. Retirar mas dinero\n");
                    Console.WriteLine("\n2. Salir\n");
                    int opciones;
                    opciones = int.Parse(Console.ReadLine());
                                        
                    if (opciones == 1) 
                    {
                        Console.Clear();

                        Retirar();
                                               
                    }else if(opciones == 2) 
                    { 
                        Console.WriteLine("Gracias por Preferirnos!");
                    }
                      

                }

                b1000 = b1000 - mil;
                b500 = b500 - quinientos;
                b200 = b200 - docientos;
                b100 = b100 - cien;

            } Console.ReadKey();
        }
        
        

    }
}
