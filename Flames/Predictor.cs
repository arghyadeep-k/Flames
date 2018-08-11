using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flames
{
    class Predictor
    {
        private string name1;
        private string name2;
        private List<char> flames=new List<char>();
        
        private int count;
        public Predictor(string name1, string name2)
        {
            this.name1 = name1.ToLower(); 
            this.name2 = name2.ToLower(); 
            this.count = name1.Length + name2.Length;
            flames.Add('F');
            flames.Add('L');
            flames.Add('A');
            flames.Add('M');
            flames.Add('E');
            flames.Add('S');
        }

        public string Compute()
        {
            char c;
            for(int i = 0; i<name1.Length; i++)
            {
                c = name1[i];
                //Console.Write(c);
                int num = 0;
                if (c != '#')
                {
                    num = NoOfOccurence(c, name2);
                    count -= num;
                    if (num > 0)
                    {
                        num = NoOfOccurence(c, name1);
                        count -= num;
                    }
                    name1 = name1.Replace(c, '#');
                }
                
            }
            return FinalCount(count);
        }

        private string FinalCount(int count)
        {
            int index1 = 0;
            int index2 = 0;

            while (flames.Count>1)
            {
                if (index1 == (count - 1))
                {
                    flames.RemoveAt(index2);
                    index1 = -1;
                    index2--;
                }
                index1++;
                index2++;
                if (index2 >= flames.Count)
                    index2 = 0;
            }
            char c = flames.ElementAt(0);

            switch(c)
            {
                case 'F':
                    return "Friends";
                case 'L':
                    return "Lovers";
                case 'A':
                    return "having an Affair";
                case 'M':
                    return "Marrying";
                case 'E':
                    return "Enemies";
                case 'S':
                    return "Siblings";
                default:
                    return "";
            }
        }

        private int NoOfOccurence(char character,string name)
        {
            int occurence = 0;
            foreach(char c in name)
            {
                if (c == character)
                {
                    occurence++;
                }
            }
            return occurence;
        }
    }
}
