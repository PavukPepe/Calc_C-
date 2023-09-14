/*Console.WriteLine("Хотите ли вы сахар в чае: ");
string txt = Console.ReadLine();
while (txt == "да")
{
    Console.WriteLine("Добавляем сахар");
    Console.WriteLine("Еще?");
    txt = Console.ReadLine();
}*/

/*
Console.WriteLine("Сколько ложек сахара вы хотите: ");
int txt = Convert.ToInt32(Console.ReadLine());
int cl = 1;
while (cl!=txt+1)
{
    Console.WriteLine("Добавил " + cl + " ложек сахара");
    cl ++;
}*/

int k = 1000;
while (k>0)
    {
    Console.WriteLine(Convert.ToString(k) + " - 7 = " + Convert.ToString(k-7));
    k -= 7;
}