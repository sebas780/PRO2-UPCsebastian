namespace Programacion2
{
    public class Program
    {
        public static void Main(string[] args)
        {
           //long f = Factorial(64);
           //Console.WriteLine(f);
           recursin_Domino(6);
        }

        /*public void MatrizSerie_Domino()
        {
            int datoA = 1;
            int datoB = 6;
            bool cambiar = true;
            for (int x = 0; x < columna; x++)
            {
                for (int y = 0; y < fila; y++)
                {
                    if (cambiar)
                    {
                        M[x, y] = datoA;
                        datoA++;
                        cambiar = false;
                    }else{
                        M[x, y] = datoB;
                        datoB--;
                        cambiar = true;
                    }

                }
            }
        } */


        static int datoA = 1;
        static int datoB = 6;
        public static void recursin_Domino(int N)
        {
        
        if(N == 0)
        {
          return;
            }else{
                
                recursin_Domino(N - 1); 
                int serieA = datoA + 1;
                int serieB = datoB - 1;
                datoA = serieA;    
                datoB = serieB;
                Console.WriteLine("Mostrar : " + serieA);
                Console.WriteLine("Mostrar : " + serieB);
            }
                
        }
        
        
    }
}