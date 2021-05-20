using System;
class CParent
{
    public int N;
    public virtual void Foo()
    {
        Console.WriteLine("in parent");
    }
}
class CChild : CParent
{
    public new int N;
    public new virtual void Foo()
    {
        Console.WriteLine("in child");
    }
}
class CGrandChild : CChild
{
    public override void Foo()
    {
        Console.WriteLine("in grandchild");
    }
}
class BindingDemoProgram
{
    static void Main(string[] args)
    {
        CParent p = new CGrandChild();
        p.Foo();
     //   p.N = 10;
        ((CChild)p).N = 10;
    }
}