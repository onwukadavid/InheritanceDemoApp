using System;

class Parent
{
    public int PubA;
    private int PriA;
    protected int ProA;

    public Parent()
    {
    }
    public Parent(int priA, int proA, int pubA)
    {
        PriA =priA;
        ProA = proA;
        PubA = pubA;
    }
}

class Child : Parent
{
    public int PubB;
    public Child()
    {
    }
    public Child(int priA, int proA, int pubA,int pubB)
       :base (priA,proA,pubA)//used to pass data to the parent or base class and initialize in the base class.
    {
       // PriA =priA;
      //  ProA = proA;
       // PubA = pubA;
        PubB = pubB;
    }
   
} 
class Program
{
    static void Main(string[] args)
    {
        Parent p;
        Child c;
        p = new Child();
        //c = (Child)p;
        c = p as Child;

     }
    }

