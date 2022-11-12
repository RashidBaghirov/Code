#region Verilen eded 2nin quvvetidirmi?


//Console.Write("Write number: ");

//string numstr = Console.ReadLine();
//int num = Convert.ToInt32(numstr);

//while (num % 2 == 0)
//{
//    num /= 2;
//}
//if (num == 1)
//{
//    Console.WriteLine("Yes");
//}
//else
//{
//    Console.WriteLine("NO");

//}
#endregion

#region Verilen ededler arasindaki ededleri ekrana cixaran alqoritm.
//Console.Write("Choose the number: ");

//var numstr = Console.ReadLine();
//Console.Write("Choose the other number: ");
//var numstr2 = Console.ReadLine();

//int num1 = Convert.ToInt32(numstr);
//int num2 = Convert.ToInt32(numstr2);
//Console.WriteLine("Numbers : ");
//for (int i = num1; i <= num2; i++)
//{

//    Console.WriteLine(i);
//}

#endregion

#region Eded 70 den boyukdurse
//Console.Write("Bir eded teyin edin: ");

//string numstr = Console.ReadLine();
//int num = Convert.ToInt32(numstr);
//int count = 70;
//int result = 0;
//if (num > count)
//{
//    result = (num - count) * 3;
//    Console.WriteLine("Ferqinin 3qati: " + result);
//}
//else
//{
//    result = count - num;
//    Console.WriteLine("Ferqi: " + result);
//}
#endregion

#region Hansi eded daha boyukdur.
//Console.Write("Bir eded qeyd edin: ");
//string numstr1 = Console.ReadLine();
//Console.Write("Ferqli ikinci ededi secin: ");
//string numstr2 = Console.ReadLine();
//Console.Write("Ferqli Ucuncu ededi secin: ");
//string numstr3 = Console.ReadLine();
//int x = Convert.ToInt32(numstr1);
//int y = Convert.ToInt32(numstr2);
//int z = Convert.ToInt32(numstr3);

//if (x > y && x > z)
//{
//    Console.WriteLine("Bu eded daha boyukdur:" + x);
//}
//else if (y > z && y > x)
//{
//    Console.WriteLine("Bu eded daha boyukdur:" + y);
//}
//else
//{
//    Console.WriteLine("Bu eded daha boyukdur:" + z);
//}
#endregion

#region 2 eded arasindaki tek ededler


Console.Write("Bir eded secin: ");

string numstr = Console.ReadLine();

Console.Write("Ikinci ededi secin: ");

string numst = Console.ReadLine();

int n = Convert.ToInt32(numstr);
int m = Convert.ToInt32(numst);
int count = 0;
Console.Write("Arasinda tek ededlerin sayi: ");
for (int i = n; i <= m; i++)
{
    if (i % 2 == 0)
    {

    }

    else
    {
        count++;
    }
}

Console.WriteLine(count);

#endregion
