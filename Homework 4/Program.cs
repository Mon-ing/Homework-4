using System;
class Program
{
    static void Main(string[] args)
    {
       
        Stack<string> stack = new Stack<string>();
        Tree<string> tree = new Tree<string>();
        
        string Name = "Head";
        tree.AddChild(-1,Name);
        string AbsentName = "";
        string SiplingName = "";
        string GeneralName = "";
        string HeadName = Console.ReadLine();
        tree.AddChild(0,HeadName);
        int Headamount = int.Parse(Console.ReadLine());
        int amount = 0;
        int Siplingamount = 0;
        Manage(ref amount,ref Headamount, ref Siplingamount,ref tree,ref GeneralName, ref SiplingName);
        AbsentName = Console.ReadLine();
    }
    static void Manage(ref int amount,ref int Headamount ,ref int Siplingamount, ref Tree<string> tree, ref string GeneralName, ref string SiplingName)
    {
        for(int x = 1; x<=Headamount; x++)
        {
                
            GeneralName = Console.ReadLine();
            tree.AddChild(x,GeneralName);       
            amount = int.Parse(Console.ReadLine());
            Lower(ref amount,ref Headamount ,ref Siplingamount, ref tree, ref GeneralName, ref SiplingName);
                
        }      
    }
    static void Lower(ref int amount,ref int Headamount ,ref int Siplingamount, ref Tree<string> tree, ref string GeneralName, ref string SiplingName)
    {
        for(int j =1; j<= amount; j++)
        {
                
            SiplingName = Console.ReadLine();
            tree.AddSibling(j,SiplingName);
            Siplingamount= int.Parse(Console.ReadLine());
            if(Siplingamount > 0) Manage(ref amount,ref Headamount ,ref Siplingamount, ref tree, ref GeneralName, ref SiplingName);
                
        }
    }
}