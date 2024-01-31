
using System.Diagnostics;

Random rnd = new Random();
int cpuRandom;

bool loopActive = true; //bool - true or false

while (loopActive)
{
    cpuRandom = rnd.Next(1, 4);
    //Console.WriteLine($"cpu has generated {cpuRandom}");      //CHEAT
    Console.WriteLine("Make a guess. Enter a number 1-3");
    int userGuess = Int32.Parse(Console.ReadLine());    //Konsool loeb string formaadis, meie parsime numbriks

    if (userGuess == cpuRandom)
    {
        Console.WriteLine("Congratulations, your  guess true");
        loopActive = false; //Kui tulemus true, lõpetame tsükli - 1 variant
        //break; //Kui tulemus true, lõpetame tsükli   - 2 variant
    }
    else
    {
        Console.WriteLine("Noot good guess, try again");
    }    
  
}
Console.WriteLine("Game ended");
