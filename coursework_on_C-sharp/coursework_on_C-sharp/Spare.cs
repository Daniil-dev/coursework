namespace coursework_on_C_sharp
{
    internal class Spare : Item
    {
        protected string name;
        protected double price;
        protected int amount;
        protected Category category;

        public Spare(string name, double price, int amount){
            this.name = name;
            this.price = price;
            this.amount = amount;
            this.category = new Category(1, "");
        }
        public Spare(string name, double price, int amount, Category category)
        {
            this.name = name;
            this.price = price;
            this.amount = amount;
            this.category = category;
        }
        public Spare(string name, double price, int amount, string nameCategory, double nadbavka){
            this.name = name;
            this.price = price;
            this.amount = amount;
            this.category = new Category(nadbavka, nameCategory);
        }
       


        public string getName() { return name; }

        public double getPrice() { return price; }

        public int getAmount() { return amount; }
        public void setAmount(int amount) { this.amount = amount; }

        public Category getCategory(){ return category; }
        public void setCategory(Category category) { this.category = category; }

        public double getFullPrice() { return price * category.getNadbavka();}
        



    }
}