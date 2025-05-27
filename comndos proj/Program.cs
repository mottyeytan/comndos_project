using System;



namespace MyNamespace
{
    public enum Status
    {
        standing,
        walking,
        hiding
    }
    public class Commando
    {
       private string Name { get; set; }
       private string CodeName { get; set; }
       private string[] Tools = new string[] { "Hammer", "Chisel", "Rope","Bag","Watery" };
       private Status Status { get; set; }


       public Commando(string name, string codeName, string[] tools, Status status)
       {
           this.Name = name;
           this.CodeName = codeName;
           this.Tools = tools;
           this.Status = status;
       }

       public void Walk()
       {
           this.Status = Status.walking;
           Console.WriteLine("The soldier is walking");
       }

       public void Hide()
       {
           this.Status = Status.hiding;
           Console.WriteLine("The soldier is hiding");
       }
    }
}

