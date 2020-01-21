using System;

namespace VarsAndCommands
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entendendo mais sobre variáveis, arrays e objects

            /*

                NÃO EXECUTAR JAMAIS!!!
            
            */
            //Declarações
            int a;
            int b = 2, c = 3;
            const int d = 4;
            a = 1;
            Console.WriteLine(a+b+c+d);

            //Bloco IF!!
            if (args.Length == 0)
            {
                Console.WriteLine("Nenhum argumento!!");
            }
            else if(args.Length == 1)
            {
                Console.WriteLine("Um argumento!!");
            }
            else
            {
                Console.WriteLine($"{args.Length} argumento!!");
            }

            //Bloco Switch
            int numeroDeArgumentos = args.Length;
            switch (numeroDeArgumentos)
            {
                case 0:
                    Console.WriteLine("Nenhum argumento!!");
                    break;

                case 1:
                    Console.WriteLine("Um argumento!!");
                    break;

                default:
                    Console.WriteLine($"{args.Length} argumento!!");
                    break;

            }

            //Bloco While
            int i=0;
            while (i<args.Length)
            {
                Console.WriteLine(args[i]);
                i++;
            }

            //Bloco Do

            string texto;
            do
            {
                texto = Console.ReadLine();
                Console.WriteLine(texto);
            } 
            while (!string.IsNullOrEmpty(texto));

            //Bloco For
            for(int count=0;count<args.Length;count++)
            {
                Console.WriteLine(args[count]);
            }

            //Bloco ForEach
            foreach (string s in args)
            {
                Console.WriteLine(s);
            }

            //Bloco BreakInstruct with Wilhe
            while(true)
            {
                string s = Console.ReadLine();
                if(string.IsNullOrEmpty(s))
                    break;
                
                Console.WriteLine(s);
            }

            //Bloco Continue with For
            for(int count=0;count<args.Length;count++)
            {
                if (args[count].StartsWith("/"))
                    continue;
                
                Console.WriteLine(args[count]);
            }

            //Bloco return
            int Somar(int a,int b)
            {
                return a+b;
            }

            Console.WriteLine(Somar(1,2));
            Console.WriteLine(Somar(3,4));
            Console.WriteLine(Somar(5,6));
            

            //Bloco TryCatch
            double Dividir(double x, double y)
            {
                if (y == 0)
                    throw new DivideByZeroException();
                
                return x/y;
            }

            try{
                if (args.Length != 2)
                    throw new InvalidOperationException("Informe 2 números");

                double x = double.Parse(args[0]);
                double y = double.Parse(args[1]);

                Console.WriteLine(Dividir(x,y));
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro genérico: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Até breve!");
            }


            //Bloco Using
            using (System.IO.TextWriter w = System.IO.File.CreateText("Teste.txt"))
            {
                w.WriteLine("Line 1");
                w.WriteLine("Line 2");
                w.WriteLine("Line 3");
            }
        }
    }
}
