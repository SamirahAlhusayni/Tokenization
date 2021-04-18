using System;
using System.Collections.Generic;

namespace tokenization
{
    class Program
    {

       
        static void Main(string[] args)
        {
            string value = "This #yua is #$ #3#4FYzDA4 #f #999y#";

            List<string> arr = ExtractColors(value);
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }


        static List<string> ExtractColors(string value)
        {
            List<string> colors = new List<string>();
            int i = 0;
            while (value.Length > i)
            {
                if (value[i] == '#')
                {
                    string color = "";

                    if (i + 1 == value.Length)
                    {
                        while (color.Length < 6)
                        {
                            color += "0";
                        }
                        colors.Add(color);

                        break;
                    }
                    i++;

                    while ("0123456789abcdefABCDEF".Contains(value[i]) && color.Length < 6)
                    {
                        color += value[i++];
                    }
                    if (color.Length < 6)
                    {
                        while (color.Length < 6)
                        {
                            color += "0";
                        }
                    }
                    colors.Add(color);
                }
                else
                {
                    i++;
                }
            }
            return colors;
        }
    }
}