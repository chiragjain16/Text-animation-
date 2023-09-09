using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Text_animation
{
    class TextAnimation 
    {
        static void Main(string[] args)
        {   
            string text = "Welcome to Qtech Mr. Chandrashekhar Sharma sir \nIt is a pleasure to welcome you as our new manager.You have an opportunity to lead a team of enthusiasts who are always willing to learn more and offer their best. I understand that we all have great expectations of each other and we are certainly going to try to meet them.Welcome again.";
            int delay = 100;                //milliseconds 
            for (int i =0; i<=text.Length; i++)
            {
                Console.Write(text[i]);
                Thread.Sleep(100); //Adjust the sleep duration to control the animation speed 

            }
            Console.WriteLine();
            
        }
    }
}
