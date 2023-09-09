using System.Text;

Console.OutputEncoding = Encoding.UTF8;
/*Console.WriteLine("Сколько сахара вы хотите?");
string input = Console.ReadLine();
int num = Convert.ToInt32(input);*/
//int kolvo = 1;
/* while (kolvo <= num)
 {
     kolvo++;
     Console.WriteLine("Добавили " + kolvo + " ложек сахара");
     Console.WriteLine("Ещё?");
     input = Console.ReadLine();

}*/

/*for (int kolvo = 0; kolvo < num; Console.WriteLine("Добавили " + kolvo + " ложек сахара"))
{
    kolvo++;
}            */
int num;
do
{ 
Console.WriteLine("Какой цвет вы любите?");
Console.WriteLine("1. Красный");
Console.WriteLine("2. Голубой");
Console.WriteLine("3. Салатовый");
Console.WriteLine("4. Фиолетовый");
Console.WriteLine("5. Выход");

int.TryParse(Console.ReadLine(), out num);

} while (num != 5);  




