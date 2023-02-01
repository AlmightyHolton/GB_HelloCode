Console.Write("Введите имя пользователя");
string username = Console.ReadLine ();

if(username.ToLower() == "cофия")
{
    Console.WriteLine("Ура, это же СОФИЯ!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}