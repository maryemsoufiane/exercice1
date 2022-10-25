 

using System;
namespace premier;

public class premier
{
    public static void Main()
    {
        bool pr = true;
       int  i;
       string nbr;
        int N;
        do
        {
            Console.WriteLine("saisir un nbr");
            nbr = Console.ReadLine();
            int.TryParse(nbr, out N);
        } while (N <= 1);

          for ( i = 2; i <= ( N/ 2) ; i++)
          {
              if (N % i == 0)
              {
                  Console.WriteLine(N + " pas premier");

              }
             else 
              {
                  Console.WriteLine(N + "  premier");

              }
            /* for (i = 2; i*i <= N && pr; i++) 
             {
                 if (N % i == 0) pr = false;
             }
             if (pr) { Console.WriteLine("premier"); }
             else { Console.WriteLine("pas premier"); }
             */


        }




    }
}



