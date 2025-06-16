Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if (username.ToLower() == "маша") // .ToLower() переводит все символы строки в нижний регистр
{
    Console.WriteLine("Ура! Это же Маша!");
}
else
{ 
     Console.WriteLine("Привет, " + username);
}
