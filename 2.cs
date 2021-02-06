using System;
using System.Collections.Generic;
					
// C# Programming Language

public class Program
{
	public static void Main()
	{
	    char vocal = 'i';
	    string[] array1 = {
	        "apa",
	        "saya",
	        "anda",
	        "kamu",
	        "hallo"
	    };
	    
	    string[] array2 = {
	        "apa yang anda lakukan?",
	        "selamat pagi",
	        "kamu ternyata cantik juga ya",
	        "yukk belajar javascript",
	        "kamu itu adalah kebanggaan saya",
	        "music hari ini yang akan di putar oleh gabut FM apa ya?"
	    };
	    
	    filterKonversiArray(array1, array2, vocal);
	}
	
	public static void filterKonversiArray (string[] words, string[] texts, char vocal)
	{
	    char[] vocals = {'a', 'i', 'u', 'e', 'o'};
	    
	    string liner = "======================";
	    Console.WriteLine("HASIL FILTER DAN KONVERSI");
	    Console.WriteLine(liner);
	    
	    foreach (string word in words) {
	        int count = 0;
	        foreach (string text in texts) {
	            if (text.Contains(word)) {
	                string[] splited = text.Split(' ');
	                foreach (string check in splited) {
	                    if (word == check) count++;
	                }
	            }
	        }
	        Console.WriteLine($"Kata \"{word}\" muncul sebanyak: {count} kali");
	    }
	    
	    Console.WriteLine(liner);
	    Console.WriteLine($"Kalimat yang dikonversi berubah menjadi \"{vocal}\"");
	    
	    foreach (string text in texts) {
	        string edited = text;
	        foreach (char checkVocal in vocals ) {
	            edited = edited.Replace(checkVocal, vocal);
	        }
	        Console.WriteLine($"{text} => {edited}");
	    }
	}
}