using System; 

  

namespace ConsoleApp41 

{ 

    class Program 

    { 

        static void Main(string[] args) 

        { 
            string s3 = "kolev@kolev.com is the e-mail of Ivo Kolev";

            string s1 = "kolev"; 

            string s2 = "KOLEV"; 

  

            int d1 = s3.IndexOf(s1); 

            int d2 = s3.LastIndexOf(s1); 

            int d3 = s3.IndexOf(s2); 

            Console.WriteLine(d1); 

            Console.WriteLine(d2); 

            Console.WriteLine(d3); 

        } 

    } 

} 