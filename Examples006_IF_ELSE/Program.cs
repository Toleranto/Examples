Console.Write("Введите ваше имя:");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Кто ж тебя сюда звал,МАША");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}