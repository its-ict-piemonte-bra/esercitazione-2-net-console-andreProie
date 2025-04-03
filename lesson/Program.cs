namespace lesson
{
    public class Program
    {
        /// <summary>
        /// The main entrypoint of your application.
        /// </summary>
        /// <param name="args">The arguments passed to the program</param>
        public static void Main(string[] args)
        {
            //Console.WriteLine("Ciaone DSA"); //se scrivo solo write non va a capo

            //Console.WriteLine("Inserisci un numero");
            //int n = Convert.ToInt32(Console.ReadLine());

            //if (n < 0)
            //{
            //    Console.WriteLine($"{n} non è un numero naturale"); //nelle graffe posso inserire anche funzioni o operazioni
            //}
            //else 
            //{
            //    Console.WriteLine($"{n}non è un numero naturale");
            //}

            //Console.WriteLine();
            //Console.WriteLine("rappresenta un numero intero");
            //Console.WriteLine($"numero intero minimo {int.MinValue}");
            //Console.WriteLine($"numero intero massimo {int.MaxValue}");

            //Console.WriteLine();
            //Console.WriteLine(" float rappresenta un numero con la virgola si possono calcolare anche numeri infiniti");
            //Console.WriteLine($"numero intero minimo {float.PositiveInfinity}");
            //Console.WriteLine($"float infinito negativo {float.NegativeInfinity}");

            Console.WriteLine("Ora gli esercizi");

            Esercizio4();
        }

        /// <summary>
        /// Visualizzare 100 numeri pari, partendo dal numero 2
        /// </summary>
        private static void Esercizio1()
        {
            int n = 2;
            Console.WriteLine("I primi 100 numeri pari sono: ");
            for(int i=1; i<=200; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i} -");
                }
            }
        }

        /// <summary>
        /// Calcolo il fattoriale di un numero
        /// </summary>
        private static void Esercizio2()
        {
            int n, fattoriale=1;
            do
            {
                Console.WriteLine("Digitare un numero (n>=0): ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 0);

            if(n == 0)
            {
                fattoriale = 1;   
            }

            for(int i=1; i<=n; i++)
            {
                fattoriale = fattoriale * i;
            }
            Console.WriteLine($"{n}! = {fattoriale}");
        }

        /// <summary>
        /// Converte un numero binario fornito in ingresso in decimale
        /// </summary>
        private static void Esercizio3()
        {
            double numDeci = 0;
            Console.WriteLine("Digitare un numero binario: ");
            string numBin = Console.ReadLine();

            for (int i=numBin.Length-1; i>=0; i--)
            {
                if(numBin[i] == '1') 
                {
                    numDeci = numDeci + (Math.Pow(2,numBin.Length-1-i));
                }   
            }
            Console.WriteLine($"{numBin} in decimale è: {numDeci}");
        }

        /// <summary>
        /// sequenza di fibonacci
        /// </summary>
        private static void Esercizio4()
        {
            Console.WriteLine("Digitare un numero: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int first = 0;
            int second = 1;

            for (int i=2; i<n; i++)
            {
                int third = first+second;
                first = second;
                second = third;
            }
            Console.WriteLine($"Fibonacci: {n} -> {second}");
        }

    }
}
