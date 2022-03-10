using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat - arvuti(cpu) ja kasutaja (user)
            //mõlemad mängijad viskavad täringuid
            //programm kontrollib, kumb mängija viskas rohkem
            //mängija, kes viskab rohkem, ongi võitja
            //*täringuid visatakse kolm korda
            //programm kuulutab võitja



            int userScore = 0;
            int cpuScore = 0;


            for (int i = 0; i < 3; i++)
            {


                Random rnd = new Random();

                //arvuti vise
                int cpuRandom = rnd.Next(1, 7);

                //kasutaja vise
                int userRandom = rnd.Next(1, 7);

                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}");


                if (cpuRandom < userRandom)
                    

                {

                    Console.WriteLine("Kasutaja on mängu võitnud");
                   
                    userScore = userScore+1;

                    
                    

                }
                else if (cpuRandom > userRandom)
                {

 
                    Console.WriteLine("Arvuti on mängu võitnud");
                    
                    cpuScore = cpuScore+1;
                    

                }
                else
                {
                    Console.WriteLine("Viik!");

                }

                Console.WriteLine($"Kasutaja skoor on {userScore}");
                Console.WriteLine($"Arvuti skoor on {cpuScore}");
            }

            if(userScore > cpuScore)
            {
                Console.WriteLine($"Kasutaja lõppskoor on {userScore}. Kasutaja võitis mängu!");
                
            }
            else if(cpuScore > userScore)
            {
                Console.WriteLine($"Arvuti lõppskoor on {cpuScore}. Arvuti võitis mängu!");
            }
            



























        }
    }
}
