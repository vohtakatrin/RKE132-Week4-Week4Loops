Random rnd = new Random();

//int myRandomNum = rnd.Next(0, 21);                        //genereerib 0-20 - 1 väärtus
//Console.WriteLine($"Random number is: {myRandomNum}");

int myRandomSum = 0;
int myRandomNum;
//for (int i = 0; i < 3; i++)                              //Saada mitu juhuslikku numbri
//{
//    myRandomNum = rnd.Next(0, 21);
//    Console.WriteLine($"Random number is: {myRandomNum}");
//}
for (int i = 0; i < 3; i++)                                //Saada mitu juhuslikku numbri ja nende summa
{
    myRandomNum = rnd.Next(0, 21);
    myRandomSum = myRandomSum + myRandomNum;
    Console.WriteLine($"Random number is: {myRandomNum}");
}
Console.WriteLine($"Random sum total: {myRandomSum}");