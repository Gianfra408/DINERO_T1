using System;

class Program
{
    static void Main()
    {
          double SALDO = 8000.0;

            Console.WriteLine("---- CAJERO AUTOMÁTICO ----");
            Console.WriteLine("1. CONSULTAR SALDO");
            Console.WriteLine("2. DEPOSITAR DINERO");
            Console.WriteLine("3. RETIRAR DINERO");
            Console.WriteLine("4. SALIR");
            Console.Write("SELECCIONE UNA OPCION: ");
            
          int OPCION = int.Parse(Console.ReadLine());
          
          if (OPCION > 4 || OPCION < 0)
    {
      Console.WriteLine("OPCION INVALIDA");
    }
    else if (OPCION == 1)
    {
      Console.WriteLine($"SU SALDO ES: S/{SALDO}");
    }
    }
}