using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgrammingBlockchain.Chapters;

namespace ProgrammingBlockchain
{
    public class Program
    {
        static void Main(string[] args)
        {
            // select the chapter here
            var chapter = new Chapter1();

            // call the lesson here
            chapter.Lesson1();

            // this will hold the window open for you to read the output
            Console.WriteLine("\n\n\nPress enter to continue.");
            Console.ReadLine();
        }
    }
    
}
