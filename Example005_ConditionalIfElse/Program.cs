Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша") //если пользователь напишет имя с маленькой буквы или только большими или вперемежку

{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}