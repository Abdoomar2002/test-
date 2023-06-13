using System;

public class MethodTask
{
	public MethodTask()
	{

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
    }
}
