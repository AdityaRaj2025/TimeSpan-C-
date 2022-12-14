using System;
					
public class Program
{
	public static void Main()
	{
		DateTime startDateTime = DateTime.Now;  
		DateTime endDateTime = DateTime.Now.AddDays(10);  
		TimeSpan difference = endDateTime - startDateTime;  
		Console.WriteLine("Difference from \n {0} \n and \n {1} \n = \n {2}",endDateTime, startDateTime, difference);  
		//Returns the day interval.  
		Console.WriteLine("Days = " + difference.Days);             
		//Returns total interval in days.  
		Console.WriteLine("Total Days = " + difference.TotalDays);             
		//Returns hour interval leaving days.  
		Console.WriteLine("Hours = " + difference.Hours);             
		//Returns total interval in hours.  
		Console.WriteLine("Total Hours = " + difference.TotalHours);  
		//Returns the minute interval leaving hours and days.  
		Console.WriteLine("Minutes = " + difference.Minutes);             
		//Returns total interval in minutes.  
		Console.WriteLine("Total Minutes = " + difference.TotalMinutes); 
		//Returns the second interval leaving others.  
		Console.WriteLine("Seconds = " + difference.Seconds);  
		//Returns total interval in seconds.  
		Console.WriteLine("Total Seconds =" + difference.TotalSeconds); 
		//Returns the millisecond interval leaving others.  
		Console.WriteLine("Milliseconds = " + difference.Milliseconds); 
		//Returns total interval in milliseconds.  
		Console.WriteLine("Total Milliseconds =" + difference.TotalMilliseconds);   
		//Returns total number of ticks.  
		//Ticks is basically Milliseconds * 10,000  
		Console.WriteLine("Ticks = " + difference.Ticks); 

	}
}
