using System;
using System.Collections.Generic;

namespace mono
{
    public class DialogNode
    {
        Character ch;
        List<Talk> listTalk;

        public DialogNode(Character c, List<Talk> l)
        {
            ch = c;
            listTalk = l;
        }

        public void setCharacter(Character c)
        {
            ch = c;
        }

        public void addTalk(Talk t)
        {
            listTalk.Add(t);
        }

        public String getTalk()
        {
            String t = ch.name;

            foreach (Talk talk in listTalk)
            {
                if (talk.check(ch))
                {
                    t = t + ": " + talk.text;
                    break;
                }
            }

            return t;
        }
    }
}
