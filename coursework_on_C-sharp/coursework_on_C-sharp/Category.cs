using System;

public class Category
{
    private double nadbavka;
    private string name;

    public Category(double nadbavka, string name){
        this.nadbavka = nadbavka;
        this.name = name;
    }

    public double getNadbavka(){ return nadbavka; }
    public void setNadbavka(double nadbavka) { this.nadbavka = nadbavka; }


    public string getName(){ return name; }
    public void setName(string name){ this.name = name; }

}
