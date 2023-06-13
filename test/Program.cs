using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    
    internal class Program
    { 
        static void Main(string[] args)
        {
          // first question 
         
            //Declar Variables
            double Hours = 0, Minutes = 0;
            //Get the Input
            Console.WriteLine("enter the Hours");
            //Convert From String to Double  
            Hours=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the Minutes");
            //Convert From String to Double  
            Minutes = Convert.ToDouble(Console.ReadLine());
            //Calculate The Angle
           double Angle=MethodTask.CalcuateAngle(Hours, Minutes);
            //Convert from Double to Degree
            string Result=MethodTask.CalculateAngelInDegree(Angle);
            //Print Result
            Console.WriteLine("The result is = "+ Result);
            //Hold befor End
            Console.WriteLine("\n\nenter any key to continue ...");
            Console.ReadKey();

            //end of first question
            // start second question

            // your test case ready to implement
          
            /*Bransh root = new Bransh();
            Bransh branch1 = new Bransh();
            Bransh branch2 = new Bransh();
            Bransh branch3 = new Bransh();
            Bransh branch4 = new Bransh();
            Bransh branch5 = new Bransh();
            Bransh branch6 = new Bransh();
            Bransh branch7 = new Bransh();
            Bransh branch8 = new Bransh();
            Bransh branch9 = new Bransh();
            Bransh branch10= new Bransh();
           
             root.branshes.Add(branch1);
             root.branshes.Add(branch2);
             branch1.branshes.Add(branch3);
             branch2.branshes.Add(branch4);
             branch2.branshes.Add(branch5);
             branch2.branshes.Add(branch6);
             branch4.branshes.Add(branch7);
             branch5.branshes.Add(branch8);
             branch5.branshes.Add(branch9);
             branch9.branshes.Add(branch10);
            */
           //Build the tree 
            Bransh root =MethodTask.ConstructTreeFromInput();
          // Calculate the depth of it
            int depth =MethodTask.CalculateDepth(root);

            Console.WriteLine("The Depth = "+(depth+1));
            Console.WriteLine("\n\nenter any key to continue ...");
            Console.ReadKey();



        }
    }
}
