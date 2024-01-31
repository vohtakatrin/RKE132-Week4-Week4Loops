//Console.WriteLine("Enter a number");
//int userNumber = Int32.Parse(Console.ReadLine());
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine($"{i + 1} * {userNumber} = {(i + 1 ) * userNumber}");
//}


//string userPIN;
//int triesUsed = 0;
//while (triesUsed != 3) 
//{
//    Console.WriteLine("Enter your PIN");
//    userPIN = Console.ReadLine();
//    if (userPIN == "1234")
//    {
//        Console.WriteLine("Welcome!");
//        triesUsed = 3; //number
//    }
//    else

//    {
//        Console.WriteLine($"Wrong PIN. Try again. {3 - triesUsed} tries left.");

//        triesUsed++;
//    }
//}

//for (int i = 1; i < 5; i++)
//{
//    Console.WriteLine("Hello, World!");
//}

Random rnd = new Random();
int cpuRnd, userRnd;
int cpuScore = 0;
int userScore = 0;
for (int i = 0; i < 3; i++)
{
    cpuRnd = rnd.Next(1, 7);
    userRnd = rnd.Next(1, 7);
    if (cpuRnd > userRnd)
    {
        cpuScore++;
    }
    else if (cpuRnd < userRnd)
    {
        userScore++;
    }
    else
    {
        continue; //programm lihtsalt jätkab oma tööd
    }
}