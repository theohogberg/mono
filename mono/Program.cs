using System;
using System.Collections.Generic;

using mono;

namespace Example1
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            //using (var game = new Game1())
            //game.Run();
            Character u = new Character("Uffe");
            Talk a = new Talk("Jag gillar glass");
            Talk b = new Talk("Jag grillar glas");
            List<Talk> uffeTalks = new List<Talk>();
            uffeTalks.Add(a);
            uffeTalks.Add(b);
            DialogNode dn = new DialogNode(u, uffeTalks);
            String talk = dn.getTalk();
            Console.WriteLine(talk);

            //List<DialogNode> dialogList = new List<DialogNode>();
            //Dialog d = new Dialog(dialogList);
        }
    }
}