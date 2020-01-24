using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace coursework_on_C_sharp
{
    class SoldHistory
    {

        private List<Sold> history;
        private int i = 0;

        public SoldHistory()
        {
            history = new List<Sold>();
        }


        public List<Sold> getHistory() { return history; }

        public void addRecord(Sold sold) { history.Add(sold); }
        public void addRecord(int amount, string name, double sum) { history.Add(new Sold(amount, name, sum)); }


        public void readHistory()
        {
            Console.WriteLine("------------История продаж------------");
            foreach (Sold sold in history)
                Console.WriteLine(sold);
            Console.WriteLine("--------------------------------------");
        }

        public void saveHistory()
        {
            string path = "C:\\Users\\Public\\Documents\\Histories";
            string today = DateTime.Today.ToString().Substring(0, 10).Replace(".", "_");

            Directory.CreateDirectory(path);

            for (; i < history.Count; i++)
                File.AppendAllText(path + "\\" + today + ".txt", history[i].ToString());
            
        }


    }
}
