using System;
using System.Collections.Generic;
using System.Linq;

public class MethodTask
{
	public  MethodTask()
	{
       
    }
    //Calculate Angle in Degree 
    public static string CalculateAngelInDegree(double angle)
    {
        double degree = 0, minutes = 0, secondes = 0;
        degree = (int)angle;
        minutes = (int)((angle - degree) * 60);
        secondes = (int)((angle - degree) * 60 - minutes) * 60;
        string result = degree.ToString() + " degree " + minutes.ToString() + " minutes " + secondes.ToString() + " seconds";
        return result;
    }
    public static double CalcuateAngle(double Hours, double Minutes)
    {
        double angle = 0;
        int angeleOfHours = 30, angleOfMinutes = 6, angleFromMinutesToHours = 12;
        //calculate the angle
        Hours %= 12;
        Minutes %= 60;

        angle = Math.Abs((Hours * angeleOfHours) + (Minutes * angleOfMinutes) / angleFromMinutesToHours - (Minutes * angleOfMinutes));
        //check the small angle
        if (angle > 180)
            angle = 360 - angle;
        return angle;
    }
    public static int CalculateDepth(Bransh root)
    {
        if(root.branshes.Count>0)
        return GetDepth(root, 1);
        else return 0;
    }
    private static int GetDepth(Bransh root,int depth)
    {
        
        int maxDepth = depth;
       
        foreach (Bransh bransh in root.branshes)
        {

            if (bransh.branshes.Count > 0)
            {

                int subdepth = GetDepth(bransh, depth + 1);
                maxDepth = maxDepth < subdepth ? subdepth : maxDepth;
            }
        }
        
    
        return maxDepth;
    }
    
    public static Bransh ConstructTreeFromInput()
    {
        Console.WriteLine("Enter the number of branches:");
        int numBranches = Convert.ToInt32(Console.ReadLine());

        Bransh root = new Bransh();
        ConstructBranches(root, numBranches);

        return root;
    }

    private static void ConstructBranches(Bransh parent, int numBranches)
    {
        for (int i = 1; i <= numBranches; i++)
        {
            Console.WriteLine("Enter the number of branches for branch " + i + ":");
            int numChildBranches = Convert.ToInt32(Console.ReadLine());

            Bransh branch = new Bransh();
            parent.branshes.Add(branch);

            if (numChildBranches > 0)
            {
                ConstructBranches(branch, numChildBranches);
            }
        }
    }

}
