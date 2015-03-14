using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpyHard
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            string mess = Console.ReadLine();
            string[] messParts = mess.Split();



            long result = 0;

            foreach (var symbol in mess)
            {
                if (symbol >= 'a' && symbol <= 'z')
                {
                    result += symbol - 'a' + 1;
                }
                else if (symbol >= 'A' && symbol <= 'Z')
                {
                    result += (symbol - 'A' + 1);
                }
                else
                {
                    result += symbol;
                }
            }

            int countDigits = 0;
            for (int i = 0; i < mess.Length; i++)
            {

                countDigits += 1;

            }

            switch (key)
            {
                case 7:
                    {
                        int s = 7;
                        for (int i = 0; i < result/s; i++)
                        {
                            long newresult = result % s;
                            while (newresult > s)
                            {
                                long newresult3 = newresult % s;
                                Console.WriteLine("{0}{1}{2}", key, countDigits, newresult3);
                            }  
                                Console.WriteLine("{0}{1}{2}", key, countDigits, newresult);
                           }    
                      } ;
                        break;
                    }
            Console.WriteLine("{0}{1}" + (Convert.ToString(result, key)), key, countDigits);
            }

        }
    }


    

