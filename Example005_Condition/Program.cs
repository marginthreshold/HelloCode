Console.WriteLine("Введите имя");
string username = Console.ReadLine();

if (username.ToLower()=="маша")
{
    Console.WriteLine("Ура, привет МАША!!!");
}
else
{
    Console.Write("Привет, "+ username);
}