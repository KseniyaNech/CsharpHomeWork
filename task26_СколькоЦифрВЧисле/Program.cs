/*
26. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

int userNum = 68;
int amountOfDigits(int userNum)
{
    int count = 0;
    while(userNum > 0)
    {
        userNum /= 10;
        count++;
    }
    
    return count;
}

System.Console.WriteLine(amountOfDigits(userNum));
