using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersise5A
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Print_a_2_z_v1();
           // Print_z_2_a_v1();
            //Print_a_2_z_v2();
            //Print_a_2_z_v3();
            //Print_A_2_Z();
            //Console.WriteLine(IsLower('A'));
            Console.WriteLine(IsUpper('c'));
                //Char2Code
            //while (true)
            //{
            //    char c = Console.ReadKey().KeyChar;
            //    Console.WriteLine(" " + Char2Code(c));

            //}

        }
        public static void Print_a_2_z_v1()
        {
            int n = 0x61;
            for (int i = 1; i <= 26; i++)
            {             
                Console.WriteLine((char)n);
                n++;
            }
        }
        public static void Print_a_2_z_v2()
        {
            for (char c = 'a'; c <= 'z'; c++)
            {
                Console.WriteLine(c);
            }
        }
        public static void Print_a_2_z_v3()
        {
            //string s = "abcdeefghijlkmnoqrstuvwxyz";
            //for (int i = 0; i < s.Length; i++)
            //{
            //    Console.WriteLine(s[i]);
            //}
           
        }
        public static void Print_z_2_a_v1()
        {
            int n = 0x7A;
            for (int i = 1; i <= 26; i++)
            {
                Console.WriteLine((char)n);
                n--;
            }
        }
        public static void Print_A_2_Z()
        {
            int n = 0x41;
            for(int i = 1; i <= 26; i++ )
            {
                Console.WriteLine((char)n);
                n++;
            }
        }
        public static int Char2Code(char c)
        {
            return (int)c;
        }
        public static bool IsUpper(char c)
        {
            string s = "ABCDEFGHIJKLMNOPRSTUWXYZ";
            for (int i = 0; i < s.Length; i++)
            {
                if (c == s[i])
                    return true;
            }
            return false;
        }
        public static bool IsLower(char c)
        {
            string s = "abcdefghijlkmnoprstuvwxyz";
            for (int i = 0; i < s.Length; i++)
            {
                if (c == s[i])
                    return true;
            }
            return false;
        }
        public static char ToUpper(char c)
        {
            string s = "abcdfeghijklmnoprstuvwxyz";
            for (int i = 0; i < s.Length; i++)
            {
                if (c != s[i])
                    return c;
            }

                return c;
        }


    }
}
