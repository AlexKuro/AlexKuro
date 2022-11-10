string nameRandom;
Console.WriteLine("Игра!");
Console.WriteLine("Кто из нас самый лучший!");
Console.WriteLine("Введите Ваше И М Я!!!");
nameRandom = Console.ReadLine();
if (nameRandom.ToLower() == "маша")
{
    Console.WriteLine("Урааа! Ты самая лучшая!!!");
}
else
{
    Console.WriteLine("Просто здравствуй - " + nameRandom);           
}
