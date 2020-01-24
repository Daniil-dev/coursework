using System;
using System.Collections.Generic;
using System.Text;

namespace coursework_on_C_sharp
{
    class Storeroom
    {
        private List<Item> item;
        private SoldHistory soldHistory;

        public Storeroom()
        {
            item = new List<Item>();
            soldHistory = new SoldHistory();
        }

        public void soldItem(int amount, string name)
        {
            int i = 0;

            try
            {
                i = Int32.Parse(name.Trim()) - 1;
            }
            catch (System.FormatException)
            {
                bool exist = false;
                
                for (; i < item.Count; i++)
                {
                    if (item[i].getName() == name.Trim())
                    {
                        exist = true;
                        break;
                    }
                }

                if (!exist)
                {
                    Console.WriteLine(new String('-', 30) + "\nТакой детали не существует!\n" + new String('-', 30));
                    return;
                }
            }

            if (item[i].getAmount() >= amount)
            {
                item[i].setAmount(item[i].getAmount() - amount);
            }
            else
            {
                Console.WriteLine(new String('-', 35) + "\nНет достаточного кол-ва деталей\n" + new String('-', 35));
                return;
            }
            
            soldHistory.addRecord(amount, item[i].getName(), item[i].getFullPrice() * amount);

            Console.WriteLine(new String('-', 50) + "\nБыло продано товара: " + amount + ", типа: " + item[i].getName() + "\n" + new String('-', 50));
        }

        public void addItem(Spare spare) { item.Add(spare); }
        public void getItemName()
        {
            Console.WriteLine(new String('-', 40));

            for (int i = 0; i < item.Count; i++)
                Console.WriteLine("\t" + (i + 1) + ")" + item[i].getName() + ", кол-во:" + item[i].getAmount());

            Console.WriteLine(new String('-', 40));
        }

        public SoldHistory getSoldHistory() { return soldHistory; }





    }
}
