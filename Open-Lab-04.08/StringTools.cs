using System;

namespace Open_Lab_04._08
{
    public class StringTools
    {
        public string[] IsFourLetters(string[] strings)
        {
            int i = 0;
            var list = new List<string>();
            foreach(string str in strings)
            {
               if (str.Length == 4)
               {
                    list.Insert(i, str);
                 i++;
               }
            }
            return list.ToArray();
        }
    }
}
