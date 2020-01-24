using System;
using System.Collections.Generic;
using System.Text;


namespace coursework_on_C_sharp{
    class Sold{
        private DateTime data;
        private int      amount;
        private string   name;
        private double   sum;

        public Sold(int amount, string name, double sum){
            data = DateTime.Now;
            this.amount = amount;
            this.name = name;
            this.sum = sum;
        }

        public DateTime getData() { return data; }
        public int getQuantity() { return amount; }
        public string getName() { return name; }
        public double getSum() { return sum; }

        public override string ToString(){
            return "\nНазвание: " + name + "\nДата продажи: " +
                data + "\nКоличество товара: " + amount + "\nCумма: " + sum + "\n";
        }
    }
}
