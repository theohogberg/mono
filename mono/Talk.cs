using System;
namespace mono
{
    public class Talk
    {
        public String text;
        public int prereq;

        public Talk(String t)
        {
            text = t;
        }

        public Talk(String t, int p)
        {
            text = t;
            prereq = p;
        }

        public bool check(Character c)
        {

            // make character->talk.prereq check
            return true;
        }
    }
}
