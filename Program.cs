using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool inputisvalid = false;
            if(!inputisvalid)
            {
                
                    int A = int.Parse       (Console.ReadLine());
                    int B = int.Parse(Console.ReadLine());
                    int C = int.Parse(Console.ReadLine());
                    
            }
            else
            {
                Console.WriteLine("Invalid");
            }

        
        }
        public static bool Get(int A, int B, int C)
        {
            if(C == 0 && A >= 14 && B >= 14)
            {
                return true;
            }
            else if (C > 0 && A > 2 * (C + 1) && B > 2 *(C + 1))
            {
                return true;
            }
            else 
            {
                if(A < 0 || B < 0 || C < 0)
                {
                    Console.WriteLine("Invalid");
                }
                return false;
            }
            
        }
    }
}
