// Задача 19: Напишите программу которая принимает на вход 
// пятизначное число, проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
int numeric = Convert.ToInt32 (Console.ReadLine());
int [] Num = {0,0,0,0,0};
int i = 0;

while (i<=4)
{
    Num[i] = numeric % 10 ;
    numeric = numeric / 10 ;
     i+=1;
}

 if ( Num [0] == Num [4] && Num [1] == Num [3])
  {
    Console.WriteLine(Num);
    Console.WriteLine("Число является палиндромом" );
  }
else
{
    Console.WriteLine(Num);
    Console.WriteLine("Число не является палиндромом" );
}
