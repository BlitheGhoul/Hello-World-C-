Console.Write ("Введите Ваше имя: ");
string name = Console.ReadLine();
if (name.ToLower() == "маша")
{
    Console.WriteLine ("О! Да это ж Маша!");
}
else
{
    Console.WriteLine ("Привет, " + name);
}
