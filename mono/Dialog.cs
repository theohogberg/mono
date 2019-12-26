using System;
using System.Collections.Generic;

using mono;

namespace mono
{
    public class Dialog
    {
        Dictionary<int, List<DialogNode>> dialog;

        public Dialog(List<DialogNode> lo)
        {
            dialog.Add(0, lo);
        }

        public void print(String opt, String talker)
        {   
            
        }

    }
}
