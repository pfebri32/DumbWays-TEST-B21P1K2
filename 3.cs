using System;
using System.Collections.Generic;
					
// C# Programming Language

public class Program
{
    public static int starsHeight = 6;
    public static string stars = "*******";
    public static string spacedStars = "*     *";
    
	public static void Main()
	{
	    cetakPola();
	}
	
	public static void cetakPola ()
	{
	    for (int i = starsHeight - 1; i >= 0; i--) {
	        for (int j = i; j >= 1; j--) {
	            Console.Write(" ");
	        }
	        if (i == 0 || i == starsHeight - 1) {
	            Console.WriteLine(stars);
	        } else {
	            Console.WriteLine(spacedStars);
	        }
	    }
	    for (int i = 0; i < starsHeight; i++) {
	        for (int j = 0; j < i; j++) {
	            Console.Write(" ");
	        }
	        if (i == 0 || i == starsHeight - 1) {
	            Console.WriteLine(stars);
	        } else {
	            Console.WriteLine(spacedStars);
	        }
	    }
	}
}