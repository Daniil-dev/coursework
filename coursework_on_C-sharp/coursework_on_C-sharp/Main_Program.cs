using System;
using System.Threading;


namespace coursework_on_C_sharp
{
    class Main_Program
    {
        static void Main(string[] args)
        {
            
            Storeroom store = new Storeroom();
            store.addItem(new Spare("Двигатель", 100_000.0, 30, "Крупные детали", 1.2));
            store.addItem(new Spare("Коробка передач", 70_000.0, 24, "Крупные детали", 1.2));
            store.addItem(new Spare("Капот", 20_000.0, 54, "Внешние детали", 1.1));


            while (true)
            {
                Console.WriteLine("Выберите действие:\n" +
                    "1)Добавить деталь\n" +
                    "2)Купить деталь\n" +
                    "3)Вывести историю продаж\n" +
                    "4)Выйти из программы");
                
                char numb = Console.ReadKey(true).KeyChar;
                Console.Clear();


                if (numb == '1')
                {
                    Thread.Sleep(500);
                    try
                    {
                        Console.Write("Введите параметры детали:\nназвание: ");
                        string name = Console.ReadLine();

                        Console.Write("цена: ");
                        double price = double.Parse(Console.ReadLine());

                        Console.Write("количество: ");
                        int amount = Int32.Parse(Console.ReadLine());

                        Console.Write("Название категории: ");
                        string nameCategory = Console.ReadLine();

                        Console.Write("Надбавка в этой категории: ");
                        double nadbavka = double.Parse(Console.ReadLine());

                        if (name.Trim().Length == 0 || price < 0.0 || amount < 1 || nameCategory.Trim().Length == 0 || nadbavka < 1.0)
                            throw new FormatException();

                        store.addItem(new Spare(name, price, amount, nameCategory, nadbavka));
                        Console.WriteLine(new String('-', 30) + "\nДеталь успешно добавлена!\n" + new String('-', 30));
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine(new String('-', 60) + "\nДеталь не была добавлена! Вы ввели не правильные данные\n" + new String('-', 60));
                    }

                    Thread.Sleep(1000);
                    Console.WriteLine("Нажмите любую клавишу");
                    Console.ReadKey(true);
                    Console.Clear();
                    continue;
                }

                if (numb == '2')
                {
                    Thread.Sleep(500);

                    Console.WriteLine("Показать каталог: Y/Н ?");
                    char numb2 = Console.ReadKey(true).KeyChar;
                    
                    Console.Clear();

                    if (numb2.ToString().ToLower().Equals("y") || numb2.ToString().ToLower().Equals("н")) 
                        store.getItemName();

                    try
                    {
                        Console.Write("Введите данные для покупки:\nназвание/номер: ");
                        string name = Console.ReadLine();

                        Console.Write("количество: ");
                        int amount = Int32.Parse(Console.ReadLine());

                        store.soldItem(amount, name);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine(new String('-', 40) + "\nВы ввели не правильные данные\n" + new String('-', 40));
                    }

                    store.getSoldHistory().saveHistory();

                    Thread.Sleep(1000);
                    Console.WriteLine("Нажмите любую клавишу");
                    Console.ReadKey(true);
                    Console.Clear();
                    continue;
                }

                if (numb == '3')
                {
                    store.getSoldHistory().readHistory();

                    Thread.Sleep(1000);
                    Console.WriteLine("Нажмите любую клавишу");
                    Console.ReadKey(true);
                    Console.Clear();
                    continue;
                }

                if (numb == '4') break;
                
            }
        }
    }
}
