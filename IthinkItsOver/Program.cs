namespace IthinkItsOver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pasition = 0;
            int position= 0;
            int cost = 0;
            string tort = " ";
            while (true)
            {
                Menu(cost, tort);
                ConsoleKeyInfo key = Console.ReadKey();
                position = ArrowNigg();
                Console.SetCursorPosition(0, 7);
                if (position == 3)
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Для выхода нажмите Escape");
                    Console.WriteLine("Выберите пункт из меню");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("  Круг - 500"); //3
                    Console.WriteLine("  Квадрат  - 500");//4
                    Console.WriteLine("  Прямоугольник - 500");//5
                    Console.WriteLine("  Сердечко - 700");//6
                    pasition = ArrowNigg();
                    string tri = "Круг - 500";
                    string four = "Квадрат  - 500";
                    string five = "Прямоугольник - 500";
                    string six = "Сердечко - 700";
                    if (pasition == 3)
                    {
                        cost = cost + 500;
                        tort = tort + tri + ";";
                    }
                    if (pasition == 4)
                    {
                        cost = cost + 500;
                        tort = tort + four + ";";
                    }
                    if (pasition == 5)
                    {
                        cost = cost + 500;
                        tort = tort + five + ";";
                    }
                    if (pasition == 6)
                    {
                        cost = cost + 700;
                        tort = tort + six + ";";
                    }
                }
                if (position == 4)
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Для выхода нажмите Escape");//0
                    Console.WriteLine("Выберите пункт из меню");//1
                    Console.WriteLine("----------------------");//2
                    Console.WriteLine("  Маленький (Диаметр - 16 см, 8  порций) - 1000");//3
                    Console.WriteLine("  Обычный (Диаметр - 18 см, 10 порций) - 1200");//4
                    Console.WriteLine("  Большой (Диаметр - 28 см, 24 порции) - 2000");//5
                    pasition = ArrowNigg();
                    string tru = "  Маленький (Диаметр - 16 см, 8  порций) - 1000";
                    string fru = "  Обычный (Диаметр - 18 см, 10 порций) - 1200";
                    string fuv = "  Большой (Диаметр - 28 см, 24 порции) - 2000";
                    if (pasition == 3)
                    {
                        cost = cost + 1000;
                        tort = " " + tort + tru + ";";
                    }
                    if (pasition == 4)
                    {
                        cost = cost + 1200;
                        tort = " " + tort + fru + ";";
                    }
                    if (pasition == 5)
                    {
                        cost = cost + 2000;
                        tort = tort + fuv + ";";
                    }
                }
                if (position == 5)
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Для выхода нажмите Escape");//0
                    Console.WriteLine("Выберите пункт из меню");//1
                    Console.WriteLine("----------------------");//2
                    Console.WriteLine("  Ванильный - 100");//3
                    Console.WriteLine("  Шоколадный - 100");//4
                    Console.WriteLine("  Карамельный - 150");//5
                    Console.WriteLine("  Ягодный - 200");//6
                    Console.WriteLine("  Кокосовый - 250");//7
                    pasition = ArrowNigg();
                    string tra = "  Ванильный - 100";
                    string fra = "  Шоколадный - 100";
                    string fav = "  Карамельный - 150";
                    string sax = "  Ягодный - 200";
                    string svn = "  Кокосовый - 250";
                    if (pasition == 3)
                    {
                        cost = cost + 100;
                        tort = " " + tort + tra + ";";
                    }
                    if (pasition == 4)
                    {
                        cost = cost + 100;
                        tort = " " + tort + fra + ";";
                    }
                    if (pasition == 5)
                    {
                        cost = cost + 150;
                        tort = " " + tort + fav + ";";
                    }
                    if (pasition == 6)
                    {
                        cost = cost + 200;
                        tort = " " + tort + sax + ";";
                    }
                    if (pasition == 7)
                    {
                        cost = cost + 250;
                        tort = " " + tort + svn + ";";
                    }
                }
                if (position == 6)
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Для выхода нажмите Escape");//0
                    Console.WriteLine("Выберите пункт из меню");//1
                    Console.WriteLine("----------------------");//2
                    Console.WriteLine("  1 корж - 200");//3
                    Console.WriteLine("  2 коржа - 400");//4
                    Console.WriteLine("  3 коржа 600");//5
                    Console.WriteLine("  4 коржа - 800");//6
                    pasition = ArrowNigg();
                    string trs = "  1 корж - 200";
                    string frs = "  2 коржа - 400";
                    string fsv = "  3 коржа 600";
                    string ssx = "  4 коржа - 800";
                    if (pasition == 3)
                    {
                        cost = cost + 200;
                        tort = " " + tort + trs + ";";
                    }
                    if (pasition == 4)
                    {
                        cost = cost + 400;
                        tort = " " + tort + frs + ";";
                    }
                    if (pasition == 5)
                    {
                        cost = cost + 600;
                        tort = " " + tort + fsv + ";";
                    }
                    if (pasition == 6)
                    {
                        cost = cost + 800;
                        tort = " " + tort + ssx + ";";
                    }
                }
                if (position == 7)
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Для выхода нажмите Escape");
                    Console.WriteLine("Выберите пункт из меню");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("  Шоколад - 100");
                    Console.WriteLine("  Крем - 100");
                    Console.WriteLine("  Бизе - 150");
                    Console.WriteLine("  Драже - 150");
                    Console.WriteLine("  Ягоды - 200");
                    pasition = ArrowNigg();
                    string trq = "  Шоколад - 100";
                    string frq = "  Крем - 100";
                    string fqv = "  Бизе - 150";
                    string sqx = "  Драже - 150";
                    string sqn = "  Ягоды - 200";
                    if (pasition == 3)
                    {
                        cost = cost + 100;
                        tort = " " + tort + trq + ";";
                    }
                    if (pasition == 4)
                    {
                        cost = cost + 100;
                        tort = " " + tort + frq + ";";
                    }
                    if (pasition == 5)
                    {
                        cost = cost + 150;
                        tort = " " + tort + fqv + ";";
                    }
                    if (pasition == 6)
                    {
                        cost = cost + 150;
                        tort = " " + tort + sqx + ";";
                    }
                    if (pasition == 7)
                    {
                        cost = cost + 200;
                        tort = " " + tort + sqn + ";";
                    }
                }
                if (position == 8)
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Для выхода нажмите Escape");//0
                    Console.WriteLine("Выберите пункт из меню");//1
                    Console.WriteLine("----------------------");//2
                    Console.WriteLine("  Шоколадная - 150");//3
                    Console.WriteLine("  Ягодная - 150");//4
                    Console.WriteLine("  Кремовая - 150");//5
                    pasition = ArrowNigg();
                    string tru = "  Шоколадная - 150";
                    string fru = "  Ягодная - 150";
                    string fuv = "  Кремовая - 150";
                    if (pasition == 3)
                    {
                        cost = cost + 150;
                        tort = " " + tort + tru + ";";
                    }
                    if (pasition == 4)
                    {
                        cost = cost + 150;
                        tort = " " + tort + fru + ";";
                    }
                    if (pasition == 5)
                    {
                        cost = cost + 150;
                        tort = " " + tort + fuv + ";";
                    }
                }
                if (position == 9)
                {
                    Console.Clear();
                    Console.WriteLine("Спасибо за заказ.");
                    break;
                }
                Console.Clear();
            }
        }
        static void Menu(int cost, string tort) //Меню в котором всё будет
        {
            Console.WriteLine("Заказ тортов в АГОНИЯ, торты на ваш выбор.");
            Console.WriteLine("Выберите параметр торта");
            Console.WriteLine("-----------------------");
            Console.WriteLine("  Форма торта");
            Console.WriteLine("  Размер торта");
            Console.WriteLine("  Вкус коржей");
            Console.WriteLine("  Количество коржей");
            Console.WriteLine("  Глазурь");
            Console.WriteLine("  Декор");
            Console.WriteLine("  Конец заказа");
            Console.WriteLine("  ");
            Console.WriteLine("Цена: " + cost); //через инт
            Console.WriteLine("Ваш торт: " + tort); //через стринг
        }
        static int ArrowNigg()
        {
            int position = 6;
            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key != ConsoleKey.Enter)
            {
                Console.SetCursorPosition(0, position);
                Console.WriteLine("  ");

                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                }
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

                key = Console.ReadKey();
            }
            return position;
        }
    }
}
//Короче, если все будет норм, просто пишу в условия после выбора ещё методы в которых
//будет дальше че там по программе. Главно сделать.