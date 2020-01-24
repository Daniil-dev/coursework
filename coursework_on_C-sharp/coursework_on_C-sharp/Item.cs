using System;


public interface Item
{
    public int getAmount();
    public void setAmount(int Amount);
    public Category getCategory();
    public void setCategory(Category category);
    public double getPrice();
    public string getName();
    public double getFullPrice();
}
