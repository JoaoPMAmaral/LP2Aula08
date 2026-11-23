using System;
using System.Text;

namespace ExtendString
{
    public static class StringExtensions
    {
        private static Random random; //= new Random(); má pratica

        //construtor
        static StringExtensions()
        {
            random = new Random();
        }

        public static string ToRandomCase(this string words)
        {
            //ineficiente
            // Random random = new Random();
            // StringBuilder sb = new StringBuilder();

            // foreach(char c in words)
            // {
            //     if(random.NextDouble() < 0.5)
            //     {
            //         sb.Append(char.ToUpper(c));
            //     }
            //     else
            //     {
            //         sb.Append(char.ToLower(c));
            //     }
            // }
            // return sb.ToString();
            
            StringBuilder sb = new StringBuilder();

            foreach(char c in words)
            {
                if(random.NextDouble() < 0.5)
                {
                    sb.Append(char.ToUpper(c));
                }
                else
                {
                    sb.Append(char.ToLower(c));
                }
            }
            return sb.ToString();
        }

    }
}