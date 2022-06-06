Console.Write("Введите ваше имя: ");
string userName = Console.ReadLine();

if(userName.ToLower() == "маша")
{
    Console.WriteLine("Привет Маня!");
}
else
{
    Console.WriteLine("Привет, " + userName);
}